using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningOnLight : MonoBehaviour
//==========================================================================
//Proximity sensor : when the mouse hovers over the GameObject, it turns to this color (red)
{
	private Color m_MouseOverColor = Color.red;
	//This stores the GameObject’s original color
	private Color m_OriginalColor;
	//Get the GameObject’s mesh renderer to access the GameObject’s material and color
	private MeshRenderer m_Renderer;
	//Light
	public Light roomLight;
    //Returns true if the button has been clicked
    public bool isClicked;

	void Start()
	{
		//Fetch the mesh renderer component from the GameObject
		m_Renderer = GetComponent<MeshRenderer>();
		//Fetch the original color of the GameObject
		m_OriginalColor = m_Renderer.material.color;
	}

	void OnMouseOver()
	{
		//Change the color of the GameObject to red when the mouse is over GameObject
		m_Renderer.material.color = m_MouseOverColor;
	}

	void OnMouseExit()
	{
		//Reset the color of the GameObject back to normal
		m_Renderer.material.color = m_OriginalColor;
	}

	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			isClicked = true;
		}

		if(isClicked)
		{
			roomLight.intensity = Mathf.Lerp(roomLight.intensity, 5.9f, 0.01f);
		}
	}

}