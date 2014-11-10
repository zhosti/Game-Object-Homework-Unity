using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {


	GameObject Player;
	GameObject Cannonball;
	float Timer = 1;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		Cannonball = (GameObject)Resources.Load ("Cannonball");
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (Player.transform.position);
		transform.eulerAngles = (new Vector3 (0f, transform.eulerAngles.y - 180f, 0f));

		float dist = Vector3.Distance (transform.position, Player.transform.position);
		if (dist <= 20) {

			Timer -= Time.deltaTime;
			if (Timer <= 0) {

				Instantiate(Cannonball);
				Cannonball.transform.position = transform.position;
				Cannonball.transform.LookAt(Player.transform.position);
				Timer = 1;
			}
		}
	}
}
