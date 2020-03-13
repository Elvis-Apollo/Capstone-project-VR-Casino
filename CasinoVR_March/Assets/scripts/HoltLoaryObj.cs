using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Aleem Haq
 * Data: March 2020 * 
 * This class is a Holt Laury object for a holtLaury.json data type
 */
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
        Debug.Log(" Chosen payoff of format 'A|B x' is " + random_payoff + " where, x/10 of " + tempMax + " and, (10-x)/10 of : " + tempMin);

        char[] trimChars = { 'A', 'B', ' ' }; // remove A|B or whitespace prefix
        var rowNumber = random_payoff.TrimStart(trimChars); // get number only string

        Debug.Log("Row Number: " + rowNumber);

        for (int i = 1; i <= 10; i++)
        {
            if (rowNumber == i.ToString())
            {  //convert string to int and compare with i
                //finalPayoff = (tempMax * (i / 10)) + (tempMin * ((10 - i) / 10)); // apply payoff holt laury formula

                var a = tempMax * (i / 10.0);

                var b = tempMin * ((10 - i) / 10.0);
                Debug.Log("A: " + a.ToString());
                Debug.Log("B: " + b);
                finalPayoff = (float ) (a + b); // apply payoff holt laury formula
                break;
            }
        }        
        return (float)Math.Round((double)finalPayoff, 2);
    }
}
