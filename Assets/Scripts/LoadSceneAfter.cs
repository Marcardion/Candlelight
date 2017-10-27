using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfter : MonoBehaviour {

	//TODO: Colocar um enum para novos casos de uso para deixar o script mais reutilizavel

	[SerializeField] private string sceneName;

	void Start()
	{
		Dialog_Manager.instance.OnEndText += LoadNextScene;
	}

	void OnDisable()
	{
		Dialog_Manager.instance.OnEndText -= LoadNextScene;
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
