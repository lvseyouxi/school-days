using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

public class getpanel: MonoBehaviour {


    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it//这个玩意显示在检视图层上

    [SerializeField]
    Text timeText; //Will assign our Time Text to this variable so we can modify the text it displays.

    bool isPaused; //Used to determine paused state

    void Start()
    {
        UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts。///关掉panel
        isPaused = false; //make sure isPaused is always false when our scene opens
    }

    void Update()
    {

        timeText.text = "Time Since Startup: " +(int)Time.time; //Tells us the time since the scene loaded

        //If player presses escape and game is not paused. Pause game. If game is paused and player presses escape, unpause.
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
            Pause();
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
            UnPause();
    }

    public void Pause()
    {
        isPaused = true;
        UIPanel.gameObject.SetActive(true); //turn on the pause menu
        Time.timeScale = 0f; //pause the game
    }

    public void UnPause()
    {
        isPaused = false;
        UIPanel.gameObject.SetActive(false); //turn off pause menu
        Time.timeScale = 1f; //resume game
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Application.LoadLevel(0);//？？？？？
    }
}
