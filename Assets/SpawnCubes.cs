using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
	public Transform prefab;

    public int cubeNumber;
   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubeNumber; i++)
        {

            Instantiate(prefab, new Vector3(Random.Range(-1.8f, 1.8f), 0.7f, Random.Range(-1.8f, 1.8f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
