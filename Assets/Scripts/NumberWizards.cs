using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {
    // Use this for initialization
    int max;
    int min;
    int guess;

    public int maxGuessessAllowed = 6;
    public Text text;

    void Start () {
        StartGame();
	}
	
    void StartGame () {
        max = 1000;
        min = 1;
        NextGuess();
    }

    public void GuessLower(){
        max = guess;
        NextGuess();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessessAllowed = maxGuessessAllowed - 1;
        if(maxGuessessAllowed <= 0) {
            Application.LoadLevel("Win");
        }
    }
}