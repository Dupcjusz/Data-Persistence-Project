using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class Congrats : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int score;
    public static string playerName;
    void Start()
    {
        score = MainManager.m_Points;
        playerName = MainManager.Name;
        text.text = "Congratulation " + playerName + ", You win the game!!!";
    }

    public void BackToMenu(){
        SceneManager.LoadScene(0);
    }
}
