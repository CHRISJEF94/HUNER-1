using UnityEngine;
using System.Collections;

public class CamScript : MonoBehaviour {
	public Transform player;
	//Camera mycam;

	void Start(){
		//mycam = gameObject.GetComponent<Camera> ();

	}

	void Update(){
		//mycam.orthographicSize = (Screen.height / 50f) / 2f;
		if (player) {
			transform.position = Vector3.Lerp(new Vector3(0f,transform.position.y,0f), new Vector3(0f,player.position.y,0f), 0.1f) + new Vector3(0f,0f,-10f);
			if(transform.position.y < 0){
				transform.position = new Vector3(0,0,-10f);
			}
		}
	}
}
