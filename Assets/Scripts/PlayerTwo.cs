using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour {

	public float speed;
	private Rigidbody2D body;
	public float MAX_WIDTH;

	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		Vector3 previousPosition = transform.position;
		
		if (Input.GetKey(KeyCode.W)) {
			//previousPosition.y  += speed;
			body.AddForce(new Vector2(0, speed));
		}
		if (Input.GetKey(KeyCode.S)) {
			//previousPosition.y  -= speed;
			body.AddForce(new Vector2(0, -1 * speed));
		}
		if (Input.GetKey(KeyCode.A)) {
			//previousPosition.x  -= speed;
			if(previousPosition.x > 0) {
				body.AddForce(new Vector2(-1 * speed, 0));
			}
		}
		if (Input.GetKey(KeyCode.D)) {
			//previousPosition.x  += speed;
			body.AddForce(new Vector2(speed, 0));
		}

		if (previousPosition.x < 0) {
			body.position = new Vector2(0, body.position.y);
		}

		if(previousPosition.x > MAX_WIDTH) {
			body.position = new Vector2(MAX_WIDTH, body.position.y);
		}
	}

	public void ResetPositon() {
		body.position = new Vector2 (1.4f, 0.32f);
		body.velocity = new Vector3 (0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
