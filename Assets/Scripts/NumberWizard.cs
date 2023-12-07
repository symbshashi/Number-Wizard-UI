using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int max;
    [SerializeField]int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        
        Startgame();
       
    }
    void Startgame()
    {
          
       
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        max = max + 1;
    }
    public void OnpressHigher()
    {
        min = guess;
        Nextguess();
    }
    public void OnpressLower()
    {

        max = guess;
        Nextguess();
    }
    void Nextguess()
    {
        guess = (max+min)/2;
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
}
