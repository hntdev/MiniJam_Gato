using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<ScriptableObjectScript> ObjectList = new List<ScriptableObjectScript>();
    public GameObject BaseObject;
    public Collider2D collider;
    public Hud_Manager hud;
    public int quantity;

    int counter;
    [SerializeField] float timer;


    private void Start()
    {
        hud = FindObjectOfType<Hud_Manager>();
        collider = GetComponent<Collider2D>();

        StartCoroutine(spawner());
    }
    private void Update()
    {
        if(quantity == 15)
        {
            hud.gameOver();
        }
    }

    public void spawn()
    {
        float randomX = Random.Range(collider.bounds.min.x,collider.bounds.max.x);
        float randomY = Random.Range(collider.bounds.min.y, collider.bounds.max.y);
        GameObject temp = Instantiate(BaseObject, new Vector3(randomX, randomY, 0), Quaternion.identity);
        quantity++;
    }

    IEnumerator spawner()
    {
        spawn();

        yield return new WaitForSeconds(timer);

        if(counter >= 3)
        {
            timer -= 0.005f;
            counter = 0;
        }

        counter++;
        
        StartCoroutine(spawner());
    }
}
