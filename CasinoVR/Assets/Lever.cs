using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    Reel reela;
    Reel reelb;
    Reel reelc;
    Reel reeld;

    private IEnumerator coroutine;

    IEnumerator OnMouseDown()
    {

        
            // - After 0 seconds, prints "Starting 0.0"
            // - After 2 seconds, prints "WaitAndPrint 2.0"
            // - After 2 seconds, prints "Done 2.0"
            print("Starting " + Time.time);

            // Start function WaitAndPrint as a coroutine. And wait until it is completed.
            // the same as yield return WaitAndPrint(2.0f);
            yield return StartCoroutine(WaitAndPrint(2.0f));
            print("Done " + Time.time);
    
        Debug.Log("Mouse left click pressed.");

        //changes reel values to 8
        GameObject.Find("ReelA").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelB").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelC").GetComponent<Reel>().TestReel();

        GameObject.Find("ReelD").GetComponent<Reel>().TestReel();



    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // suspend execution for waitTime seconds
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
}
