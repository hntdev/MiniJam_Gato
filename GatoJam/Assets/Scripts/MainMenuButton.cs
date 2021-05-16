using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    Hud_Manager hud;
    [SerializeField] string SceneName;
    [SerializeField] private bool isExit;
    [SerializeField] private MainMenuButton other;

    private void Start()
    {
        hud = FindObjectOfType<Hud_Manager>();
    }
    private void OnDestroy()
    {
        if (isExit)
        {
            Application.Quit();
        }
        else
        {
            hud.loadScene(SceneName);
            other.isExit = false;
        }
    }
}
