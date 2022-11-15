using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    


    private void Awake()
    {
        MakeSingleton();
    }

    


    private void MakeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);

        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    public void DeactivateMovement()
    {
        
    }

    





}
