using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use_Interaction : Interactable_Object {

	[Header("Use Action")]
	[SerializeField] protected Game_Action[] actions;

	public override void HandleClick ()
	{
		if (Player_Manager.instance.GetPlayerActive ()) {
			if (soundClip != null) 
			{
				SoundManager.instance.PlaySingle (soundClip, 0);
			}
			CallActions ();
		}
	}

	public void CallActions()
	{
		foreach (Game_Action action in actions) 
		{
			
			if (action.gameObject.activeInHierarchy) {
				if (soundClip != null) 
				{
					SoundManager.instance.PlaySingle (soundClip, 0);
				}
				action.StartGameAction (soundClip);
			} else 
			{
				ActionDisabled ();
			}
		}
	}

	public virtual void ActionDisabled()
	{
		
	}
}
