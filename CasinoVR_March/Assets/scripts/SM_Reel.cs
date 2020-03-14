using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020
 * 
 * This script is responsible for rotating each reel and showing outcome based off SlotMachine_Manager 
 */
public class SM_Reel : MonoBehaviour
{
    // hides this public variable in the inspector
    [HideInInspector]
    public bool ReelSpinning;

    
    // outcome angles[] indices represent the icons below:
    //0 = crown, 1 = waterMelon, 2 = bar, 
    //3= seven, 4 = cherry, 5 = lemon, 6 = diamond 
    private List<float> outcome_Angles = new List<float> { 345, 295, 240, 190, 140, 85, 35 };

    private OutcomeType current_outcome; // current outcome for this turn(W,L,NM)
    public float ReelsSpinSpeed;    // set reelspin in start()
    
    // Use this for initialization
    void Start()
    {
        ReelsSpinSpeed = 4.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (ReelSpinning)
        {

            this.transform.Rotate(ReelsSpinSpeed, 0.0f, 0.0f, Space.Self); // rotation speed of a reel
        }     
    }

    public void Start_Script_Then_End(float stopTime, OutcomeType outcome)
    {
        ReelSpinning = true;
        enabled = true;
        current_outcome = outcome;
        StopRand(stopTime);        
    }

    public void EndScript()
    {
        SlotMachine_Manager sm_manager = this.GetComponentInParent<SlotMachine_Manager>();
        {
            int random_angle_index = Random.Range(0, outcome_Angles.Count); // get a number between 0 to outcome_Angles.Count
            switch (current_outcome)
            {
                case OutcomeType.W:
                    // if ReelA's result is -1, then we know this is first reel spin, so set the result
                    // if this is Reelb,c,d then we use ReelAResult to show for remaining reels as well
                    if (sm_manager.ReelAResult < 0)
                    {
                        sm_manager.ReelAResult = random_angle_index;
                    }
                    break;
                case OutcomeType.NM:
                    // if ReelA's result is -1, then we know this is first reel spin, so set the result
                    // ReelB, and ReelC also show Reel A result
                    if (sm_manager.ReelAResult < 0)
                    {
                        sm_manager.ReelAResult = random_angle_index;
                    }
                    // if reelD spinning, then
                    // reel D result must be any icon but the ReelA icon. e.g cherry, cherry, cherry, lemon
                    else if (sm_manager.numOfReelsPlayed % 4 == 0)
                    {
                        random_angle_index = sm_manager.ReelAResult; // set temp value of reelA result
                        while (random_angle_index == sm_manager.ReelAResult) //reassign any number except reelA result
                        {
                            random_angle_index = Random.Range(0, outcome_Angles.Count);
                        }
                        sm_manager.ReelAResult = random_angle_index; //now reassign reelA result to temp val(so that reedD is not the same as reel a,b,c)
                    }
                    break;
                case OutcomeType.L:
                    // if ReelA's result is -1, then we know this is first reel spin, so set the result                    
                    if (sm_manager.ReelAResult < 0)
                    {
                        sm_manager.ReelAResult = random_angle_index;
                    } // ReelB, ReelC, Reel D should now show ReelA result
                    else
                    {
                        random_angle_index = sm_manager.ReelAResult;
                        while (random_angle_index == sm_manager.ReelAResult) //assign any number except reelA result
                        {
                            random_angle_index = Random.Range(0, outcome_Angles.Count);
                        }
                        sm_manager.ReelAResult = random_angle_index;
                    }
                    break;
                default: // just random spin in default case
                    if (sm_manager.ReelAResult < 0)
                    {
                        sm_manager.ReelAResult = random_angle_index;
                    }
                    Debug.LogError("Default case reel.outcome type");
                    break;
            }
            // set result rotation
            transform.localRotation = Quaternion.Euler(outcome_Angles[sm_manager.ReelAResult], 1, 1);
            sm_manager.numOfReelsPlayed++; // this increments number of times a reel has spun
        }
        enabled = false;
        ReelSpinning = false;
    }

    // to disable script after stop time
    private void StopRand(float stopTime)
    {
        Invoke("EndScript", stopTime);

    }
}
