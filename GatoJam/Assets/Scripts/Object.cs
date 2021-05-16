using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] Hud_Manager hud;
    public SpawnManager ScoreSO;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Rigidbody2D rb;

    public int randomIndex;
    [SerializeField] int score;
    Color Random_color;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        ScoreSO = FindObjectOfType<SpawnManager>();
        hud = FindObjectOfType<Hud_Manager>();

        Random_color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        randomIndex = Random.Range(0, ScoreSO.ObjectList.Count);

        score     = ScoreSO.ObjectList[randomIndex].points;
        sr.sprite = ScoreSO.ObjectList[randomIndex].image;
        rb.mass   = ScoreSO.ObjectList[randomIndex].mass;
        rb.drag   = ScoreSO.ObjectList[randomIndex].drag;

        if(ScoreSO.ObjectList[randomIndex].hasRandomColor == true)
        {
            sr.color = Random_color;
        }
    }

    private void OnDestroy()
    {
        print(hud.score);
        hud.score += score;

        ScoreSO.quantity--;
    }
}
