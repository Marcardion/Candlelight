using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAnimationAction : Game_Action {

	[SerializeField] private Animator objAnimator;
	[SerializeField] private string animTrigger;

	public override void StartGameAction (AudioClip clip)
	{
		objAnimator.SetTrigger (animTrigger);
	}
}
