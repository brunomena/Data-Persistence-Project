using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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

        if (BestScore == "")
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

}
