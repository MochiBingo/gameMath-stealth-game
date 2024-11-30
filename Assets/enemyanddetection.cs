using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyanddetection : MonoBehaviour
{
    public float cutoff = 45f;

    public bool testCone (Vector3 inputPoint)
    {
        float cosAngle = Vector3.Dot((inputPoint - this.transform.forward).normalized, this.transform.forward);
        float angle = Mathf.Acos(cosAngle) * Mathf.Rad2Deg;
        return angle < cutoff;
    }
}
