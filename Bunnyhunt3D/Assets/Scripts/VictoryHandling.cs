using UnityEngine;
using System.Collections;

public class VictoryHandling : Global {

    public Vector2 resultPosition;
    public Vector2 resultSize;
    public string rematchString;

    public Vector2 rematchPosition;
    public Vector2 rematchSize;
    
    private bool hunterWin, bunnyWin, toggleEndScreen;
    private string winner, resultString;

	// Use this for initialization
	void Start () 
    {
        hunterWin = false;
        bunnyWin = false;
        toggleEndScreen = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (bunnyWin)
            ShowEndScreen("bunny");
        if (hunterWin)
            ShowEndScreen("hunter");
        if (GameObject.FindGameObjectWithTag("hunter").GetComponent<Timer>().timer <= 0)
            bunnyWin = true;
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "bunny" && this.tag == "hunter")
        {
            Debug.Log("Hunter collided with hunter");
            hunterWin = true;
        }
    }

    void ShowEndScreen(string Winner)
    {
        winner = Winner;
        toggleEndScreen = true;
        resultString = "The winner is " + winner + "! \n";
        GameObject.FindGameObjectWithTag("hunter").GetComponent<Controller>().movementSpeed = 0;
        GameObject.FindGameObjectWithTag("bunny").GetComponent<Controller>().movementSpeed = 0;
    }

    void OnGUI()
    {
        if (toggleEndScreen)
        {
            GUI.Label(new Rect(Screen.width / 2 - resultPosition.x, Screen.height / 2 - resultPosition.y, resultSize.x, resultSize.y), resultString);
            if (GUI.Button(new Rect(Screen.width / 2 - rematchPosition.x, Screen.height / 2 - rematchPosition.y, rematchSize.x, rematchSize.y), rematchString))
            {
                Application.LoadLevel("arena");
            }
        }
    }
}
