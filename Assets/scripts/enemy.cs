using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	public float speed = 1;
	private bool dead = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(!dead){
			this.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		else
		{
			this.transform.Translate(Vector3.down * speed * Time.deltaTime / 2);
		}

		if(this.transform.position.y < -4)
		{
			Destroy(gameObject);
		}

		AnimatorStateInfo stateinfo = this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		bool playingDead = stateinfo.IsName("enemy1_dead") || stateinfo.IsName("enemy2_dead") || stateinfo.IsName("enemy3_dead");
		if(playingDead && stateinfo.normalizedTime >= 1.0f)
		{
			//播放结束
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D ( Collider2D box ) 
	{
		// print (box.gameObject.name);
		if(box.gameObject.name.Substring(0, 6)=="bullet")
		{
			Animator ator = this.GetComponent<Animator>();
			ator.SetInteger("enemyState", 1);
			dead = true;
			// Destroy(gameObject);
		}
	}
}
