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
		if (GetComponent<Collider2D> ().enabled) {
			if (OnEnter != null) {
				OnEnter ();
			}
		}
	}

	void OnMouseOver()
	{
		if (GetComponent<Collider2D> ().enabled) {
			if (OnOver != null) {
				OnOver ();
			}
		}
	}

	void OnMouseExit()
	{
		if (GetComponent<Collider2D> ().enabled) {
			if (OnExit != null) {
				OnExit ();
			}
		}
	}

	void OnMouseDown()
	{
		if (GetComponent<Collider2D> ().enabled) {
			if (OnClick != null) {
				OnClick ();
			}
		}
	}
}
