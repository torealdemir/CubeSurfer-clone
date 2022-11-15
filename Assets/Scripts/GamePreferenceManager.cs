using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePreferenceManager : MonoBehaviour
{
    private const string scoreKey = "Score";
    //public NextLevelScene nextLevelScene;
    

    private void Start()
    {
        //nextLevelScene = FindObjectOfType<NextLevelScene>();
        GetVariables();
        
    }

    private void Update()
    {
        SetVariables();
    }

    void SetVariables()
    {
        //PlayerPrefs.SetInt("Level", NextLevelScene.levelCounter);
        PlayerPrefs.SetInt(scoreKey, Diamond.NumberOfDiamonds);
        PlayerPrefs.Save();

    }

    public void GetVariables()
    {
        //var level = PlayerPrefs.GetInt("Level", 0);
        var score = PlayerPrefs.GetInt(scoreKey, 0);
        Diamond.NumberOfDiamonds = score;
        //Debug.Log(level);
    }
}