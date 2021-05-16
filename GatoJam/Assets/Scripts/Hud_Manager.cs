using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud_Manager : MonoBehaviour
{
    public int score;
    [SerializeField] bool hudIngame;
    [SerializeField] Text scoretxt, scoretxt2;

    [SerializeField] GameObject GameoverPanel;

    private void Start()
    {
        Time.timeScale = 1;
        if (hudIngame == true)
        {
            GameoverPanel.SetActive(false);
        }
    }
    private void Update()
    {
        if(hudIngame == true)
        {
            scoretxt.text = score.ToString();
            scoretxt2.text = "Score: " + score.ToString();
        }

        print(Time.timeScale);
    }

    public void loadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void gameOver()
    {
        GameoverPanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void restart()
    {
        Scene Atualscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(Atualscene.name);
    }



}
