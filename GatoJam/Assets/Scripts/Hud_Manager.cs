using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud_Manager : MonoBehaviour
{
    public int score;
    [SerializeField] bool hudIngame;
    [SerializeField] Text scoretxt;

    private void Update()
    {
        if(hudIngame == true)
        {
            scoretxt.text = score.ToString();
        }
    }

    public void loadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void gameOver()
    {
        print("PERDEU PORRA");
    }



}
