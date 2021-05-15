using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pata_Controler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private Transform OriginReference;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        rb.MoveRotation(RotZ() + 90);
    }

    private float RotZ()
    {
        float rotZ = Mathf.Atan2(DirToOrigin().y, DirToOrigin().x) * Mathf.Rad2Deg;
        return rotZ;
    }
    private Vector2 DirToOrigin()
    {
        Vector2 dir = OriginReference.position - this.transform.position;
        dir.Normalize();
        return dir;
    }
}
