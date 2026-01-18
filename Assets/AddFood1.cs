using UnityEngine;

public class AddFood1 : MonoBehaviour
{
    public GameObject spawn;
    public float minx = -5f;
    public float maxx = 5f;
    public float minz = -5f;
    public float maxz = 5f;
    public float ySpawn = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randX = Random.Range(minx, maxx);
        float randZ = Random.Range(minz, maxz);

        Vector3 SpawnPos = new Vector3(randX, ySpawn, randZ);
        Instantiate(spawn, SpawnPos, Quaternion.identity);
    }
}
