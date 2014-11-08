using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	float speed = 3;

	 Camera MainCam;
	//GameObject Player;

	void Star() {
		MainCam = (Camera)GameObject.Find ("Main Camera").GetComponent<Camera>();
		//Player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(0f,0f,speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(0f,0f,-speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(speed * Time.deltaTime,0f,0f);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(-speed * Time.deltaTime,0f,0f);
		}


		float horizontal = 3.0f * Input.GetAxis("Mouse X");
		float vertical = 3.0f * Input.GetAxis("Mouse Y");
		transform.Rotate(0f, horizontal, 0f);
		//MainCam.transform.Rotate(vertical, 0f, 0f);

	}
}
