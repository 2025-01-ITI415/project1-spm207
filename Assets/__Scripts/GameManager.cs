using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public CameraScroll cameraScroll;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        cameraScroll.ResetScroll();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace with your main menu scene name
    }

    public void QuitGame()
    {
        Application.Quit();
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
