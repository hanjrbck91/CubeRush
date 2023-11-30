using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnInterval = .5f;

    void Start()
    {
        InvokeRepeating("SpawnCube", 0f, spawnInterval);
    }

    void SpawnCube()
    {
        float randomX = Random.Range(-18.27f, -4.91f); // Adjust the range based on your scene

        Vector3 spawnPosition = new Vector3(randomX, -9.3f, 373.3f);

        GameObject newCube =  Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        // Make the instantiated cube a child of the cubeSpawner
        newCube.transform.parent = transform;

        Destroy(newCube,5);
    }
}
//420.8
//    -50
