using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjectAction : Game_Action {
	
	[SerializeField] private GameObject targetObject;

	public override void StartGameAction (AudioClip clip)
	{
		targetObject.SetActive (false);
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		if (Player_Manager.instance.GetPlayerActive()) {
			Text_Box_Controller.instance.SetInactive ();
		}
	}
}
