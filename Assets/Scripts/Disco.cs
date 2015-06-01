using UnityEngine;
using System.Collections;

public class Disco : MonoBehaviour {

	private Rigidbody2D body;
	public float GOAL_POSITION_MIN;
	public float GOAL_POSITION_MAX;
	public GameController gameController;

	// Use this for initialization
	void Start () {
		this.body = this.GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		if (transform.position.x < GOAL_POSITION_MIN) {
			// Gol do segundo time!
			gameController.UpdateScore(GameController.TEAM_2);
			ResetPostion();
		}
		else if (transform.position.x > GOAL_POSITION_MAX) {
			// Gol do primeiro time!
			gameController.UpdateScore(GameController.TEAM_1);
			ResetPostion();
		}

	}

	private void ResetPostion() {
		transform.position = new Vector2 (0.037f, -0.027f);
		body.velocity = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Border") {

		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
	}

}
