using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public float hor;
    //public float hiz;
    // public float minX, maxX;
    // public GameObject enemyPrefab;
    //  public int ileriUzaklık;
    void Start()
    {
        // StartCoroutine(DusmanSaniye());

    }

    void Update()
    {

    }
    /*void dusmanOlusturucu()
     {

         var xposition = Random.Range(minX, maxX);
         Instantiate(enemyPrefab, new Vector3 (xposition,0,GameManager.Instance.chracterControl.transform.position.z*ileriUzaklık),Quaternion.identity);
     }
     public IEnumerator DusmanSaniye()   
     {
         while (true)
         {
             yield return new WaitForSeconds(3f);
             dusmanOlusturucu();
         }
     }*/
}
