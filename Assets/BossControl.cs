using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    Animator bossAnim;
    void Start()
    {
        bossAnim = GetComponent<Animator>();
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            bossAnim.SetBool("bossAttack", true);

        }
    }



}
