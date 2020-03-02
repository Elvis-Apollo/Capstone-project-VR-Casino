using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using Valve.VR.InteractionSystem;

public class Lever_Trigger : MonoBehaviour
{

    //is it time to spin the reels?
    public bool spinReels = false;

    //boolean to check if the reels are currently spinning
    bool isInPlay = false;

    // VR function
    //private void OnHeld()
    //{
    //    GameObject.Find("Lever").GetComponent<Throwable>().isAttachedToHand();
    //    Debug.Log("held works");
    //}

    const string ReelA = "ReelA";
    const string ReelB = "ReelB";
    const string ReelC = "ReelC";
    const string ReelD = "ReelD";
    const string ReelA1 = "ReelA1";
    const string ReelB1 = "ReelB1";
    const string ReelC1 = "ReelC1";
    const string ReelD1 = "ReelD1";

    // called when mouse is clicked on the lever object
    private IEnumerator ActivateLever()
    {
        List<OutcomeType> outcomesList = GameObject.Find("OutcomeObj").GetComponent<OutcomeObj>().outcomesList;
        Debug.Log("Current Outcome list size when lever activated: " + outcomesList.Count.ToString());
        int tries = outcomesList.Count;

        //condition to check if tries available and reels not in play
        if (tries > 0 && isInPlay == false)
        {
            Debug.Log("Try number: " + tries);
            OutcomeType outcome = outcomesList[(Random.Range(0, tries))];
            Debug.Log("Current Outcome: " + outcome.ToString());
            outcomesList.Remove(outcome); // remove current outcome from list, also reduces one try


            isInPlay = true;
            spinReels = true; // start spinning the reels

            //start spinning all reels
            GameObject.Find(ReelA).GetComponent<Reel_Primary_Spin>().StartRand();
            GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().StartRand();

            GameObject.Find(ReelA1).GetComponent<Reel_Primary_Spin>().StartRand();
            GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().StartRand();
            GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().StartRand();
            // Start function WaitForTime as a coroutine. And wait until it is completed.
            yield return StartCoroutine(WaitForTime(1.0f));


            //disable ReelA(primary reels) reel spin
            GameObject.Find(ReelA).GetComponent<Reel_Primary_Spin>().EndRand();
            GameObject.Find(ReelA1).GetComponent<Reel_Primary_Spin>().EndRand();

            yield return StartCoroutine(WaitForTime(1.0f));

            // this swtich cover the case for all secondary reels(ReelB, ReelC, ReelD)
            switch (outcome)
            {
                case OutcomeType.L:
                    //disable ReelB reel spin
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().setLossImage();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().setLossImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().setLossImage();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().setLossImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().setLossImage();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().setLossImage();
                    break;

                case OutcomeType.NM:
                    //disable ReelB reel spin
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().setWinImage();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().setWinImage();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().setNearMissImage();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().setNearMissImage();
                    break;

                case OutcomeType.W:
                    //disable ReelB reel spin
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB).GetComponent<Reel_Secondary_Spin>().setWinImage();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelB1).GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelC reel spin
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC).GetComponent<Reel_Secondary_Spin>().setWinImage();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelC1).GetComponent<Reel_Secondary_Spin>().setWinImage();

                    yield return StartCoroutine(WaitForTime(1.0f));

                    //disable ReelD reel spin
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD).GetComponent<Reel_Secondary_Spin>().setWinImage();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().EndRand();
                    GameObject.Find(ReelD1).GetComponent<Reel_Secondary_Spin>().setWinImage();
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
