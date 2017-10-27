using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Dialog_Action : Start_Dialog_Action {

	private bool active = false;

	[SerializeField] private Animator charAnim;

	public override void StartGameAction (AudioClip clip)
	{
		StartDialog ();
		Dialog_Manager.instance.OnNextText += NextDialog;
		Dialog_Manager.instance.OnEndText += EndDialog;
		Dialog_Manager.instance.StartDialog (dialogMessages);
	}

	public void NextDialog()
	{
		if (active) {
			charAnim.SetTrigger ("NextDialog");
		}
	}

	public void EndDialog()
	{
		if (active) {
			charAnim.SetBool ("IsTalking", false);
			active = false;
			Dialog_Manager.instance.OnNextText -= NextDialog;
			Dialog_Manager.instance.OnEndText -= EndDialog;
		}
	}

	public void StartDialog()
	{
		active = true;
		charAnim.SetBool ("IsTalking", true);
	}

}
