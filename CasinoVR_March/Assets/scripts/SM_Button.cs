using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020
 * 
 * This script checks for when hand is attached to the button
 */
public class SM_Button : MonoBehaviour
{

    public bool ButtonTriggered = false;


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
            //Debug.Log("VR hand attached: SM1 button triggered");			
            ButtonTriggered = true;
        }
        else
        {
            ButtonTriggered = false;
        }
    }
}
