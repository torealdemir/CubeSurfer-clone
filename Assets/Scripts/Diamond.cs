using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamond : MonoBehaviour
{
    public static Diamond instance;

    public GameObject Player;

    public Counter DiamondCount;

    public static int NumberOfDiamonds;

    //public int DiamondCount { get; private set; }
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        DiamondCount = FindObjectOfType<Counter>();
    }
    private void Update()
    {
        RollerObject();
    }

    private void RollerObject()
    {
        gameObject.transform.Rotate(0, 0.3f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        NumberOfDiamonds++;
        //DiamondCount.DiamondCounter++;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Player.GetComponent<PlayerMovement>().isCollected = true;
        

        StartCoroutine(SpeedUp());

    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(1f);
        PlayerMovement.instance.isCollected = false;
    }

}
