using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
    public void startGame()
    {
        //need to make this go to the active scene and not the next scene
        //i think this works
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Quit()
    {
        Debug.Log("Returning to Menu");
        SceneManager.LoadScene("Menu");
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
