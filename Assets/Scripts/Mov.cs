using UnityEngine;
using System.Collections;

public class Mov : MonoBehaviour {
	Vector3 velh = new Vector3(2.5f,0f,0f);
	Vector3 velv = new Vector3(0f,2.5f,0f);	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		if (hor > 0.5f) {
			transform.position = transform.position + velh * Time.deltaTime;
		}
		if (hor == 0f) {
		}
		if (hor < -0.5f) {
			transform.position = transform.position + velh * Time.deltaTime * (-1);
		}
		if (ver > 0.5f) {
			transform.position = transform.position + velv * Time.deltaTime;
		}
		if (ver == 0f) {
		}
		if (ver < -0.5f) {
			transform.position = transform.position + velv * Time.deltaTime * (-1);
		}
	}
}
