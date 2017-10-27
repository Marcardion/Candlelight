using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Interaction : Interactable_Object {
	[Header("Scene Data")]
	[SerializeField] private string sceneName;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void HandleClick ()
	{
		if (Player_Manager.instance.GetPlayerActive()) {
			Player_Manager.instance.SetPlayerInactive ();
			SoundManager.instance.PlaySingle (soundClip, 0);
			Fade_Controller.instance.FadeOut ();
			Fade_Controller.instance.OnFadeOut += LoadScene;
		}
	}

	void LoadScene()
	{
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		SceneManager.LoadScene (sceneName);
	}


}
