using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public BoxGloves boxGloves;
    public Animator Anim;
    Collider capsul;
    bool girdimi;

    private void Start()
    {
        capsul = this.gameObject.GetComponent<CapsuleCollider>();
    }


    void Update()
    {



    }
   /* public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Anim.SetBool("damageButtonOn", true);
            

        }
        else{

            Anim.SetBool("damageButtonOn", false);
        }
       


    }*/
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Anim.SetBool("damageButtonOn", true);
            boxGloves.BoxGloveAnimation();

        }
        



    }


}
