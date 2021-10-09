using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;
    public string BestScore;
    public string BestScoreText;
    public string playerNameBestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();

        if (BestScore == null)
        {
            BestScore = "0";
        }

        BestScoreText = "Best Score: ";

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    class SaveData
    {
        public string BestScore;
        public string playerNameBestScore;
    }
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.BestScore = BestScore;
            data.playerNameBestScore = playerNameBestScore;

        string json = JsonUtility.ToJson(data);
  
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerNameBestScore = data.playerNameBestScore;
            BestScore = data.BestScore;
        }
    }
}
