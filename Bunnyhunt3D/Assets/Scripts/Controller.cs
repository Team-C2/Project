using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    public float movementSpeed = 50;
    
    void FixedUpdate()
	{
		if (this.gameObject.tag == "bunny")
		{
			float moveHorizontal = Input.GetAxis("Horizontal2");
			float moveVertical = Input.GetAxis("Vertical2");
			
			Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0f, moveVertical * movementSpeed);
			GameObject.FindGameObjectWithTag("bunny").rigidbody.velocity = movement;
		}
		
		if (this.gameObject.tag == "hunter")
		{
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");
			
			Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0f, moveVertical * movementSpeed);
			GameObject.FindGameObjectWithTag("hunter").rigidbody.velocity = movement;
		}
	}
}
