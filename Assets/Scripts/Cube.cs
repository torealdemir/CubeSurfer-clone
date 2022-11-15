using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    private Transform Player;
    public ParticleSystem _ParticleSystem;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NotStacked"))
        {
            
            other.transform.parent = Player;
            Vector3 lastParent = PlayerMovement.instance.cubes[PlayerMovement.instance.cubes.Count -1].transform.localPosition;
            other.transform.localPosition = lastParent - new Vector3(0, transform.localScale.x, 0);
            Player.position = new Vector3(Player.position.x, Player.position.y +1, Player.position.z);
            //Taptic.Light();


            //var LastCubee = PlayerMovement.instance.cubes[PlayerMovement.instance.cubes.Count - 1];
            //var Distancee = LastCubee.transform.position.y - 0.5f;
            //Player.transform.DOMoveY(Player.transform.position.y - Distancee, 1f);
            PlayerMovement.instance.cubes.Add(other.gameObject);
            other.tag = "Stacked";

            _ParticleSystem.Play();


           
        }
        
    }
}