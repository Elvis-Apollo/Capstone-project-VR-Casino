using System.IO;
using UnityEngine;
using Valve.Newtonsoft.Json;

/*
 * Author: Aleem Haq
 * Data: March 2020
 * 
 * This script acts as a state manager for a slot machine.
 * Data is loaded from json files for each SlotMachine_x
 */
public class SlotMachine_Manager : MonoBehaviour
{

    public GameObject SlotMachine;
    //public string JsonName;
    public string JsonPath;


    public int ReelAResult; // -1 when not set
    public int numOfReelsPlayed; // increments after each reel spin ends

    //private
    private SM_Lever sm_lever;
    private SM_Button sm_button;
    private SM_Reel[] sm_reels; //reel a,b,c,d
    private Admin_SlotMachineObject admin;

    private int Tries_Left_Count;


    private void setJsonPath()
    {
        // if current slot machines matches a item.Key from JsonFilesInfo.FileDict, then assign the jsonPath of item.Value
        foreach (var item in JsonFilesInfo.FileDict)
        {
            // if current game object maches some SlotMachine_x name from dictionary
            if (SlotMachine.Equals(GameObject.Find(item.Key)))
            {
                JsonPath = item.Value; //then set json path to that slotMachine
                break;
            }
        }
        if (JsonPath == "" || JsonPath == null) // if json path still empty, then use default case
        {
            Debug.Log("Slot_Mach_ Default case_Json");
            JsonPath = "Assets/scripts/SlotMachine_1.json"; //change to default case
        }
    }

    // Use this for initialization
    void Start()
    {
        sm_lever = this.GetComponentInChildren<SM_Lever>();
        sm_button = this.GetComponentInChildren<SM_Button>();
        sm_reels = this.GetComponentsInChildren<SM_Reel>();
        setJsonPath();
        admin = JsonConvert.DeserializeObject<Admin_SlotMachineObject>(File.ReadAllText(@JsonPath));

        //JsonName = (admin == null) ? "SM_1" : admin.ObjectName;
        //JsonName = admin.ObjectName ?? "SM_1";

        Tries_Left_Count = admin.OutcomeList.Count;

        Debug.Log(this.name + " Number of total tries to play game: " + Tries_Left_Count);

        ReelAResult = -1; // -1 when not set
        numOfReelsPlayed = 1; // 1 when to start
    }

    // Update is called once per frame
    void Update()
    {
        Tries_Left_Count = admin.OutcomeList.Count;
        //if slotActivated, tries>0 and reels not spinning
        if (!sm_reels[3].ReelSpinning && (sm_lever.LeverTriggered || sm_button.ButtonTriggered) && Tries_Left_Count > 0)
        {
            Debug.Log(this.name + " Current Outcome: " + admin.OutcomeList[0]);
            Debug.Log(this.name + " Started spinning Reels");
            sm_reels[0].Start_Script_Then_End(admin.ReelSpinTime[0], admin.OutcomeList[0]);
            sm_reels[1].Start_Script_Then_End(admin.ReelSpinTime[1], admin.OutcomeList[0]);
            sm_reels[2].Start_Script_Then_End(admin.ReelSpinTime[2], admin.OutcomeList[0]);
            sm_reels[3].Start_Script_Then_End(admin.ReelSpinTime[3], admin.OutcomeList[0]);
            //reel spin ends here after all 4 reels invoked enabled false
            admin.OutcomeList.RemoveAt(0); // remove first index of outcome list(tries--) this way we query 0 index each time
            ReelAResult = -1; // -1 reset ReelA result for new tries
            Tries_Left_Count = admin.OutcomeList.Count;
            Debug.Log(this.name + " Number of total tries left to play: " + Tries_Left_Count);
        }
    }
}
