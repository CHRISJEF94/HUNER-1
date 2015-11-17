using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tuto1 : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){
		text.text = "Presiona S para saltar";
	}
}
