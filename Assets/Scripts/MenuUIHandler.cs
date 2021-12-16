using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public string playerName;
    public InputField inputField;

    void Start()
    {
        inputField = GameObject.Find("NameEntry").GetComponent<InputField>();
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;
        SceneManager.LoadScene(1);

        Debug.Log("player name is " + playerName);
        MainManager.playerNameString = playerName;
    }

    public void Exit()
    {
    #if UNITY_EDITOR
                    EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); 
    #endif
    }
}
