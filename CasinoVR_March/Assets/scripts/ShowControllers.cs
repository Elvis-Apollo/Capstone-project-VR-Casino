﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ShowControllers : MonoBehaviour {

    // Use this for initialization
    public bool showControllers = false; 
	
	// Update is called once per frame
	void Update ()
    {
        foreach (var hand in Player.instance.hands)
        {
            if (showControllers)
            {
                hand.ShowController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);
            }
            else
            {
                hand.HideController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
            }
        }
	}
}
