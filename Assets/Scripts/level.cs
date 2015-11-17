using UnityEngine;
using System.Collections;

public class level : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")){
		Application.LoadLevel(1);
		}
	}

}
