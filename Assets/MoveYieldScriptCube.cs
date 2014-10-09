using UnityEngine;
using System.Collections;

public class MoveYieldScriptCube : MonoBehaviour {

	// Use this for initialization, överflödig funktion - ta bort.
	void Start () 
	{
	
	}

	// publicMoveCube() funktionen fick vi lägga till mellan gameobjektens skript, då: 
	// coroutiner är privata och inte publika. 
	// så denna extar funktion är publik åt coroutinen.
	// Så den syns utefrån av andra gameobjects skripts.
	// andra gameobjekts skript.
	// Dock krävs det att dom andra gameobjektens script har 
	// "public MoveYieldScriptCube valfrittnamn;" i det andra gameobjektes skript,
	// annars syns det inte.

	public void publicMoveCube()  
	{
		StartCoroutine("moveCube");
	}

	// moveCube här används inte just nu. Utan är flyttad till MoveYieldScript.cs
	// Används den så rör sig kuben åt andra hållet... (la till ett minus tecken här)
	// Yield coroutine
	private IEnumerator moveCube()
	{
		float speed = 10.0f;
		
		for (int i=0; i<=50; i++)
		{
			float distance = speed * (float) Time.deltaTime * -0.2f; // -2.0f; var 2.0f;

			transform.Translate(Vector3.up * distance);
			
			yield return null; 
		}
	}
	
	// Update is called once per frame, överflödig funktion - ta bort.
	void Update () {
	
	}
}
