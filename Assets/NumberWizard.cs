﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        Debug.Log("Welcome to Spencer's Number Wizard!");
        Debug.Log("Please pick a number; don't tell me what you've picked!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pisk is 0.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
