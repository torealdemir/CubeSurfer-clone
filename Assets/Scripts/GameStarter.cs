using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStarter : MonoBehaviour
{

    public GameObject StartButton; 
    public PlayerMovement PlayerActiveness;


    private void Start()
    {
        PlayerActiveness = GetComponent<PlayerMovement>();
    }


    public void StartTheGame()
    {
        PlayerActiveness.enabled = true;
        StartButton.SetActive(false);
        //GameManager.instance.canvasController.ShowWinScreen();
    }
}
