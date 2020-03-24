using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Date: March 2020 * 
 * This class is a Holt Laury object for a holtLaury.json data type
 */
[System.Serializable]
public class HoltLoaryObj
{
    public float OptionA_Max { get; set; }
    public float OptionA_Min { get; set; }

    public float OptionB_Max { get; set; }
    public float OptionB_Min { get; set; }

    public List<string> Decision_Choices { get; set; }

    public float finalPayoff;

    private int getRandomIndex()
    {
        return UnityEngine.Random.Range(0, Decision_Choices.Count);
    }

    // gets a random payoff from the choice list
    public float getPayoff()
    {
        finalPayoff = 0f;
        float tempMax;
        float tempMin;
        string random_payoff = Decision_Choices[getRandomIndex()];

        if (random_payoff.Contains("A"))
        {
            tempMax = OptionA_Max;
            tempMin = OptionA_Min;
        }

        else if (random_payoff.Contains("B"))
        {
            tempMax = OptionB_Max;
            tempMin = OptionB_Min;
        }
        else
        {
            tempMax = 0.0f;
            tempMin = 0.0f;
        }
        Debug.Log("---------------PAYOFF: " + random_payoff + " where, x/10 of " + tempMax + " and, (10-x)/10 of : " + tempMin);

        char[] trimChars = { 'A', 'B', ' ' }; // remove A|B or whitespace prefix
        var rowNumber = random_payoff.TrimStart(trimChars); // get number only string        

        //match row number with i and then apply the math for payoff using i/rowNumber value
        for (int i = 1; i <= 10; i++)
        {
            if (rowNumber == i.ToString()) //convert string to int and compare with i
            {
                // apply payoff payoff holt laury formula
                // max * (x/10)  +  min * ((10-x) / 10)
                finalPayoff = (float ) ((tempMax * (i / 10.0)) + (tempMin * ((10 - i) / 10.0)));
                break;
            }
        }        
        return (float)Math.Round((double)finalPayoff, 2); //round to 2 decimal place
    }
}
