using UnityEngine;
using System.Collections;

public class LightRotate : MonoBehaviour {

	public float rotateSpeed;

	// Use this for initialization
	void Start () {
		rotateSpeed = 200.0F;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
	}
}
