using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020
 * 
 * This script checks for when hand is attached to the lever
 */
public class SM_Lever : MonoBehaviour
{

    public bool LeverTriggered = false;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bool attached = this.GetComponent<Valve.VR.InteractionSystem.Throwable>().isAttachedToHand();
        if (attached)
        {
            //Debug.Log("VR hand attached: SM1 lever triggered");			
            LeverTriggered = true;
        }
        else
        {
            LeverTriggered = false;
        }
    }
}
