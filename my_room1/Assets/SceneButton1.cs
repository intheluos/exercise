using UnityEngine;
using System.Collections;

public class SceneButton1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI(){
		if (GUI.Button(new Rect(10,10,100,40), "Return")){
			
			Application.LoadLevel("1");
		
		}
	}		
	
	// Update is called once per frame
	void Update () {
	
	}
}
