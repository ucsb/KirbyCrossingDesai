using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            transform.SetPositionAndRotation(new Vector3(0, 0.94f, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
