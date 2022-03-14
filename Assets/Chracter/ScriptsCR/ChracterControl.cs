using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterControl : MonoBehaviour
{
    [SerializeField]float hareketHizi;
    [SerializeField]float hiz;
    float hor;
    Rigidbody rb;
    public Animator animKing;

  
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    
    void LateUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor*hiz*Time.deltaTime,0,hareketHizi*Time.deltaTime));


    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", true);


        }



    }

    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", false);


        }



    }
}
