using UnityEngine;
using System.Collections;

public class EneHP : MonoBehaviour {
	public int vida = 5;
	public GameObject padre;
	Animator anim;
	public bool muerto = false;
	// Use this for initialization
	void Awake () {
		anim = padre.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (vida < 1) {
			muerto = true;
			anim.SetBool("muere",muerto);
			Destroy(padre,5f);
		}
	}
	
}
