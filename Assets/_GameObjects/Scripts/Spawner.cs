using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform vuforiaTarget;
    public Transform tLimit0;
    public Transform tLimit1;
    public GameObject prefab;
    public float spawnRate;
    private void Spawn()
    {
        float x = Random.Range(tLimit0.position.x, tLimit1.position.x);
        float y = tLimit0.position.y;
        float z = tLimit0.position.z;
        GameObject newAsteroid = Instantiate(prefab, vuforiaTarget);
        newAsteroid.transform.position = new Vector3(x, y, z);
    }
    public void StartSpawn()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }
    public void StopSpawn()
    {
        CancelInvoke();
    }
}
