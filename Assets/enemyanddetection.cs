using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyanddetection : MonoBehaviour
{
    public float angle;
    public Transform target;
    public bool IsInFOV(Transform target, float viewAngle)
    {
        Vector3 directionToTarget = (target.position - transform.position).normalized;

        float angle = Vector3.Dot(transform.forward, directionToTarget);

        float degrees = Mathf.Acos(angle) * Mathf.Rad2Deg;

        return degrees < viewAngle / 2;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.forward);
    }
}
