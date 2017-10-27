using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAction : Game_Action {

	[SerializeField] AudioClip soundclip;
	[SerializeField] int audioChannel = 0;

	public override void StartGameAction (AudioClip clip)
	{
		SoundManager.instance.PlaySingle (soundclip, audioChannel);
	}
}
