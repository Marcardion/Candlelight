using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Manager : MonoBehaviour {

	public Action OnNextText;
	public Action OnEndText;

	public static Dialog_Manager instance;

	[SerializeField] private Font defaultFont;
	[SerializeField] private Color defaultColor;

	private bool IsDone = true;
	private bool input = false;

	private Dialog_Message[] activeMessages;
	private int activeMessagesIndex;
	private int activeTextIndex;

	void Awake ()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (IsDone == false) 
		{
			HandleDialog ();
		}
		
	}

	public void StartDialog(Dialog_Message[] messages)
	{
		Player_Manager.instance.SetPlayerInactive ();
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		activeMessages = messages;
		IsDone = false;
		activeMessagesIndex = 0;
		activeTextIndex = 0;
		PrepareMessage (activeMessages [activeMessagesIndex]);
	}

	void PrepareMessage(Dialog_Message dialogMessage)
	{
		Font tempFont;
		Color tempColor;
		Color nullColor = new Color (0, 0, 0, 0);

		if (dialogMessage.textFont != null) {
			tempFont = dialogMessage.textFont;
		} else {
			tempFont = defaultFont;
		}

		if (dialogMessage.textColor != nullColor) {
			tempColor = dialogMessage.textColor;
		} else {
			tempColor = defaultColor;
		}

		StartCoroutine (LoadMessage (dialogMessage.messages[activeTextIndex], tempColor, tempFont));
	}

	IEnumerator LoadMessage(string nText, Color nColor, Font nFont)
	{
		if (OnNextText != null) 
		{
			OnNextText ();
		}
		input = false;
		Text_Box_Controller.instance.SetInactive ();
		yield return new WaitForSeconds (0.5f);

		Text_Box_Controller.instance.ChangeColor (nColor);
		Text_Box_Controller.instance.ChangeFont (nFont);
		Text_Box_Controller.instance.SetActive (nText);
	
		yield return new WaitForSeconds (0.5f);
		input = true;
	}

	void HandleDialog()
	{
			if (input && Input.GetMouseButtonDown (0)) 
			{
				activeTextIndex++;
				if (activeTextIndex >= activeMessages [activeMessagesIndex].messages.Length) 
				{
					activeMessagesIndex++;
					activeTextIndex = 0;
				}
				if (activeMessagesIndex >= activeMessages.Length) {
				IsDone = true;
				StartCoroutine (ResetTextBox ());

				} else {
				PrepareMessage (activeMessages [activeMessagesIndex]);
				}
				
			}
	}

	IEnumerator ResetTextBox()
	{
		if (OnEndText != null) 
		{
			OnEndText ();
		}
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		Text_Box_Controller.instance.SetInactive ();
		yield return new WaitForSeconds (0.4f);

		Text_Box_Controller.instance.ChangeColor (defaultColor);
		Text_Box_Controller.instance.ChangeFont (defaultFont);
		Player_Manager.instance.SetPlayerActive ();
	}
}
