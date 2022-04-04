using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject objectTracking;
    Vector3 theDifference;
    private bool isTarget = true;

    void Start()
    {
        theDifference = this.transform.position - objectTracking.transform.position;
    }

    void Update()
    {
        if (isTarget==true)
        {
            transform.position = theDifference + objectTracking.transform.position;
        }
    }
  



    public void FinishAnimation(Vector3 finishTargetPosition,float animationDuration)
    {
        isTarget = false;
        transform.DOMove(finishTargetPosition, animationDuration);
    }
}
