using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameState : Game_Action {

	[SerializeField] private string gameKey;
	[SerializeField] private int gameState;

	public override void StartGameAction (AudioClip clip)
	{
		PlayerPrefs.SetInt (gameKey, gameState);
	}
}
