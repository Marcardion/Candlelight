using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGameState : MonoBehaviour {

	public enum GameStateComparison {Equals, LessThan, MoreThan};

	[SerializeField] private GameStateComparison comparison = GameStateComparison.Equals;
	[SerializeField] private string gameKey;
	[SerializeField] private int gameState;

	// Use this for initialization
	void Start () {

		if (comparison == GameStateComparison.Equals) {
			if (PlayerPrefs.GetInt (gameKey, 0) != gameState) {
				this.gameObject.SetActive (false);
			}
		}

		if (comparison == GameStateComparison.LessThan) {
			if (PlayerPrefs.GetInt (gameKey, 0) > gameState) {
				this.gameObject.SetActive (false);
			}
		}

		if (comparison == GameStateComparison.MoreThan) {
			if (PlayerPrefs.GetInt (gameKey, 0) < gameState) {
				this.gameObject.SetActive (false);
			}
		}

		//Debug.Log (gameKey + PlayerPrefs.GetInt (gameKey, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
