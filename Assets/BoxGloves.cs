using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoxGloves : MonoBehaviour
{
    public float totalDuration;
    public float animationDelay;
    Rigidbody EnemyRb;
    ChracterControl script2;


    private void Start()
    {
     
        
    }

    private void Update()
    {
        
    }
    public void BoxGloveAnimation()
    {
        transform.DOMoveX(3, totalDuration/2).SetDelay(animationDelay).OnComplete(() =>
         {
             transform.DOMoveX(11.5f, totalDuration/2).OnComplete(() =>
             {
                //Move();
             });
         });
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<EnemyControl>().DestrucFirst();
           // GameManager.Instance.enemyControl.DestrucFirst();


        }
    }
}
