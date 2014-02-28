using UnityEngine;
using System.Collections;

public class ButtonManeger : MonoBehaviour
{
		public Texture TexNormal;
		public Texture TexDown;
		
		void OnMouseEnter()
	{
	guiTexture.color = new Color (0.8f, 0.8f, 0.8f, 1);	
	}	
		void OnMouseExit()
	{
	guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 1);	
	}
	
	void OnMouseDown()
	{
		guiTexture.texture = TexDown;
	}
	
	void OnMouseUp()
	{
		guiTexture.texture = TexNormal;
	}
}
