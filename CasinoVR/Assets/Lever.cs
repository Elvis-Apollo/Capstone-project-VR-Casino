using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    ReelA reela;
    ReelA reelb;

    void OnMouseDown()
    {
        
        Debug.Log("Mouse left click pressed.");
        reela = GameObject.Find("ReelA").GetComponent<ReelA>();

        reela.TestReel();
        reelb = GameObject.Find("ReelB").GetComponent<ReelA>();
        reelb.TestReel();



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
