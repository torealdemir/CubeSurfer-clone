using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevelScene : MonoBehaviour
{
    public Canvas canvas;
    public static int levelCounter;
    public int sceneIndex = 0;


    private void Awake()
    {
        DontDestroyOnLoad(canvas.gameObject);
    }

    private void Start()
    {
        levelCounter = 1;
    }

    private void Update()
    {
        IndexCounter();
    }

    private void IndexCounter()
    {
        if(sceneIndex >= 4)
        {
            
            sceneIndex = 1;
        }
    }

    public void Nextt()
    {
        levelCounter++;
        sceneIndex++;
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        canvas.enabled = false;

    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

}
