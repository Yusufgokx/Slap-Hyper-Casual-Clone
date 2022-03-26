using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public GameObject objectTracking;
    Vector3 theDifference;
    void Start()
    {
        theDifference = this.transform.position - objectTracking.transform.position;
    }


    void Update()
    {
        this.transform.position = theDifference + objectTracking.transform.position;
    }
}

