using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Manager : MonoBehaviour {

	public static Inventory_Manager instance;

	[Header("Inventory Items")]
	[SerializeField] private Inventory_Item[] items;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActivateItem (string itemID)
	{
		int i = 0;

		for (i = 0; i < items.Length; i++) 
		{
			if (items [i].GetID () == itemID) 
			{
				items [i].ActivateMe ();
				break;
			}
		
		}
	}
}
