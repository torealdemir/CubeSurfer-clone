using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{

    
    public TextMeshProUGUI ScoreText;

    //public TextMeshProUGUI LevelIndicator;

    public Diamond DiamondScript;

    //public NextLevelScene nextlevelScene;

    




    private void Start()
    {

        //ScoreText = GetComponent<TextMeshProUGUI>();
        DiamondScript = FindObjectOfType<Diamond>();

        //nextlevelScene = FindObjectOfType<NextLevelScene>();
    }

    void Update()
    {
        ScoreText.GetComponent<TextMeshProUGUI>().text = Diamond.NumberOfDiamonds.ToString();
        //LevelIndicator.GetComponent<TextMeshProUGUI>().text = nextlevelScene.levelCounter.ToString();
    }

    
}
