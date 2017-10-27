using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallGameActionAfterDialog : Game_Action {

	[SerializeField] private Game_Action[] gameActions;

	public override void StartGameAction (AudioClip clip)
	{
		Dialog_Manager.instance.OnEndText += CallActions;
	}

	public void CallActions()
	{
		Dialog_Manager.instance.OnEndText -= CallActions;

		foreach (Game_Action action in gameActions) 
		{
			if (action.gameObject.activeInHierarchy) {
				action.StartGameAction (null);
			}
		}
	}
}
