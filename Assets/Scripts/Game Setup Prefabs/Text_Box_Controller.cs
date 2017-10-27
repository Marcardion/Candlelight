using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Box_Controller : MonoBehaviour {

	public static Text_Box_Controller instance;

	private Animator myAnim;
	private Text myText;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		myAnim = GetComponent<Animator> ();
		myText = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetActive(string newText)
	{
		myText.text = newText;
		myAnim.SetBool ("Active", true);
	}

	public void SetInactive()
	{
		myAnim.SetBool ("Active", false);
	}

	public void ChangeFont(Font newFont)
	{
		myText.font = newFont;
	}

	public void ChangeColor(Color newColor)
	{
		myText.color = newColor;
	}
}
