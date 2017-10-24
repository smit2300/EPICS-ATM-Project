﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PIN7 : MonoBehaviour
{
	[SerializeField]
	private Text show7 = null;

	public string num7Print = "7";

	public static bool pressed7;

	public Collider buttonCollider = null;

	public Collider indexTip = null;

	public static bool buttonIsPressed = false;

	public static bool numButtonPressed = false;

	public Collider trigger0 = null;
	public Collider trigger1 = null;
	public Collider trigger2 = null;
	public Collider trigger3 = null;
	public Collider trigger4 = null;
	public Collider trigger5 = null;
	public Collider trigger6 = null;
	public Collider trigger7 = null;
	public Collider trigger8 = null;
	public Collider trigger9 = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider) //Button Pushed????
	{
		numButtonPressed = true;

		Debug.Log (buttonIsPressed);
		if (buttonIsPressed == false) 
		{
			//if (isColliding)
			//return;
			isColliding = true;
			buttonIsPressed = true;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (7.8f, 1);
			//audio.pitch = Random.Range (7.8f, 1.1f);
			audio.Play ();

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;

			//Debug.Log ("7 Button Pushed");

			pressed7 = true;

			//Debug.Log (pressed7);

			if (pressed7 == true) {
				int num7Input = 7;

				show7.text += num7Print;

				//Debug.Log (num7Input);
				//Debug.Log (num7Print);
			}

			buttonIsPressed = false;
			StartCoroutine (disableButton ());
			return;
		}
		else
		{
			return;
		}
	}

	void OnTriggerExit(Collider collider)
	{
		isColliding = false;
		buttonIsPressed = false;
		Debug.Log ("buttonIsPressed:" + buttonIsPressed);
		pressed7 = false;
		return;
	}

	IEnumerator disableButton ()
	{
		trigger0.enabled = false;
		trigger1.enabled = false;
		trigger2.enabled = false;
		trigger3.enabled = false;
		trigger4.enabled = false;
		trigger5.enabled = false;
		trigger6.enabled = false;
		trigger7.enabled = false;
		trigger8.enabled = false;
		trigger9.enabled = false;

		trigger0.isTrigger = false;
		trigger1.isTrigger = false;
		trigger2.isTrigger = false;
		trigger3.isTrigger = false;
		trigger4.isTrigger = false;
		trigger5.isTrigger = false;
		trigger6.isTrigger = false;
		trigger7.isTrigger = false;
		trigger8.isTrigger = false;
		trigger9.isTrigger = false;

		yield return new WaitForSeconds (3);

		trigger0.enabled = true;
		trigger1.enabled = true;
		trigger2.enabled = true;
		trigger3.enabled = true;
		trigger4.enabled = true;
		trigger5.enabled = true;
		trigger6.enabled = true;
		trigger7.enabled = true;
		trigger8.enabled = true;
		trigger9.enabled = true;

		trigger0.isTrigger = true;
		trigger1.isTrigger = true;
		trigger2.isTrigger = true;
		trigger3.isTrigger = true;
		trigger4.isTrigger = true;
		trigger5.isTrigger = true;
		trigger6.isTrigger = true;
		trigger7.isTrigger = true;
		trigger8.isTrigger = true;
		trigger9.isTrigger = true;
	}
}


