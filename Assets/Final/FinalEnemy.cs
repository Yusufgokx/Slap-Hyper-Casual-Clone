using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
public class FinalEnemy : MonoBehaviour
{   
    
    public GameObject Boss;
    public Transform cameraTransform;
  
    void Start()
    {

       
    }
    

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.CameraTracking.FinishAnimation(cameraTransform.position,3f);
            GameManager.Instance.chracterControl.kossunMU = false;
            
           
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            
            other.gameObject.GetComponent<NavMeshAgent>().speed = 10;
            other.gameObject.GetComponent<EnemyControl>().player = Boss.transform;
           
        }
      


    }

}
