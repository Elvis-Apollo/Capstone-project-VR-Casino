using TMPro;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020  
 * This class modifies a slot machines status text
 */
public class SM_Status_Text : MonoBehaviour
{

    private TextMeshProUGUI status_text;

    SlotMachine_Manager sm_manager;

    // Use this for initialization
    void Start()
    {
        sm_manager = this.GetComponentInParent<SlotMachine_Manager>();

        status_text = this.GetComponent<TextMeshProUGUI>();

        status_text.text = "Ready To Play!";  //currentState = SM_State.UnPlayed;
    }


    // Update is called once per frame
    // replace with switch cases instead of IF/ELSE
    void Update()
    {
        if (sm_manager.currentState == SlotMachine_Manager.SM_State.Spinning)
        {
            status_text.text = "Spinning...";
        }

        else if (sm_manager.currentState == SlotMachine_Manager.SM_State.Won)
        {
            status_text.text = "WON!!";
        }

        else if (sm_manager.currentState == SlotMachine_Manager.SM_State.Lost)
        {
            status_text.text = "Lost..";
        }

        else if (sm_manager.currentState == SlotMachine_Manager.SM_State.NearMiss)
        {
            status_text.text = "Near Miss..";
        }

        else if (sm_manager.currentState == SlotMachine_Manager.SM_State.OutOfTries)
        {
            status_text.text = "Out of tries...";
        }
    }
}