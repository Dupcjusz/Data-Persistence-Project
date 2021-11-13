using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public static int Best;

    public static string BestPlayerName;
    
    private void Awake(){
        LoadScore();
    }

    void Start(){
        Best = EndManager.Best;
        BestPlayerName = EndManager.BestPlayerName;
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

        Debug.Log(Best + BestPlayerName);
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
