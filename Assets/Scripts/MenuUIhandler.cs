using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

    [DefaultExecutionOrder(1000)]
public class MenuUIhandler : MonoBehaviour
{
    public InputField playerName;
    string Name;

    public void StartNew(){
        SceneManager.LoadScene(1);

        SetTheText();
    }

    void huj(){
        Debug.Log(Name);
    }

    // Update is called once per frame
    public void Exit(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void SetTheText(){
        Name = playerName.text; 
        huj();
    }
}
