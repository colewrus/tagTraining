using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class coinScript : MonoBehaviour {

	public GameObject spawnSpot;
	public Text coinText;
	public Text lifeText;
	int coinScore;
	int lives;


	// Use this for initialization
	void Start () {
		coinScore = 0;
		lives = 3;
		lifeText.text = "Lives: " + lives;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -10.0f) {
			this.transform.position = spawnSpot.transform.position;
			lives -= 1;
			lifeText.text = "Lives: " + lives;
		}

		if (lives == 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}


	void OnTriggerEnter(Collider col){
		coinScore += 1;
		coinText.text = "Score: " + coinScore;
		Destroy (col.gameObject);
	}

}
