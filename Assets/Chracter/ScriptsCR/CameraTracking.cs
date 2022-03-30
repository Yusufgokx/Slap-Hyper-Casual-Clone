using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject objectTracking;
    Vector3 theDifference;
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
    private bool isTarget=true;

    public void FinishAnimation(Vector3 finishTargetPosition,float animationDuration)
    {
        isTarget = false;
        transform.DOMove(finishTargetPosition, animationDuration);
    }
}
