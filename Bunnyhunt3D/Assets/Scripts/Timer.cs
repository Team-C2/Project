using UnityEngine;
using System.Collections;

public class Timer : Global {

    public float timer;
	// Use this for initialization
	void Start () {
        timer = 100;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			timer = 0;
			Application.Quit();
		}
	}

	void OnGUI ()
	{
		GUI.Box(new Rect(Screen.width / 2 - 20, 10, 40, 25), "" + timer.ToString("0"));
	}
}

