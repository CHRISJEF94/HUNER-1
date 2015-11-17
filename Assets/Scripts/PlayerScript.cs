using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	Animator anim;

	bool movd = false;
	bool movi = false;
	bool mova = false;
	bool movb = false;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update(){
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		bool ataca = Input.GetKeyDown ("z");
		Mover (hor, ver);
		Atacar (ataca);

	}

	void Mover(float hor, float ver){
		if(hor > 0f){
			movd = true;
			movi = false;
			anim.SetBool("movi",movi);
			anim.SetBool("movd",movd);
		}
		if(hor == 0f){
			movd = false;
			movi = false;
			anim.SetBool("movd",movd);
			anim.SetBool("movi",movi);
		}
		if(hor < 0f){
			movi = true;
			anim.SetBool("movi",movi);
		}
		if(ver > 0f){
			mova = true;
			anim.SetBool("mova",mova);
		}
		if(ver == 0f){
			mova = false;
			movb = false;
			anim.SetBool("mova",mova);
			anim.SetBool("movb",movb);
		}
		if(ver < 0f){
			movb = true;
			anim.SetBool("movb",movb);
		}
	}

	void Atacar(bool ataca){
		if (ataca) {
			anim.SetTrigger("atk");
		}
	}
}
