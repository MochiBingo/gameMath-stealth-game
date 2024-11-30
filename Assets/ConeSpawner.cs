using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConeSpawner : MonoBehaviour
{
    public int spawnNumber = 100;
    public float radius = 50;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnNumber; i++)
        {
            GameObject spawnedObject = new GameObject();
            spawnedObject.transform.position = Random.insideUnitSphere * radius;
            spawnedObject.AddComponent<ConeTestObject>();
        }
    }
}
