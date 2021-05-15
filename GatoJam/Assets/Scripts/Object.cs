using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    Hud_Manager hud;
    SpawnManager ScoreSO;
    SpriteRenderer sr;
    Rigidbody2D rb;

    int randomIndex;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        ScoreSO = FindObjectOfType<SpawnManager>();

        randomIndex = Random.Range(0, ScoreSO.ObjectList.Count);

        sr.sprite = ScoreSO.ObjectList[randomIndex].image;
        rb.mass = ScoreSO.ObjectList[randomIndex].mass;
        rb.drag = ScoreSO.ObjectList[randomIndex].drag;
    }

    private void OnDestroy()
    {
        hud = FindObjectOfType<Hud_Manager>();
        hud.score += ScoreSO.ObjectList[randomIndex].points;
        ScoreSO.quantity--;
    }
}
