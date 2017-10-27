using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Controller : MonoBehaviour {

	public Action OnFadeIn;
	public Action OnFadeOut;

	private SpriteRenderer myRenderer;
	public static Fade_Controller instance;

	// Use this for initialization
	void Awake () {

		instance = this;
		myRenderer = GetComponent<SpriteRenderer> ();
		FadeIn ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FadeIn()
	{
		StartCoroutine (BlackFade (-1));
	}

	IEnumerator BlackFade(int mode)
	{
		//mode defines if it is a FadeIn(-1) (black to invisible) or a FadeOut (1) (invisible to black)
		Color color = Color.black;
		float alpha;

		if (mode < 0) 
		{
			alpha = 1;
			color.a = alpha;
			while (alpha > 0) 
			{
				myRenderer.color = color;
				alpha = alpha + (mode*Time.deltaTime);
				color.a = alpha;
				yield return new WaitForFixedUpdate ();
			}

			if (OnFadeIn != null) 
			{
				
				OnFadeIn ();
			}
		} else 
		{
			alpha = 0;
			color.a = alpha;
			while (alpha < 1) 
			{
				myRenderer.color = color;
				alpha = alpha + (mode*Time.deltaTime);
				color.a = alpha;
				yield return new WaitForFixedUpdate ();
			}

			if (OnFadeOut != null) 
			{
				OnFadeOut ();
			}	
		}

	}

	public void FadeOut()
	{
		StartCoroutine (BlackFade (1));
	}

}
