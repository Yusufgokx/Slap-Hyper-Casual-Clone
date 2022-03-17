using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleScript : MonoBehaviour
{
   
  
    public float zaman;
  
  
    void Start()
    {
        ObstacleMove();
        
    }

 
    void Update()
    {

       transform.Rotate(Vector3.forward);
    }
    public void ObstacleMove()
    {
        //transform.DOMove(Hedef.position, zaman).OnComplete(() => geriGel());
        transform.DOMove(new Vector3 (transform.position.x+5,transform.position.y,transform.position.z), zaman).OnComplete(() => transform.DOMove( new Vector3(transform.position.x-5,transform.position.y,transform.position.z) , 1).OnComplete(() => ObstacleMove())); //
    }
  /*public void geriGel()
    {
        transform.DOMoveX(-7, 5);
    }*/
}

