using UnityEngine;
using System.Collections;

public class RopeBehaviour : MonoBehaviour {

	public bool activeRope;
	public Transform hunter;
	public Transform ropePrefab;
	
	void Start () 
	{
		activeRope = true;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (activeRope == true)
		{
			ScaleToHunter (hunter);
		}

	}

	private void ScaleToHunter(Transform hunter) 
	{
		Vector3 dir = hunter.transform.position - this.transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		angle -= 90;
		angle = Mathf.Round(angle/6.0f)*6.0f;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.down);
		this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, q, 6);
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
