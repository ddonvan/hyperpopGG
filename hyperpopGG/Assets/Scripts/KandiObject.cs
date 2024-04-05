using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KandiObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode keyToPress;
    public AudioSource sound;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
                GameManager.instance.KandiHit();
                sound.Play();
                Debug.Log("Kandi Collected");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator" && gameObject.activeSelf)
        {
            canBePressed = false;

        }
    }
}
