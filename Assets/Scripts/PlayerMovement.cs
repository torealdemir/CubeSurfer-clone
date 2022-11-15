using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    
    public static PlayerMovement instance;


    public Finish FinishScript;


    Image SpeedEffect;


    private float HighSpeed = 1;
    private TrailRenderer tr;
    public bool isCollected = false;

    [HideInInspector] public bool win = false;

    

    [HideInInspector] public bool finishTouch;

    public List<GameObject> cubes = new List<GameObject>();
    private Vector3 firstTouchPosition;
    private Vector3 curTouchPosition;
    [SerializeField] private float speed;
    private float sensitivityMultiplier = 0.02f;
    private float finalTouchX;
    private float xBound = 4.7f;

    public Animator Anim;


    private void Awake()
    {
        //Anim = gameObject.GetComponent<Animator>();
        instance = this;
    }

    private void Start()
    {
        SpeedEffect = GameObject.FindGameObjectWithTag("SpeedUp").GetComponent<Image>();
        Input.multiTouchEnabled = false;
        

        FinishScript = FindObjectOfType<Finish>();
        //DiamondScript = gameObject.GetComponent<Diamond>();

    }

    private void Update()
    {

        Move();
        

    }

    private void Move()
    {
        transform.Translate(Vector3.forward * speed * HighSpeed* Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            curTouchPosition = Input.mousePosition;

            Vector2 touchDelta = (curTouchPosition - firstTouchPosition);

            finalTouchX = (transform.position.x + (touchDelta.x * sensitivityMultiplier));
            finalTouchX = Mathf.Clamp(finalTouchX, -xBound, xBound);

            transform.position = new Vector3(finalTouchX, transform.position.y, transform.position.z);

            firstTouchPosition = Input.mousePosition;
        }


        if (cubes.Count == 0)
        {

            speed = 0;
            
        }

        if(isCollected == true)
        {
         
            StartCoroutine(SlowSpeed());

        }

    }

    IEnumerator SlowSpeed()
    {
        SpeedEffect.enabled = true;
        HighSpeed = 2.6f;
        yield return new WaitForSeconds(1.8f);
        HighSpeed = 1;
        SpeedEffect.enabled = false;
    }






    public void Dance()
    {
        Anim.SetBool("Dance", true);
    }

    public void Fall()
    {
        Anim.SetBool("Fall", true);
    }




}