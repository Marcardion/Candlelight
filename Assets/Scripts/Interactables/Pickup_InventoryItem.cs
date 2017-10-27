using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_InventoryItem : Game_Action {

	[Header("Item Identification")]
	[SerializeField] private string itemID;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetString (itemID, "false") != "false") 
		{
			this.gameObject.SetActive (false);
		}

	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void StartGameAction (AudioClip clip)
	{
		//TODO:Colocar Fade do item
		SoundManager.instance.PlaySingle(clip,0);
		Inventory_Manager.instance.ActivateItem(itemID);
		PlayerPrefs.SetString (itemID, "true");
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
		Text_Box_Controller.instance.SetInactive ();
		this.gameObject.SetActive (false);
	}
}
