using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory_Item : Use_Interaction {

	[Header("Item Identification")]
	[SerializeField] private string itemID;

	[Header("Scene to Use")]
	[SerializeField] private string useSceneName;


	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetString (itemID, "false") == "false") 
		{
			DeactivateMe ();
		}
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void HandleClick ()
	{
		if (Player_Manager.instance.GetPlayerActive ()) {
			if (SceneManager.GetActiveScene ().name == useSceneName) {
				CallActions ();
			} else 
			{
				Text_Box_Controller.instance.SetActive ("Não é o momento certo para utilizar isso.");
			}
		}
	}

	public override void ActionDisabled ()
	{
		Text_Box_Controller.instance.SetActive ("Não é o momento certo para utilizar isso.");
	}


	public string GetID()
	{
		return itemID;
	}

	public void ActivateMe()
	{
		GetComponent<Collider2D> ().enabled = true;
		GetComponent<Image> ().enabled = true;
	}

	public void DeactivateMe()
	{
		GetComponent<Collider2D> ().enabled = false;
		GetComponent<Image> ().enabled = false;
	}
}
