using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour {

	public static Player_Manager instance;

	[SerializeField] private bool playerActive = false;

	[SerializeField] private Fade_Controller fadeControl;

	// Use this for initialization
	void Awake () {

		instance = this;
	}

	void OnEnable()
	{
		fadeControl.OnFadeIn += SetPlayerActive;
	}

	void OnDisable()
	{
		fadeControl.OnFadeIn -= SetPlayerActive;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool GetPlayerActive()
	{
		return playerActive;
	}

	public void SetPlayerActive()
	{
		playerActive = true;
	}

	public void SetPlayerInactive()
	{
		playerActive = false;
	}
}
