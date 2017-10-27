using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameSceneAction : Game_Action {

	[SerializeField] private string sceneName;

	public override void StartGameAction (AudioClip clip)
	{
		LoadNextScene ();
	}

	void LoadNextScene()
	{
		Player_Manager.instance.SetPlayerInactive ();
		Fade_Controller.instance.FadeOut ();
		Fade_Controller.instance.OnFadeOut += LoadScene;
	}

	void LoadScene()
	{
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		SceneManager.LoadScene (sceneName);
	}
}
