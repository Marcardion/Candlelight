using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApplicationAction : Game_Action {

	public override void StartGameAction (AudioClip clip)
	{
		Application.Quit ();
	}
}
