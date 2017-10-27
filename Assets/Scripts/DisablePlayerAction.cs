using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayerAction : Game_Action {

	//Careful when using this.

	public override void StartGameAction (AudioClip clip)
	{
		Player_Manager.instance.SetPlayerInactive ();
	}
}
