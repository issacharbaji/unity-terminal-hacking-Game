using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen= Screen.MainMenu;


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
            level = 1;
            StartGame();
        }
        else if( input == "2")
        {   
            level = 2;
            StartGame();
        }
        else if( input == "3")
        {
            level = 3;
            StartGame();
        }
        else if ( input == "menu") { 
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid leve!");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have choosen level:" + level);
        Terminal.WriteLine("Please Enter Your Password: ");
        currentScreen = Screen.Password;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
