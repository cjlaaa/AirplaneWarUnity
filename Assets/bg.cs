using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.down * 1 * Time.deltaTime);
		if(this.transform.position.y < -8)
		{
			this.transform.position = new Vector3(0f, 7.9f, 1f);
		}
	}
}
