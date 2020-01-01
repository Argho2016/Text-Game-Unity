﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

   // int[] oddNumbers = {1,3,5,7,9 };

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
        //Debug.Log(oddNumbers[3]);
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.GetNextState();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[0];
            }
        }


      /*  if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        */

        textComponent.text = state.GetStateStory();
    }
}
