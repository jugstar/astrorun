using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Script is for managing tutorial windows that will pop up in the beginning of the game.
 * 
 */
public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps; // Pop up windows to display instructions on the games controls
    private int popUpIndex; // index for checking which window has popped up


    void Update()
    {
        
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true); // Display the pop up window with the current pop up index
            }
            else {
                popUps[i].SetActive(false); // Hide the pop up windows that dont have the current index
            }
        }
        if (popUpIndex == 0) // If index is 0, tutorial has just started. 
        {
            // Check if player has pressed the left and right arrows
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                popUpIndex++; // Increment index 
            }
        }
        else if (popUpIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                popUpIndex++;
            }

        } 
    }
}
