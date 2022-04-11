

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GuessTheNumber : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }
    public void onPressHigher()
    {
        min = guess + 1;

        NextGuess();

    }
    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
    void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    // Update is called once per frame

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

    }

}
