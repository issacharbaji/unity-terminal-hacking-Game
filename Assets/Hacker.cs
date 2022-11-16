using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();      
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        /*var menu = "menu";*/
   
        if ( input == "1")
        {
            StartGame(1);
        }
        else if( input == "2")
        {
            StartGame(2);
        }
        else if( input == "3")
        {
            StartGame(3);
        }
        else if ( input == "menu") { 
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid leve!");
        }
    }

    void StartGame(int level)
    {
        Terminal.WriteLine("You have choosen level:" + level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
