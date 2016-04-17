using UnityEngine;
using System.Collections;


public class coinScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Debug.Log (col.gameObject.tag);
			addScore ();
			Destroy (this.gameObject, 0.2f);
		}
	}

	void addScore(){
		playerDeath sn = gameObject.GetComponent<playerDeath> ();
		sn.scoreInc;

	}
}
