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
            Object tempScript = other.GetComponent<Object>();

            GameObject temp = Instantiate(tempScript.ScoreSO.ObjectList[tempScript.randomIndex].scoreObject, new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0), Quaternion.identity);
            temp.GetComponent<SpriteRenderer>().sprite = tempScript.ScoreSO.ObjectList[tempScript.randomIndex].scoreImage;

            Destroy(other.gameObject);
        }
    }
}
