using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowKandiScore: MonoBehaviour
{
    public string textValue = "";
    public TextMeshProUGUI textElement;

    void Update()
    {

        UpdateLevelDisplay();
    }
    
    public void UpdateLevelDisplay()
    {
        KandiManager kandiManager = KandiManager.instance;
        if (kandiManager != null)
        {
            textElement.text = textValue + kandiManager.qty.ToString();
            //Debug.Log("Score updated to: " + scoreManager.score);
        }
        //levelManager.ResetScore();
    }

}
