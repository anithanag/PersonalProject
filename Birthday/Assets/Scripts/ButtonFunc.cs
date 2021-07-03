using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunc : MonoBehaviour
{
    

    [Header("Fairy 1st")]
    public GameObject germanTimeline1;
    public GameObject englishTimeline1;

    [Header("Goblin 2nd")]
    public GameObject germanTimeline2;
    public GameObject englishTimeline2;

    [Header("Goblin 3rd")]
    public GameObject germanTimeline3;
    public GameObject englishTimeline3;

    [Header("Oak 4th")]
    public GameObject germanTimeline4;
    public GameObject englishTimeline4;

    [Header("Oak 5th")]
    public GameObject germanTimeline5;
    public GameObject englishTimeline5;

    [Header("Rico 6th")]
    public GameObject germanTimeline6;
    public GameObject englishTimeline6;

    [Header("Rico 7th")]
    public GameObject germanTimeline7;
    public GameObject englishTimeline7;

    [Header("Oger 8th")]
    public GameObject germanTimeline8;
    public GameObject englishTimeline8;

    [Header("Oger 9th")]
    public GameObject germanTimeline9;
    public GameObject englishTimeline9;

    [Header("Oskar 10th")]
    public GameObject germanTimeline10;
    public GameObject englishTimeline10;

    [Header("Oskar 11th")]
    public GameObject germanTimeline11;
    public GameObject englishTimeline11;

    [Header("Fairy 12th")]
    public GameObject germanTimeline12;
    public GameObject englishTimeline12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnGerman()
    {
        germanTimeline1.SetActive(true);
        germanTimeline2.SetActive(true);
        germanTimeline3.SetActive(true);
        germanTimeline4.SetActive(true);        
        germanTimeline5.SetActive(true);
        germanTimeline6.SetActive(true);
        germanTimeline7.SetActive(true);
        germanTimeline8.SetActive(true);
        germanTimeline9.SetActive(true);
        germanTimeline10.SetActive(true);
        germanTimeline11.SetActive(true);
        germanTimeline12.SetActive(true);
    }
    public void BtnEnglish()
    {
        englishTimeline1.SetActive(true);
        englishTimeline2.SetActive(true);
        englishTimeline3.SetActive(true);
        englishTimeline4.SetActive(true);
        englishTimeline5.SetActive(true);
        englishTimeline6.SetActive(true);
        englishTimeline7.SetActive(true);
        englishTimeline8.SetActive(true);
        englishTimeline9.SetActive(true);
        englishTimeline10.SetActive(true);
        englishTimeline11.SetActive(true);
        englishTimeline12.SetActive(true);
    }
}
