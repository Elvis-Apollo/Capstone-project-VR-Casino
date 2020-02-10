using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lever_Trigger : MonoBehaviour
{
    //this list is hardcoded in this prototype but will eventually get populated in the admin portal
    List<OutcomeType> outcomesList = new List<OutcomeType> {
        OutcomeType.L, OutcomeType.NM, OutcomeType.W
    };
    //is it time to spin the reels?
    public bool spinReels = false;

    //boolean to check if the reels are currently spinning
    bool isInPlay = false;

    // enum for outcome types
    enum OutcomeType
    {
        W, // win
        L, // loss
        NM // near misss
    }

    // called when mouse is clicked on the lever object
    private IEnumerator ActivateLever()
    {
        Debug.Log("Lever has been activated.");
        int tries = outcomesList.Count; // number of tries a user gets == size of outcome list

        //condition to check if tries available and reels not in play
        if (tries > 0 && isInPlay == false)
        {
            Debug.Log("Try number: " + tries);
            OutcomeType outcome = outcomesList[(Random.Range(0, tries))];
            Debug.Log("Current Outcome: " + outcome.ToString()); // this is the predefined outcome for this play
            outcomesList.Remove(outcome); // remove current outcome from list, also reduces one try

            isInPlay = true; //bool to check if a play is going on(reels spinning)
            spinReels = true; // start spinning the reels

            //start spinning all reels
            GameObject.Find("ReelA").GetComponent<Reel_Primary_Spin>().StartRand();
            GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().StartRand();

            // Start function WaitForTime as a coroutine. And wait until it is completed.
            yield return StartCoroutine(WaitForTime(1.0f));

            //disable ReelA(primary reels) reel spin
            GameObject.Find("ReelA").GetComponent<Reel_Primary_Spin>().EndRand();

            yield return StartCoroutine(WaitForTime(1.0f));

            // this swtich cover the case for all secondary reels(ReelB, ReelC, ReelD)
            switch (outcome)
            {
                case OutcomeType.L:
                    //disable ReelB reel spin
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().setLossImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().setLossImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().setLossImage();
                    break;

                case OutcomeType.NM:
                    //disable ReelB reel spin
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().setNearMissImage();
                    break;

                case OutcomeType.W:
                    //disable ReelB reel spin
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelB").GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelC").GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find("ReelD").GetComponent<Reel_Secondary_Spin>().setWinImage();
                    break;
            }

            //reset spinReels bool to false.
            spinReels = false;
            isInPlay = false;
        }
        else if (tries == 0) //out of tries
        {
            Debug.Log("Out of tries!!");
        }
        else if (isInPlay)
        {
            Debug.Log("Currently playing reels");
        }
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // suspend execution for waitTime seconds
    IEnumerator WaitForTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Debug.Log("Wait: " + Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        bool attached = this.GetComponent<Valve.VR.InteractionSystem.Throwable>().isAttachedToHand();
        if (attached)
        {
            Debug.Log("VR hand has been attached to the lever");
            StartCoroutine(ActivateLever());
        }
    }
}
