using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGrid : MonoBehaviour
{
    public const float cellSize = 0.33f;
    public string myName;

    // public float cellRowSize; 
    // public float cellColSize;
    // Start is called before the first frame update
    void Start()
    {
        // Use this for initialization
        Debug.Log("Start Class : " + this.GetType().Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
