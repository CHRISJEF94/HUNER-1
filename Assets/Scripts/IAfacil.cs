using UnityEngine;
using System.Collections;

public class IAfacil : MonoBehaviour {
	Transform player;
	Animator anim;
	EneHP hp;
	public GameObject local;
	private Transform a;
	private Transform d;
	private Transform i;
	private Transform b;
	private bool ma = false;
	private bool md = false;
	private bool mi = false;
	private bool mb = false;
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Target").GetComponent<Transform> ();
		anim = gameObject.GetComponent<Animator> ();
		hp = local.GetComponent<EneHP> ();
		a = transform.FindChild ("a");
		d = transform.FindChild ("d");
		i = transform.FindChild ("i");
		b = transform.FindChild ("b");
	}
	
	// Update is called once per frame
	void Update(){
		ma = Physics2D.Linecast(transform.position, a.position, 1 << LayerMask.NameToLayer("Player"));  
		md = Physics2D.Linecast(transform.position, d.position, 1 << LayerMask.NameToLayer("Player"));  
		mi = Physics2D.Linecast(transform.position, i.position, 1 << LayerMask.NameToLayer("Player"));  
		mb = Physics2D.Linecast(transform.position, b.position, 1 << LayerMask.NameToLayer("Player"));  
		if (ma || md || mi || mb) {
			if (ma) {
				anim.SetBool ("sa", ma);
				anim.SetBool ("sd", md);
				anim.SetBool ("si", mi);
				anim.SetBool ("sb", mb);
			} else if (md) {
				anim.SetBool ("sa", ma);
				anim.SetBool ("sd", md);
				anim.SetBool ("si", mi);
				anim.SetBool ("sb", mb);
			} else if (mi) {
				anim.SetBool ("sa", ma);
				anim.SetBool ("sd", md);
				anim.SetBool ("si", mi);
				anim.SetBool ("sb", mb);
			} else if (mb) {
				anim.SetBool ("sa", ma);
				anim.SetBool ("sd", md);
				anim.SetBool ("si", mi);
				anim.SetBool ("sb", mb);
			}
			anim.SetTrigger("atk");
		}
	}

	void OnTriggerStay2D (Collider2D other) {
		if (!hp.muerto) {
			if (other.gameObject.CompareTag ("Player")) {
				if (player) {
					float px = transform.position.x - player.position.x;
					float py = player.position.y - transform.position.y;
					if (px > -1f && px < 1f) {
						transform.position = transform.position - new Vector3 (0f, (transform.position.y - player.position.y), 0f) * Time.deltaTime;
						if (py > 1f) {
							anim.SetBool ("movd", false);
							anim.SetBool ("movi", false);
							anim.SetBool ("movb", false);
							anim.SetBool ("mova", true);
						}
						if (py < -1f) {
							anim.SetBool ("movd", false);
							anim.SetBool ("movi", false);
							anim.SetBool ("mova", false);
							anim.SetBool ("movb", true);
						}
					} else {
						transform.position = transform.position - new Vector3 ((transform.position.x - player.position.x), 0f, 0f) * Time.deltaTime;
						if (px < -1f) {
							anim.SetBool ("mova", false);
							anim.SetBool ("movb", false);
							anim.SetBool ("movi", false);
							anim.SetBool ("movd", true);
						}
						if (px > 1f) {
							anim.SetBool ("mova", false);
							anim.SetBool ("movb", false);
							anim.SetBool ("movd", false);
							anim.SetBool ("movi", true);
						}
					}

					if (px < 1f && -1f < px && -1f < py && py < 1f) {
						anim.SetBool ("mova", false);
						anim.SetBool ("movb", false);
						anim.SetBool ("movd", false);
						anim.SetBool ("movi", false);
					}
				}
			}
		}
	}
	void OnTriggerExit2D (Collider2D other){
		if (!hp.muerto) {
			if (other.gameObject.CompareTag ("Player")) {
				anim.SetBool ("mova", false);
				anim.SetBool ("movb", false);
				anim.SetBool ("movd", false);
				anim.SetBool ("movi", false);
			}
		}
	}
}
