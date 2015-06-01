using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


	public const int TEAM_1 = 0;
	public const int TEAM_2 = 1;

	public Text scoreText;
	public PlayerOne playerOne;
	public PlayerTwo playerTwo;

	private int scoreTeam1 = 0;
	private int scoreTeam2 = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateScore(int team) {
		if (team == TEAM_1) {
			scoreTeam1++;
		} else if (team == TEAM_2) {
			scoreTeam2++;
		}
		scoreText.text = "Azul: " + scoreTeam1 + " - Verde: " + scoreTeam2;
		playerOne.ResetPositon ();
		playerTwo.ResetPositon ();
	}
}
