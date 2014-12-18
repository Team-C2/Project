﻿using UnityEngine;
using System.Collections;

public class RopeBehaviour : MonoBehaviour {
	
	public GameObject ropePrefab;
	public GameObject pillar;
	public GameObject hunter;
	private ArrayList ropeList;
	private ArrayList pillarList;
	private GameObject currentRope;
	private GameObject previousRope;
	private GameObject currentPillar;
	private GameObject previousPillar;
	
	
	void Start () 
	{
		//pillarList.Add (pillar);
		//ropeList.Add(GameObject.Instantiate (ropePrefab, pillar.transform.position, Quaternion.identity) as GameObject);
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{
		/*
		currentRope = ropeList[ropeList.Count] as GameObject;
		previousRope = ropeList[ropeList.Count - 1] as GameObject; 
		currentPillar = pillarList[pillarList.Count] as GameObject;
		previousPillar = pillarList[pillarList.Count - 1] as GameObject; 
*/
		currentRope = ropePrefab;
		currentPillar = pillar;
		ToHunter (currentPillar, hunter, currentRope);
		//if (ropeList.Count >= 2)
		//				Detatch ();
		
		
	}
	
	private void ToHunter(GameObject originalPilar, GameObject hunter, GameObject currRope)
	{
		//Set the the original pillar and draw a wall towards the hunter
		//Don't forget to switch the tag of the original pillar back and forth
		currRope.transform.position = originalPilar.transform.position;
		
		//GameObject rope = GameObject.Instantiate (currRope, Pillar.transform.position, Quaternion.identity) as GameObject;
		Vector3 lookPos = hunter.transform.position - originalPilar.transform.position;
		float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		//transform.rotation = Quaternion.Slerp (currRope.transform.rotation, 
		//                                       Quaternion.AngleAxis (angle - 90, Vector3.back), Time.deltaTime);
		//currRope.transform.rotation = new Vector3 (0, angle, 0);
		Debug.Log (angle);
		
		currRope.transform.localScale = Vector3.Lerp (currRope.transform.localScale, lookPos, Mathf.Infinity);
		currRope.transform.position = new Vector3 (lookPos.x/2, lookPos.y/2, lookPos.z/2);
	}
	
	private void Attach(GameObject pillarA, GameObject pillarB)
	{
		//Set wall in between to pillars upon collision		
	}
	
	private void Detatch()
	{
	}
	
	
	/*private void ScaleToHunter(Transform hunter) 
	{
		Vector3 dir = hunter.transform.position - this.transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		angle -= 90;
		angle = Mathf.Round(angle/6.0f)*6.0f;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.down);
		this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, q, 6);
	}*/
	
	/*void OnCollision(Collider other)
    {
        if (other.tag == "pole")
        {
        	//activeRope = een bepaald gameobject.
            Instantiate(ropePrefab, other.transform.position, Quaternion.identity);
        }
    }*/
	
}