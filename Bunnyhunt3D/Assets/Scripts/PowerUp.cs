using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "bunny") 
		{
			GameObject.FindGameObjectWithTag("bunny").GetComponent<Controller>().movementSpeed += 2.5f;
			Destroy (gameObject);
		}
	}
}
