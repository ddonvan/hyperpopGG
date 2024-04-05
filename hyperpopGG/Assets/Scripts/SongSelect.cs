using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongSelect : MonoBehaviour
{
    
    public GameObject imageGameObject;
    public GameObject imageGameObjectDisappear;
    
    public void OnMouseDown()
    {
        if(imageGameObject != null)
        {
           imageGameObject.SetActive(true);
           imageGameObjectDisappear.SetActive(false);
           
        }
    }
}
