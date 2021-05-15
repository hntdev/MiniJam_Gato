using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> HeavyGOList = new List<GameObject>();
    public List<GameObject> LightGOList = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            spawn();
        }
    }

    public void spawn()
    {
        float randomX = Random.Range(-5f,5f);
        float randomY = Random.Range(-3.5f,3.5f);
        print("AAAA");
        GameObject temp = Instantiate(HeavyGOList[0], new Vector3(randomX, randomY, 0), Quaternion.identity);
    }
}
