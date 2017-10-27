using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_Object : MonoBehaviour {

	[SerializeField] protected PointAndClick_Interactable interactableItem;

	[Header("Cursor")]
	[SerializeField] protected Texture2D cursorFrame1;
	[SerializeField] protected Texture2D cursorFrame2;

	[Header("Description")]
	[SerializeField] protected string description;

	[Header("Sound Clip")]
	[SerializeField] protected AudioClip soundClip;

	private bool isOver = false;

	void OnEnable()
	{
		interactableItem.OnEnter += HandleEnter;
		interactableItem.OnOver += HandleOver;
		interactableItem.OnExit += HandleExit;
		interactableItem.OnClick += HandleClick;

	}

	void OnDisable()
	{
		interactableItem.OnEnter -= HandleEnter;
		interactableItem.OnOver -= HandleOver;
		interactableItem.OnExit -= HandleExit;
		interactableItem.OnClick -= HandleClick;
	}

	public virtual void HandleEnter()
	{
		if (Player_Manager.instance.GetPlayerActive() && (GetComponent<Collider2D> ().enabled)) 
		{
			isOver = true;
			StartCoroutine (AnimateCursor ());
			Cursor.SetCursor (cursorFrame1, Vector2.zero, CursorMode.Auto);
			Text_Box_Controller.instance.SetActive (description);
		}
	}

	public virtual void HandleOver()
	{
		if (Player_Manager.instance.GetPlayerActive () && (GetComponent<Collider2D> ().enabled)) {
			if (isOver == false) {
				isOver = true;
				StartCoroutine (AnimateCursor ());
				Cursor.SetCursor (cursorFrame1, Vector2.zero, CursorMode.Auto);
				Text_Box_Controller.instance.SetActive (description);
			}
		} else 
		{
			isOver = false;
			Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		}
	}

	public virtual void HandleExit()
	{

		if (isOver) 
		{
			isOver = false;
			Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
			if (Player_Manager.instance.GetPlayerActive()) {
				Text_Box_Controller.instance.SetInactive ();
			}
		}

	}

	public virtual void HandleClick()
	{
		Debug.Log ("Click");
	}

	IEnumerator AnimateCursor()
	{
		while (isOver) 
		{
			Cursor.SetCursor (cursorFrame1, Vector2.zero, CursorMode.Auto);
			yield return new WaitForSeconds (0.5f);
			if (isOver == false) 
			{
				break;
			}
			Cursor.SetCursor (cursorFrame2, Vector2.zero, CursorMode.Auto);
			yield return new WaitForSeconds (0.5f);
		}
	}
}
