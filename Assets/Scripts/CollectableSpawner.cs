using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectablePrefab; // The collectable prefab to spawn
    public int numberOfCollectables = 15;
    public float minRadius = 40f; // Minimum distance from the center
    public float maxRadius = 100f; // Maximum distance from the center
    public int Score;
    public int count;
    void Start()
    {
        SpawnCollectables();
        Score = 0;
    }

    private void Update()
    {
        
        if (count == 10)
        {
            count -= 10;
            numberOfCollectables = 10;
            SpawnCollectables();
            print("more have spawned");
        }
    }


    void SpawnCollectables()
    {
        for (int i = 0; i < numberOfCollectables; i++)
        {
            Vector3 randomPosition = GenerateRandomPosition();
            Instantiate(collectablePrefab, randomPosition, Quaternion.identity);
           
        }
    }

    Vector3 GenerateRandomPosition()
    {
        float distance = Random.Range(minRadius, maxRadius);
        float angle = Random.Range(0f, Mathf.PI * 2);
        float height = Random.Range(0, distance);

        // Convert polar coordinates to Cartesian coordinates
        float x = distance * Mathf.Cos(angle);
        float z = distance * Mathf.Sin(angle);
        float y = height - distance / 2;
        // Assuming y = 0 for ground-level placement
        return new Vector3(x, y, z);
    }
}
