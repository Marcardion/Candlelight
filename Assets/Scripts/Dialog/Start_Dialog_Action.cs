using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Dialog_Action : Game_Action {

	[SerializeField] protected Dialog_Message[] dialogMessages;

	public override void StartGameAction (AudioClip clip)
	{
		Dialog_Manager.instance.StartDialog (dialogMessages);
		this.gameObject.SetActive (false);
	}
}
