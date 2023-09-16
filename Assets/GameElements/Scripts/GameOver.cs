using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameOver;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void gameOverAction()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void load()
    {
        SceneManager.LoadScene(0);
    }   
}
