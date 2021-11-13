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
        LoadScore();
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

    [System.Serializable]
    class SaveData{
        public int score;
        public string name;
    }

        public void SaveScore(){
            SaveData data = new SaveData();
            data.score = Best;
            data.name = BestPlayerName;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath +
            "/savefile.json", json);
        }

        public void LoadScore(){
            string path = Application.persistentDataPath +
            "/savefile.json";
                if (File.Exists(path)){
                    string json = File.ReadAllText(path);
                    SaveData data = JsonUtility.FromJson<SaveData>(json);

                    Best = data.score;
                    BestPlayerName = name;
                }
        }
}
