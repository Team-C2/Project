using System;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : Global
{
	public float timeLeft = 100.0f;
	
	public void Update()
	{
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f)
		{
			Application.Quit ();
			guiText.text = "You ran out of time";
		}
		else
		{
			guiText.text = "Time left = " + (int)timeLeft + " seconds";
		}
		
	}
	
}
