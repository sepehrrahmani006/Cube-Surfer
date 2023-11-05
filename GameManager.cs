using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject LoosingUI;

    public void LoosingUIDisplay()
    {
        LoosingUI.SetActive(true);
    }
    
    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Winning");

    }


    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            LoosingUI.SetActive(true);
            FindObjectOfType<AudioManager>().PlaySound("Loosing");
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameHasEnded = false;

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
