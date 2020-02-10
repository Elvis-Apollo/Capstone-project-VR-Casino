﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This class is used to activate spin on ReelA game object based off 
 * the predefined outcome list(Lever_Trigger.outcomesList).
   Note: Outcome of the spin of this object affects the outcome of spinning ReelB, ReelC and ReelD.
 */
public class Reel_Primary_Spin : MonoBehaviour
{

    public Sprite[] sprites;

    public GameObject leverObject;

    public Sprite finalSprite;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //RandomingImage();
        if (leverObject.GetComponent<Lever_Trigger>().spinReels == true)
        {
            RandomingImage();
        }
    }

    void RandomingImage()
    {
        finalSprite = gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

    public void EndRand()
    {
        enabled = false;
    }

    // to disable script after stop time
    /*public void StopRand()
	{
		Invoke("EndRand", stopTime);

	}*/

    public void StartRand()
    {
        enabled = true;
    }
}
