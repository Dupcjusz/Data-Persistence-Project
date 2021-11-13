using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class EndManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public static int Best;
    public string Name;
    public static string BestPlayerName;

    private void Awake(){
        
    }
    
    void Start(){
        score = MainManager.m_Points;
        Name = MenuUIhandler.playerName;

        scoreText.text = "Score: " + score;

        if(score > Best){
            Best = score;
            BestPlayerName = Name;
        }

        if(score == 96){
            SceneManager.LoadScene(3);
        }
    }

    public void restart(){

        SceneManager.LoadScene(1);
    }

    public void BackToMenu(){
        SceneManager.LoadScene(0);
    }

    
}
