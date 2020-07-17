using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {
	public GameObject[] enemys;
	public float[] speed;
	public float[] interval;
	private float[] timers;

	// Use this for initialization
	void Start () {
		timers = new float[enemys.Length];
		for (int i = 0; i <= enemys.Length - 1; i++)
		{
			timers[i] = interval[i];
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i <= enemys.Length - 1; i++)
		{
			timers[i] -= Time.deltaTime;
			if(timers[i] < 0)
			{
				timers[i] = interval[i];

				Vector3 initPos = new Vector3(Random.Range(-3f, 3f),5,0);
				// print(initPos);
	            Instantiate(enemys[i],initPos,Quaternion.identity);
			}
		}
	}
}
