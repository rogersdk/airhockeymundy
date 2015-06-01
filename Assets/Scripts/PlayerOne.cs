using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {


	public float speed;
	private Rigidbody2D body;
	public float MIN_WIDTH;

	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {


		Vector3 previousPosition = transform.position;
		
		if (Input.GetKey(KeyCode.UpArrow)) {
			//previousPosition.y  += speed;
			body.AddForce(new Vector2(0, speed));
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			//previousPosition.y  -= speed;
			body.AddForce(new Vector2(0, -1 * speed));
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//previousPosition.x  -= speed;
			body.AddForce(new Vector2(-1 * speed, 0));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			//previousPosition.x  += speed;
			if(previousPosition.x < 0) {
				body.AddForce(new Vector2(speed, 0));
			}
		}

		if (previousPosition.x > 0) {
			body.position = new Vector2(0, body.position.y);
		}

		if(previousPosition.x < MIN_WIDTH) {
			body.position = new Vector2(MIN_WIDTH, body.position.y);
		}

	    if (Input.touchCount > 0) {
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPosition = new Vector2(worldPosition.x, worldPosition.y);
			if(Physics2D.OverlapPoint(touchPosition).gameObject.CompareTag("Pino1")) {
				//this.DragMode();
			}
		}

	}


	private void DragMode() {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 touchPos = Input.GetTouch (0).position;
			Vector3 touchPosInWorld = Camera.main.ScreenToWorldPoint (new Vector3 (touchPos.x, touchPos.y, Camera.main.nearClipPlane));
			this.transform.position = touchPosInWorld;
		} else if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			//this.StopMode();
		}
	}



	public void ResetPositon() {
		body.position = new Vector2 (-1.4f, 0.38f);
		body.velocity = new Vector3 (0, 0, 0);
	}

	// Update is called once per frame
	void Update () {

		/*if (Input.GetMouseButton(0)) {
			transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}*/

	}
}
