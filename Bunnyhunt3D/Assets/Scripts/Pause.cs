using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    private bool paused = false;
    private bool toggleButton = false;

    // Use this for initialization
    void Start()
    {
        Debug.Log(Time.timeScale);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
            PauseGame();
    }

    void UnpauseGame()
    {
        Time.timeScale = 1;
        toggleButton = false;
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        toggleButton = true;
    }

    void OnGUI()
    {
        if (toggleButton)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 25, 75, 17), "Unpause"))
            {
                UnpauseGame();
            }
        }
    }
}
