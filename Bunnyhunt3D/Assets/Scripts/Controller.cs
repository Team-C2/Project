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

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0.0f ,moveVertical * movementSpeed);
        rigidbody.velocity = movement;

    }
}
