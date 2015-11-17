using UnityEngine;
using System.Collections;

public class damMelee : MonoBehaviour {
	EneHP enemigo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Enemy")){
			enemigo = other.gameObject.GetComponent<EneHP>();
			enemigo.vida = enemigo.vida - 1;
		}
	}
}
