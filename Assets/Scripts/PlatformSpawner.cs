using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    private int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 1;
        if (time % 5000 == 0) {
            Instantiate(
                    platformPrefab,
                    Vector3.zero,
                    Quaternion.identity,
                    gameObject.transform
                    );
        }
    }
}
