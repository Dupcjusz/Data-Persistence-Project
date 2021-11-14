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
    public InputField iField;
    public static string playerName;
    

    public void StartNew(){
        SceneManager.LoadScene(1);

        SetTheText();
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
        playerName = iField.text; 
    }

    public static void menuRestart(){
        SceneManager.LoadScene(1);
    }
}
