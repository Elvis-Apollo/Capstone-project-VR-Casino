using System.IO;
using UnityEngine;
using Valve.Newtonsoft.Json;

/*
 * Author: Aleem Haq
 * Date: March 2020
 * 
 * This script acts as a state manager for a slot machine.
 * Data is loaded from json files for each SlotMachine_x
 */
public class SlotMachine_Manager : MonoBehaviour
{
    [HideInInspector]
    public int ReelAResult; // -1 when not set

    [HideInInspector]
    public int numOfReelsPlayed; // increments after each reel spin ends

    public GameObject SlotMachine;   

    //private
    private SM_Lever sm_lever;
    private SM_Button sm_button;
    private SM_Reel[] sm_reels; //reel a,b,c,d
    private Admin_SlotMachineObject admin_SM;
    private HoltLoaryObj holtLoaryObj;

    private int Tries_Left_Count;

    private string adminSettings_json_folder_path;


    private void setAdminJsonsPath()
    {
        adminSettings_json_folder_path = Application.streamingAssetsPath + "/AdminSettings_Jsons/";
    }

    // Use this for initialization
    void Start()
    {
        sm_lever = this.GetComponentInChildren<SM_Lever>();
        sm_button = this.GetComponentInChildren<SM_Button>();
        sm_reels = this.GetComponentsInChildren<SM_Reel>();

        setAdminJsonsPath();

        string sm_json_path = adminSettings_json_folder_path + SlotMachine.name + ".json";  // for current SM
        admin_SM = JsonConvert.DeserializeObject<Admin_SlotMachineObject>(File.ReadAllText(sm_json_path));
        
        string holt_json_path = adminSettings_json_folder_path + "HoltLaury_1.json"; // for HoltLaury1.json
        holtLoaryObj = JsonConvert.DeserializeObject<HoltLoaryObj>(File.ReadAllText(holt_json_path)); 

        Debug.Log(this.name + " Win Payoff Amount: " + holtLoaryObj.getPayoff());


        Tries_Left_Count = admin_SM.OutcomeList.Count;

        Debug.Log(this.name + " Number of total tries to play game: " + Tries_Left_Count);

        ReelAResult = -1; // -1 when not set
        numOfReelsPlayed = 1; // 1 when to start
    }

    // Update is called once per frame
    void Update()
    {
        Tries_Left_Count = admin_SM.OutcomeList.Count;
        //if slotActivated, tries>0 and reels not spinning
        if (!sm_reels[3].ReelSpinning && (sm_lever.LeverTriggered || sm_button.ButtonTriggered) && Tries_Left_Count > 0)
        {
            Debug.Log(this.name + " Current Outcome: " + admin_SM.OutcomeList[0]);
            Debug.Log(this.name + " Started spinning Reels");
            sm_reels[0].Start_Script_Then_End(admin_SM.ReelSpinTime[0], admin_SM.OutcomeList[0]);
            sm_reels[1].Start_Script_Then_End(admin_SM.ReelSpinTime[1], admin_SM.OutcomeList[0]);
            sm_reels[2].Start_Script_Then_End(admin_SM.ReelSpinTime[2], admin_SM.OutcomeList[0]);
            sm_reels[3].Start_Script_Then_End(admin_SM.ReelSpinTime[3], admin_SM.OutcomeList[0]);
            //reel spin ends here after all 4 reels invoked enabled false
            admin_SM.OutcomeList.RemoveAt(0); // remove first index of outcome list(tries--) this way we query 0 index each time
            ReelAResult = -1; // -1 reset ReelA result for new tries
            Tries_Left_Count = admin_SM.OutcomeList.Count;
            Debug.Log(this.name + " Number of total tries left to play: " + Tries_Left_Count);
        }
    }
}
