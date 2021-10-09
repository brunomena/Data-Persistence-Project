using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject fooText;
    Text footext;

    // Start is called before the first frame update
    void Start()
    {
        footext = fooText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewText()
    {
        // add code here to handle when a color is selected
        MenuManager.Instance.playerName = footext.text;
        Debug.Log(footext.text);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        MenuManager.Instance.SaveScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
