using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : Interactable_Object {

	[Header("Item Identification")]
	[SerializeField] private string itemID;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetString (itemID, "false") == "false") 
		{
			this.gameObject.SetActive (false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
