using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSaveAction : Game_Action {

	public override void StartGameAction (AudioClip clip)
	{
		PlayerPrefs.DeleteAll ();
	}
	
}
