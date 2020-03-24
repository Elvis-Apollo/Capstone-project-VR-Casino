using System.Collections.Generic;

/*
 * Author: Aleem Haq
 * Date: March 2020 * 
 * This class is a Slot machine object for a SlotMachine_x.json data type
 */
[System.Serializable]
public class Admin_SlotMachineObject
{
    public string ObjectName { get; set; }
    public List<OutcomeType> OutcomeList { get; set; }
    public List<float> ReelSpinTime { get; set; }
}
