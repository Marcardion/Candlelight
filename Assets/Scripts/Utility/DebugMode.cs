using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour {

	[Header("Inventory")]
	[SerializeField] private bool debugInventory;
	[SerializeField] private string[] itemIDs;
	[SerializeField] private bool[] itemMode;

	[Header("GameKeys")]
	[SerializeField] private bool debugGameKeys;
	[SerializeField] private string[] gameKeys;
	[SerializeField] private int[] keysValues;

	void Awake()
	{
		if (debugInventory) 
		{
			Debug.Log ("Debug Inventory is Active");
			StartDebugInventory ();
		}

		if (debugGameKeys) 
		{
			Debug.Log ("Debug Game Keys is Active");
			StartDebugGameKeys ();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void StartDebugInventory()
	{
		int i = 0;
		for (i = 0; i < itemIDs.Length; i++) 
		{
			if (itemMode [i]) {
				PlayerPrefs.SetString (itemIDs [i], "true");
			} else 
			{
				PlayerPrefs.DeleteKey (itemIDs [i]);
			}
		}
	}

	void StartDebugGameKeys()
	{
		int i = 0;
		for (i = 0; i < gameKeys.Length; i++) 
		{
			PlayerPrefs.SetInt(gameKeys[i],keysValues[i]);
		}
	}
}
