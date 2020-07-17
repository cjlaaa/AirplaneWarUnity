using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.up * 4 * Time.deltaTime);
		if(this.transform.position.y > 4)
		{
			Destroy(gameObject);
		}
	}
}
