using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName; // new variable declared

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        //playerName = 

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
