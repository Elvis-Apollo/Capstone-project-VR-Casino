using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020  
 * This class modifies a slot machines Pay won text
 */
public class SM_Pay_Text : MonoBehaviour
{

    private TextMeshProUGUI pays_text;

    SlotMachine_Manager sm_manager;

    // Use this for initialization
    void Start()
    {
        sm_manager = this.GetComponentInParent<SlotMachine_Manager>();

        pays_text = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sm_manager.currentState !=  SlotMachine_Manager.SM_State.Spinning) { 
        pays_text.text = "Won: " + sm_manager.Won_Pay + "$";
        }

    }
}
