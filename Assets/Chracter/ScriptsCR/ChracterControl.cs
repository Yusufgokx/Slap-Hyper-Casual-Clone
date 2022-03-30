﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChracterControl : MonoBehaviour
{
    //[SerializeField] float hareketHizi;
   // [SerializeField] float hiz;
    
    Rigidbody rb;
    public Animator animKing;
    public float Healt;
    public TextMeshProUGUI hasarText;
    public int guc;
    public float hiz;
    public Camera mainCamera;
    public Camera2 cameraTwo;
    public bool kossunMU;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        Healt = 100;
        hasarText.text =Healt.ToString();// "HASAR"+  = işaretninden sonra soldaki hasar kodunu yazarsak sayı 'HARARDEĞER'ŞEKLİNDE YAZAR ;
        kossunMU = true;

    }

    public void Update()
    {
       
        if (kossunMU == true)
        {
            animKing.SetBool("Run", true);
            float yatay = Input.GetAxis("Horizontal");
            rb.velocity = new Vector3(yatay * hiz, 0, 10);
        }
        else
        {
            animKing.SetBool("Run", false);
            float yatay = 0;
            rb.velocity = new Vector3(yatay * hiz, 0, 0);

        }

    }

  

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", true);
            HasarAl();


        }
        if (other.gameObject.CompareTag("ObstacleEnemy"))
        {

            Debug.Log("HasarAldı");
            HasarAl();
        }

    }


    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", false);
            //mainCamera.gameObject.SetActive(false);
           // cameraTwo.gameObject.SetActive(true);

        }


    }

    public void HasarAl()
    {
        Healt -= Random.Range(5, 15);
        hasarText.text =Healt.ToString();
    }

}
