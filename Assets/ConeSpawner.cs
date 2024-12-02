using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ConeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int spawnNumber = 100;
    public float radius = 50;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnNumber; i++)
        {
            GameObject spawnedObject = Instantiate(prefab);
            spawnedObject.transform.position = Random.insideUnitSphere * radius;
        }
    }
}
