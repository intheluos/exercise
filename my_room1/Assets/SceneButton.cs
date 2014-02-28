using UnityEngine;
using System.Collections;

public class SceneButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI(){
		if (GUI.Button(new Rect(10,10,100,40), "Change")){
		
			Application.LoadLevel("3");
	}
	
}
	// Update is called once per frame
	void Update () {
	
	}
}
