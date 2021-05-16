using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaiTomarNoCU : MonoBehaviour
{
    [SerializeField] private SpriteRenderer alessandro;
    private void Start()
    {
        alessandro.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
    private void Update()
    {
        alessandro.size += new Vector2(Time.deltaTime * 2, 0);
    }
}
