using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public GameObject prefabs;
    public float bulletInterval = 0.5f;
    private Vector3 mousePosPre;
    private float bulletTime = 0;

	// Use this for initialization
	void Start () {
		mousePosPre = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePosOnScreen = Input.mousePosition;
        mousePosOnScreen.z = screenPos.z;
        Vector3 mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePosOnScreen);

        if (Input.GetMouseButtonDown(0))
        {
            mousePosPre = mousePosInWorld;
        }
		if (Input.GetMouseButton(0))
        {
            this.transform.position -= mousePosPre - mousePosInWorld; 
            // Debug.Log(mousePosPre - mousePosInWorld);
            mousePosPre = mousePosInWorld;
        }

        bulletTime -= Time.deltaTime;
        if(bulletTime < 0)
        {
            bulletTime = bulletInterval;

            Vector3 initPos = new Vector3(this.transform.position.x,this.transform.position.y + 0.7f,this.transform.position.z);
            Instantiate(prefabs,initPos,Quaternion.identity);
        }
	}
}
