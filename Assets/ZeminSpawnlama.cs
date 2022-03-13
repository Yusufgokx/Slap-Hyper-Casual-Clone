using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawnlama : MonoBehaviour
{
    public Transform spawnPosition;
   
     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("Player"))
         {
             Instantiate(gameObject, spawnPosition.position, transform.rotation, null);
         }
     }
}
