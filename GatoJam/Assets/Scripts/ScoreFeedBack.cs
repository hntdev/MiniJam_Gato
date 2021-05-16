using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFeedBack : MonoBehaviour
{
    private void Start()
    {
        Invoke("autoDestroy",0.5f);
    }
    private void autoDestroy()
    {
        Destroy(this.gameObject);
    }
}
