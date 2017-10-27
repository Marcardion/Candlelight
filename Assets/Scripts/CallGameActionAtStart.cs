using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallGameActionAtStart : MonoBehaviour {

	[SerializeField] private Game_Action[] gameActions;

	[SerializeField] private Fade_Controller fadeControl;

	void OnEnable()
	{
		fadeControl.OnFadeIn += StartAction;
	}

	void OnDisable()
	{
		fadeControl.OnFadeIn -= StartAction;
	}

	public void StartAction()
	{
		StartCoroutine (CallAction ());
	}

	IEnumerator CallAction()
	{
		yield return new WaitForEndOfFrame ();
		CallActions ();
	}

	void CallActions()
	{
		foreach (Game_Action action in gameActions) 
		{
			if (action.gameObject.activeInHierarchy) {
				action.StartGameAction (null);
			}
		}
	}
}
