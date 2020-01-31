using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel : MonoBehaviour 
{
    
    public void TestReel()
    {
        GetComponent<TextMesh>().text = "8";
        Debug.Log("Reel change from lever works!");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
