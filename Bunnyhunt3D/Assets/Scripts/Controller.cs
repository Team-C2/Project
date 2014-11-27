using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    public float movementSpeed = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		if (this.gameObject.tag == "bunny" && (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right")))
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");
			
			Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0f, moveVertical * movementSpeed);
			this.rigidbody.velocity = movement;
		}
		
		if (this.gameObject.tag == "hunter" && (Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w")))
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");
			
			Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0f, moveVertical * movementSpeed);
			this.rigidbody.velocity = movement;
		}
	}
}
