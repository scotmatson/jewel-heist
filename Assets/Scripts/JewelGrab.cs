using UnityEngine;
using System.Collections;

public class JewelGrab : MonoBehaviour {

	GameObject player;
	PlayerMove playerJewels;

	void Start() {
		player = GameObject.Find ("Player");
		playerJewels = player.GetComponent<PlayerMove> ();
	}
	
	void OnTriggerEnter() {
		playerJewels.jewels += 1;
		Object.Destroy (this.gameObject);
	}
}
