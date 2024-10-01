using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CubeTransformer CubeTarget;
    public float scale = 1f;
    public float negscale = -1f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Input for Space calls IncreaseCubeTargetSize
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseCubeTargetSize();
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            DecreaseCubeTargetSize();
        }
    }

    private void DecreaseCubeTargetSize()
    {
        Vector3 newScale = CubeTarget.transform.localScale + new Vector3(negscale, negscale, negscale);
        CubeTarget.transform.localScale = newScale;
    }

    private void IncreaseCubeTargetSize()
    {
        Vector3 newScale = CubeTarget.transform.localScale + new Vector3(scale, scale, scale); // Vector3 controls the xyz of the cube. 
        CubeTarget.transform.localScale = newScale;
    }
}
