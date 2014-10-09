using UnityEngine;
using System.Collections;

public class MoveYieldScript : MonoBehaviour {

	// När man skriver public, ser man i editorn här (type ahead) vilka andra skript som finns publika
	// skriv bara publik på en egen rad, så ser du listan.
	public MoveYieldScriptCube cubescript; // den här används inte all i detta projekt.

	// Use this for initialization
	void Start () 
	{
		StartCoroutine("moveShpere");
	}

	
	// Yield coroutine
	private IEnumerator moveShpere()
	{
		float speed = 10.0f;

/*		if (cube != null) 
		{
			cubescript.StartCoroutine("publicMoveCube");
		}*/

		// Vi  har lagt moveCube skriptet här i stället för i MoveYieldSctiptCube.cs
		yield return StartCoroutine("moveCube");

		for (int i=0; i<=25; i++)
		{
			float distance = speed * (float )Time.deltaTime * 2.0f; // Input.GetAxis("Horizontal");
			
			transform.Translate(Vector3.right * distance);
			
			yield return null; 
		}
	}

	// Vi  har lagt moveCube skriptet här i stället för i MoveYieldSctiptCube.cs
	// Att köra moveCube i MoveYieldSctiptCube från detta skript var lite svårare.
	// Går igenom dom stegen senare.
	// Yield coroutine
	private IEnumerator moveCube()
	{
		float speed = 10.0f;
		
		GameObject box2; 
		
		box2 = GameObject.Find("Cube");
		
		for (int i=0; i<=50; i++)
		{
			float distance = speed * (float) Time.deltaTime * 0.2f;
			
			box2.transform.Translate(Vector3.up * distance);
	
			
			yield return null; 
		}
	}


	
	// Update is called once per frame
	void Update () {

	}


}
