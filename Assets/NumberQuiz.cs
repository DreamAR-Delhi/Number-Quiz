using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberQuiz : MonoBehaviour
{

    int max;
    int min;
    int guess;

    public int maxGuessesAllowed = 5;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGame();
    }

    // Update is called once per frame

    public void GuessLower()
    {
        max = guess;
        NextGame();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGame();
    }

    void NextGame ()
    {
        guess = Random.Range(min, max +1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
