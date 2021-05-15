using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    Rigidbody2D rb;
    public bool heavy = false;
    public int points = 0;
    Hud_Manager hud;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hud = FindObjectOfType<Hud_Manager>();   

        if (heavy)
        {
            rb.mass = 1000f;
            rb.drag = 10f;
        }
    }

    private void OnDestroy()
    {
        hud.score += points;
    }
}
