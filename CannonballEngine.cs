using UnityEngine;
using System.Collections;

public class CannonballEngine : MonoBehaviour {

	float TimeOut = 3;
	float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += this.transform.forward * (Time.deltaTime * speed);

		TimeOut -= Time.deltaTime;
		if (TimeOut <= 0) {
			Destroy(this.gameObject);
		}
	}
}
