using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud_Manager : MonoBehaviour
{
    public int score;
    public void loadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
