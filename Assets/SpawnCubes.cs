using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
	public Transform prefab;
   

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 5; i++)
        {
            Instantiate(prefab, new Vector3(2.0F, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
