using UnityEngine;
using System.Collections;

public class RopeBehaviour : Global {

	public bool activeRope;
	private Collider hunter;
	public Transform ropePrefab;
	
	void Start () 
	{
		activeRope = true;
		//hunter = GameObject.FindGameObjectsWithTag ("hunter");

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (activeRope == true)
		{
			//ScaleToHunter (this, hunter);
		}

	}

	private void ScaleToHunter(GameObject objectToScale, Collider hunter) 
	{

		
	}

	void OnCollision(Collider other)
	{
		if (other.tag == "pole") 
		{
			this.activeRope = false;
			Instantiate(ropePrefab, other.transform.position, Quaternion.identity);
		}

	}
}
