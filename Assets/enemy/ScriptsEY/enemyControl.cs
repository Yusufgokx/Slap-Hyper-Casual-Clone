using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    public bool playerDegdi = false;
    public GameObject Hedef;
  
    public Animator anim;
    bool AttackOldu;
    void Start()
    {
        Hedef = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        
    }


    void Update()
    {      
       
        
           



    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            anim.SetBool("attack", true);
            

        }
        else
        {
            anim.SetBool("attack", false);
        }


    }
}
