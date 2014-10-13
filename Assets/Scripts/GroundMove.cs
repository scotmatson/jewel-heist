using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour {

	GameObject player;
	Transform playerPos;
	PlayerMove playerState;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerPos = player.GetComponent<Transform>();
		playerState = player.GetComponent<PlayerMove> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerState.alive == true) {
			transform.position = new Vector3 (playerPos.transform.position.x, 
		                                  				transform.position.y, 
		                                  				transform.position.z);
		}
	}

	void OnTriggerEnter() {
		playerState.alive = false;
		Destroy (player);

	}
}
