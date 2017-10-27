using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjectAction : Game_Action {

	[SerializeField] private GameObject targetObject;

	public override void StartGameAction (AudioClip clip)
	{
		targetObject.SetActive (true);
	}
}
