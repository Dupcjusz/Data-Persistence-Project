using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public static int Best;

    public static string BestPlayerName;
    
    private void Awake(){
        Best = EndManager.Best;
        BestPlayerName = MenuUIhandler.playerName;
    }

    void update(){

    }
    [System.Serializable]
    class SaveData{
        public int score;
        public string playerName;
    }

    public void SaveScore(){
        SaveData data = new SaveData();
        data.score = Best;
        data.playerName = BestPlayerName;
        
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
            BestPlayerName = data.playerName;
        }
    }
}

