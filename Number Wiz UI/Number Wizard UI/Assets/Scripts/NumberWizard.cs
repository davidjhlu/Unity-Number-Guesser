using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;

    // Start is called before the first frame update
    void Start(){
        Guesser();
    }

    public void OnPressHigher() {
        if(guess != max) {
            min = guess + 1;
        }
        Guesser();
    }

    public void OnPressLower() {
        if(guess != min) {
            max = guess - 1;
        }
        Guesser();
    }   

    void Guesser() {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }
}
