using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField]Hud_Manager hud;
    private void Start()
    {
        hud = FindObjectOfType<Hud_Manager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Object")
        {
            Destroy(other.gameObject);
        }
    }
}
