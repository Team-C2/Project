using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {


	public Transform[] teleport;
	public GameObject[] prefab;
	public float CoolDownTime = 2f;
	private float originalCoolDown;
	//private float CoolDown = 0f;

	void Start()
	{ //this will spawn only one prefab, if you want call it many time, create a new function and call it or create for loop
		originalCoolDown = CoolDownTime;
	}

	void Update()
	{
		if (CoolDownTime <= 0)
		{
			Spawn ();
			CoolDownTime = originalCoolDown + Random.Range(0f,5f);

		}
		CoolDownTime -= Time.deltaTime;
	}

	void Spawn()
	{
		int tele_num = Random.Range(0,8);
		int prefab_num = Random.Range(0,4);
		Instantiate(prefab[prefab_num], teleport[tele_num].position, teleport[tele_num].rotation );

	}
	
	//And remember to asign all teleport transforms and prefabs in inspector
	
}