using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameController : MonoBehaviour
{
    //Singleton Pattern
    public static GameController instance;
     
    void Awake()
    {
        // If an instance already exists, destroy this one
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        // Otherwise, make this the instance
        else
        {
            instance = this;
            // Enable persistence across scenes
            DontDestroyOnLoad(this.gameObject);
        }
       
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            SceneManager.LoadScene("SinglePlayer");
        }
    }
}