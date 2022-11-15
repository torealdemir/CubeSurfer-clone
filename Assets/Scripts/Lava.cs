using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lava : MonoBehaviour
{
    ParticleSystem _PS;

    [SerializeField] private Transform _Player;
    private int counter;
    private bool hotLava = false;
    [SerializeField] private UnityEngine.UI.Button retryButton;


    private void Start()
    {
        _PS = gameObject.GetComponent<ParticleSystem>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (!hotLava)
        {
            if (other.gameObject.CompareTag("Stacked"))
            {
                StartCoroutine(HotLavaChecker());
                IEnumerator HotLavaChecker()
                {
                    hotLava = true;
                    yield return new WaitForSeconds(0.01f);
                    hotLava = false;

                }
                counter++;
                other.gameObject.SetActive(false);
                PlayerMovement.instance.cubes.Remove(other.gameObject);
                _Player.transform.DOMoveY(_Player.transform.position.y - counter, 0.3f);
                _PS.Play();
                counter = 0;
                
            }
        }

        if(PlayerMovement.instance.cubes.Count == 0)
        {
            retryButton.gameObject.SetActive(true);
            PlayerMovement.instance.Fall();
        }
       
    }

    
}
