using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void Quit ()
    {
        Debug.Log("Quit");  
        Application.Quit();
    }
    public void startGame()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Returning to Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
