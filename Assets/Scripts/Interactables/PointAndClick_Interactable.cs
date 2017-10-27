using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick_Interactable : MonoBehaviour {

	public Action OnEnter;
	public Action OnOver;
	public Action OnExit;
	public Action OnClick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter()
	{
		if (OnEnter != null)
		{
			OnEnter ();
		}
	}

	void OnMouseOver()
	{
		if (OnOver != null)
		{
			OnOver ();
		}
	}

	void OnMouseExit()
	{
		if (OnExit != null)
		{
			OnExit ();
		}
	}

	void OnMouseDown()
	{
		if (OnClick != null)
		{
			OnClick ();
		}
	}
}
