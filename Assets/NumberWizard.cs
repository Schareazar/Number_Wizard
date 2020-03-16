using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxGuess = 1111;
        int minGuess = 111;
        Debug.Log("Hi, this is the number wizard");
        Debug.Log("Pick a number for me to guess");
        Debug.Log("You can pick a number between " + minGuess +  " and " + maxGuess);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
