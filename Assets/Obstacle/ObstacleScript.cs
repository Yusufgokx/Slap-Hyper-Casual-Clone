using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleScript : MonoBehaviour
{
   
  
    public float zaman;
    public float andPosX;
    private float startPosX;
    public float durationDelay;
    public float rotateDuration;


    
  
    void Start()
    {

       transform.DORotate(Vector3.forward*360, rotateDuration,RotateMode.FastBeyond360).SetLoops(-10);

        startPosX = transform.position.x;
        ObstacleMove();
        
    }

 
    void Update()
    {
       
      // transform.Rotate(Vector3.forward*(sawRotationSpeed*Time.deltaTime));
    }
    public void ObstacleMove()
    {
       
        //transform.DOMove(Hedef.position, zaman).OnComplete(() => geriGel());
        //transform.DOMove(new Vector3 (transform.position.x+5,transform.position.y,transform.position.z), zaman).OnComplete(() => transform.DOMove( new Vector3(transform.position.x-5,transform.position.y,transform.position.z) , 1).OnComplete(() => ObstacleMove())); //5birim sağa 5 birim sola haraket ettirir 1saniyede 
        transform.DOMoveX(andPosX, zaman / 2).SetDelay(durationDelay/2).OnComplete(() =>
           {
               transform.DOMoveX(startPosX, zaman / 2).SetDelay(durationDelay / 2).OnComplete(() =>
               {
                   ObstacleMove();
               });
               
           });
    }
  /*public void geriGel()
    {
        transform.DOMoveX(-7, 5);
    }*/
}

