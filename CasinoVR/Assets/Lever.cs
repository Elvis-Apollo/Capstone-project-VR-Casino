using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    Reel reela;
    Reel reelb;
    Reel reelc;
    Reel reeld;

    void OnMouseDown()
    {
        
        Debug.Log("Mouse left click pressed.");

        //changes reel values to 8
        GameObject.Find("ReelA").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelB").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelC").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelD").GetComponent<Reel>().TestReel();



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
