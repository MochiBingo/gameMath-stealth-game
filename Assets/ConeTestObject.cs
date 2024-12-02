using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeTestObject : MonoBehaviour
{
    public enemyanddetection coneTester;
    void OnDrawGizmos()
    {
        if (coneTester == null)
        {
            coneTester = gameObject.AddComponent<enemyanddetection>();
            if (coneTester == null)
            {
                return;
            }
        }

        Gizmos.color = coneTester.testCone(this.transform.position) ?
            Color.green : Color.clear;
        Gizmos.DrawSphere(this.transform.position, 0.7f);
    }
}
