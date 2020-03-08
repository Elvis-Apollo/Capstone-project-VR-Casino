using System.Collections.Generic;

/*
 * Author: Aleem Haq
 * Data: March 2020 * 
 * This class will import SlotMachine.json file
 * that data passes to unity classes
 */
public class Admin_SlotMachineObject
{
    public string ObjectName { get; set; }
    public List<OutcomeType> OutcomeList { get; set; }
    public List<float> ReelSpinTime { get; set; }
}
