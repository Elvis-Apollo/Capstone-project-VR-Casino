using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/*
 * This class is used to activate spin on ReelB, ReelC and ReelD game objects.
   Note: Outcome of the spin of these objects is based off the results of spinning ReelA and
   the predefined outcome list(Lever_Trigger.outcomesList)
 */
public class Reel_Secondary_Spin : MonoBehaviour
{

    public Sprite[] sprites;

    public GameObject leverObject;

    public GameObject reelObj;

    Sprite currentSprite;

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
        //tracking the current sprite helps us compare it to the final sprite of ReelB,ReelC,ReelD with ReelA
        currentSprite = gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

    public void SetWinImage()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = reelObj.GetComponent<Reel_Primary_Spin>().finalSprite;
    }

    public void SetLossImage()
    {
        if (currentSprite == reelObj.GetComponent<Reel_Primary_Spin>().finalSprite)
        {
            Sprite[] spriteCopy = reelObj.GetComponent<Reel_Primary_Spin>().sprites; //make a copy for original sprites array from reel_primary_spin
            List<Sprite> spriteCopyList = spriteCopy.OfType<Sprite>().ToList(); //change array to list
            spriteCopyList.Remove(currentSprite); // remove the currentSprite from spriteCopyList so that we can random through remaining sprites for L outcome
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = spriteCopyList[Random.Range(0, spriteCopyList.Count)];
        }
        // else: leave current object on the reel
    }

    public void SetNearMissImage()
    {

        Sprite[] spriteCopy = reelObj.GetComponent<Reel_Primary_Spin>().sprites; //make a copy for original sprites array from reel_primary_spin
        List<Sprite> spriteCopyList = spriteCopy.OfType<Sprite>().ToList(); //change array to list
        int index = spriteCopyList.IndexOf(reelObj.GetComponent<Reel_Primary_Spin>().finalSprite); //get the index of the finalSprite from reel_primary_spin 
        if (index != spriteCopyList.Count - 1) //use this index to finalize image for ReelD for a NearMiss outcome.
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = spriteCopyList[index + 1];
        else
        {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = spriteCopyList[0];
        }

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
