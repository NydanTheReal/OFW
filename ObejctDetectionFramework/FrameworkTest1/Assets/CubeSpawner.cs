using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    public GameObject prefab;
    static Random r = new Random();
    public float InstantiationTimer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            SpawnAndDestroy(prefab, 2);
            //Instantiate(prefab, new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(0, 3f), -5.36f), Quaternion.identity, this.gameObject.transform);
            InstantiationTimer = 2f;
        }
    }

    void SpawnAndDestroy(GameObject prefab, float delay)
    {
        GameObject newGO = Instantiate(prefab, new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(0, 3f), -5.36f), Quaternion.identity, this.gameObject.transform) as GameObject;
        Destroy(newGO, delay);
    }
}
