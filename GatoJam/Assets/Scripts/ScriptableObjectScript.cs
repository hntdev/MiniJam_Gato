using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectPropreties",menuName = "ObjectPropreties")]
public class ScriptableObjectScript : ScriptableObject
{
    public int points = 0;

    public float mass = 0;
    public float drag = 0;

    public Sprite image;

    public bool hasRandomColor = false;

    public GameObject scoreObject;
    public Sprite scoreImage;
}
