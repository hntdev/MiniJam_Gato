using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pata_Controler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private Transform OriginReference;

    Vector2 direction;
    Vector2 target;

    [SerializeField] float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = target - (Vector2)transform.position;

        if (direction.magnitude > 0.5f)
        {
            rb.AddForce(direction.normalized * force);
        }


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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.freezeRotation = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rb.freezeRotation = false;
    }
}
