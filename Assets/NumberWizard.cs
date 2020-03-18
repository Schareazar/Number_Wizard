using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxGuess;
    int minGuess;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGameMessage();
    }

    void StartGameMessage()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("Hi, this is the number wizard");
        Debug.Log("Pick a number for me to guess");
        Debug.Log("You can pick a number between " + minGuess + " and " + maxGuess);
        Debug.Log("Tell me if your number is higher, lower or equal to my guess");
        Debug.Log("If your number is higher press Arrow Up, \n If your number is lower press Arrow Down");
        Debug.Log("If my guess is correct press Enter");
        Debug.Log("Is your number " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So the number you selected is higher");
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So the number you selected is lower");
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("So I guessed your number correctly! \n Your number was " + guess);
            StartGameMessage();
        }
    }
    void NextGuess()
    {
        guess = (minGuess + maxGuess + 1) / 2;
        Debug.Log("What about " + guess + "?");
    }
}
