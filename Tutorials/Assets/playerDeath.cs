using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerDeath : MonoBehaviour {
	public GameObject playerChar;
	public Text coinText;
	int coinScore;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerChar.gameObject.transform.position.x < -10.0f) {
			Debug.Log ("test");
		}
	}



	void scoreInc(){
		
		coinText.text = "Score: " + coinScore;

	}
}
