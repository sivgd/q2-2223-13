using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarMask : MonoBehaviour
{
    
    public void MoveMask(int currentVal, int maxVal)
    {
        float percentToMove = (float)currentVal / (float)maxVal;
        Debug.Log("HEALTHBAR moving to " + percentToMove);
        transform.localPosition = new Vector3(percentToMove - 1, 0, 0);
    }

}
