using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020  
 * This class modifies a slot machines Tries count text
 */
public class SM_Tries_Text : MonoBehaviour {

	private TextMeshProUGUI tries_text;

	SlotMachine_Manager sm_manager;

	// Use this for initialization
	void Start () {
		sm_manager = this.GetComponentInParent<SlotMachine_Manager>();

		tries_text = this.GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
		tries_text.text = "Attempts Left: " + sm_manager.Tries_Left_Count;
	}
}
