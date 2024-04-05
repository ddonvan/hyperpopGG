using UnityEngine;

public class KandiManager : MonoBehaviour
{
    public static KandiManager instance;

    public int qty = 0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { Destroy(gameObject); }

        // Retrieve the score from PlayerPrefs when the game starts
        qty     = PlayerPrefs.GetInt("kandi", 0);

    }
}
