using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadSelectScene()
    {
        SceneManager.LoadScene("SongSelection");
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("SongStore");
    }
    
    

}