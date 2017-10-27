using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallGameActionAfterSeconds : Game_Action {

	[SerializeField] private Game_Action[] gameActions;

	[SerializeField] private float waitTime;

	[SerializeField] private bool playOnStart = false;

	// Use this for initialization
	void Start () {

		if (playOnStart) 
		{
			StartCoroutine (CallAction ());
		}
	}

	public override void StartGameAction (AudioClip clip)
	{
		StartCoroutine (CallAction ());
	}

	IEnumerator CallAction()
	{
		yield return new WaitForSeconds (waitTime);
		foreach (Game_Action action in gameActions) 
		{
			action.StartGameAction (null);
		}
	}
}
