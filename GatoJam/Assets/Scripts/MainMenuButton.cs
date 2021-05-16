using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    Hud_Manager hud;
    [SerializeField] string SceneName;
    private void Start()
    {
        hud = FindObjectOfType<Hud_Manager>();
    }
    private void OnDestroy()
    {
        hud.loadScene(SceneName);
    }
}
