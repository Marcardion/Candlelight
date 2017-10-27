using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetupCheck : MonoBehaviour {

	[SerializeField] private GameObject soundManager;

	// Use this for initialization
	void Start () {

		if (SoundManager.instance == null) 
		{
			Instantiate (soundManager);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
