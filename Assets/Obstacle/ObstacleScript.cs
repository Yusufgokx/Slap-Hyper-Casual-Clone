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


    public void ObstacleMove()
    {

        transform.DOMoveX(andPosX, zaman / 2).SetDelay(durationDelay/2).OnComplete(() =>
           {
               transform.DOMoveX(startPosX, zaman / 2).SetDelay(durationDelay / 2).OnComplete(() =>
               {
                   ObstacleMove();
               });
               
           });
    }
 
}

