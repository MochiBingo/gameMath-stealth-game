using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyanddetection : MonoBehaviour
{
    public float cutoff = 45f;

    public bool testCone (Vector3 inputPoint)
    {
        foreach (var enemy in Enemy.all)
        {
            float cosAngle = Vector3.Dot((inputPoint - enemy.transform.forward).normalized, enemy.transform.forward);
            float angle = Mathf.Acos(cosAngle) * Mathf.Rad2Deg;
            if (angle < cutoff)
                return true;
        }

        return false;
    }
}
