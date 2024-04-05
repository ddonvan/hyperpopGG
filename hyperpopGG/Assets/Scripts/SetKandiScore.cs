using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Add this line to import the UnityEngine.UI namespace
using TMPro;

public class SetKandiScore : MonoBehaviour
{

    public TextMeshProUGUI kandiScoreText;
    void Start()
    {
        kandiScoreText.text = PlayerPrefs.GetInt("kandi").ToString();
    }

    // Update is called once per frame
    void Update()
    {
                kandiScoreText.text = PlayerPrefs.GetInt("kandi").ToString();

    }
}
