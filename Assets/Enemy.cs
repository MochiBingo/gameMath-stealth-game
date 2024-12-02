using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static List<Enemy> all = new List<Enemy>();

    public void OnEnable()
    {
        all.Add(this);
    }

    public void OnDisable()
    {
        all.Remove(this);
    }

}
