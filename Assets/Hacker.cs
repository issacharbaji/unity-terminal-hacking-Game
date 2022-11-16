
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game configuration
    string[] level1Passwords = { "books","aisle","self","password","font","borrow" };
    string[] level2Passwords = { "prisoner", "handcuffs", "holster", "uniform", "arrest" };
    //Game State
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;


    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();      
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassord(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");

        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please Enter a Valid level!");
        }
    }

    void StartGame()
    {
        currentScreen= Screen.Password;
        switch (level)
        {
            case 1:
                int index1 = Random.Range(0,level1Passwords.Length -1);
                password = level1Passwords[index1];
                break;
            case 2:
                int index2 = Random.Range(0, level2Passwords.Length - 1);
                password = level2Passwords[index2];
                break;
            default:
                Debug.LogError("Please choose a valid level!");
                break;
        }
        Terminal.WriteLine("Please Enter Your Password: ");   
    }

    void CheckPassord(string input)
    {
        if ( input== password)
        {
            DispalayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Sorry, Wrong password!");
        }
    }

    void DispalayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Have a Book....");
                Terminal.WriteLine(@"
                   _____
                   |   |
                   -----

                ");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
