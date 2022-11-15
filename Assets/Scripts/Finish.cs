using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Finish : MonoBehaviour
{
    public static Finish instance;

    [SerializeField] Transform Player;

    [SerializeField] Transform EndPoint;


    public Canvas nextLevelButton;

    [SerializeField] ParticleSystem _ParticleSystem;

    public bool ReachFinish = false;
    


    private void Start()
    {
        //nextLevelButton = GameObject.FindGameObjectWithTag("ButtonNext");
        //nextLevelButton = GameObject.FindObjectOfType<Canvas>().transform.GetChild(0).GetChild(1).gameObject;

        nextLevelButton = GameObject.FindGameObjectWithTag("canvass").GetComponent<Canvas>();

    }

    private void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stacked"))
        {
            Debug.Log("finish");
            PlayerMovement.instance.cubes.Remove(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.transform.parent = null;
            _ParticleSystem.Play();
            Taptic.Medium();
            ReachFinish = true;
            if (Player.transform.position.z >= EndPoint.transform.position.z && ReachFinish == true || PlayerMovement.instance.cubes.Count == 0)
            {
                
                PlayerMovement.instance.Dance();
            }


        }

        if(PlayerMovement.instance.cubes.Count == 0 && Player.transform.position.z >= EndPoint.transform.position.z || PlayerMovement.instance.cubes.Count == 0)
        {
            nextLevelButton.enabled = true;
        }

    }


    
}
