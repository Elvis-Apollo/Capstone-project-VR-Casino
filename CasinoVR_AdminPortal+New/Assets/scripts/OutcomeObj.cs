using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Valve.Newtonsoft.Json;

public class OutcomeObj : MonoBehaviour
{

    public List<OutcomeType> outcomesList = new List<OutcomeType> { };

    // Use this for initialization
    void Start()
    {
        Debug.Log("COUNT b4: " + outcomesList.Count.ToString());
        AdminPortalJasonParser admin = JsonConvert.DeserializeObject<AdminPortalJasonParser>(File.ReadAllText(@"Assets/scripts/AdminPortal.json"));
        int NumOfLosses;
        int NumOfWins;
        int NumOfNearMisses;

        if (!Int32.TryParse(admin.NumOfLosses, out NumOfLosses))
        {
            // parsing attempt was unsuccessful
            Debug.Log("Parsing String to int failed");
        }
        if (!Int32.TryParse(admin.NumOfWins, out NumOfWins))
        {
            // parsing attempt was unsuccessful
            Debug.Log("Parsing String to int failed");
        }
        if (!Int32.TryParse(admin.NumOfNearMisses, out NumOfNearMisses))
        {
            // parsing attempt was unsuccessful
            Debug.Log("Parsing String to int failed");
        }

        int TotalNumOfOutcomes = NumOfLosses + NumOfWins + NumOfNearMisses;


        for (int i = 0; i < TotalNumOfOutcomes; i++)
        {
            if (NumOfLosses > 0)
            {
                outcomesList.Add(OutcomeType.L);
                NumOfLosses--;
            }
            if (NumOfWins > 0)
            {
                outcomesList.Add(OutcomeType.W);
                NumOfWins--;
            }
            if (NumOfNearMisses > 0)
            {
                outcomesList.Add(OutcomeType.NM);
                NumOfNearMisses--;
            }
        }
        Debug.Log("COUNT after outcome list has been set up: " + outcomesList.Count.ToString());


    }

    // Update is called once per frame
    void Update()
    {

    }
}
