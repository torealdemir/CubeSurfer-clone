using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Obstacle1 : MonoBehaviour
{
    

    public UnityEngine.UI.Button retryButton;
        
    

    public Transform Player;
    public Counter Hitcounterr;


    private bool hasTouched = false;


    private float Distance;

    private void Start()
    {
        Hitcounterr = Player.GetComponent<Counter>();

        //_Ps = gameObject.GetComponent<ParticleSystem>();
        
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stacked"))
        {

            Hitcounterr.Counterr++;
         
            

        }



        if (!hasTouched)
        {

            StartCoroutine(GoDown());
            gameObject.GetComponent<BoxCollider>().enabled = false;
            other.transform.parent = null;
            PlayerMovement.instance.cubes.Remove(other.gameObject);
            Taptic.Light();

            if (PlayerMovement.instance.cubes.Count >= 1)
            {
                var LastCube = PlayerMovement.instance.cubes[PlayerMovement.instance.cubes.Count - 1];
                var Distance = LastCube.transform.position.y - 0.5f;
                Player.transform.DOMoveY(Player.transform.position.y - Distance, 0.5f);
            }

            

           
            

            

            //Player.transform.DOMoveY(Player.transform.position.y - Hitcounterr.Counterr, 0.5f);
            //if (DOTween.IsTweening("Obstacle1"))
            //{
            //    DOTween.Kill("Obstacle!");
            //}
            //Player.transform.position = Vector3.Lerp(Player.transform.position.y, Player.transform.position.y - Hitcounterr.Counterr);

            other.gameObject.tag = "crush";
            

        }
        
        if(PlayerMovement.instance.cubes.Count == 0)
        {
            PlayerMovement.instance.Fall();
            retryButton.gameObject.SetActive(true);

        }
       

    }


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("exitt");
    }

    private IEnumerator GoDown()
    {
        

        hasTouched = true;
        yield return new WaitForSeconds(.5f);
        hasTouched = false;
        Hitcounterr.Counterr = 0;

    }
    


    


}
