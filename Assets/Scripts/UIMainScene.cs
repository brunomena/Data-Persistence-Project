using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{
    public GameObject fooText;
    Text footext;

    // Start is called before the first frame update
    void Start()
    {
        footext = fooText.GetComponent<Text>();
        footext.text = MenuManager.Instance.BestScoreText + MenuManager.Instance.playerNameBestScore + " : " + MenuManager.Instance.BestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
