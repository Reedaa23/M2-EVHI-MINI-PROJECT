using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoor : MonoBehaviour
//==========================================================================
//Proximity sensor : when the mouse hovers over the GameObject, it turns to this color (red)
{
	private Color m_MouseOverColor = Color.red;
	//This stores the GameObject’s original color
	private Color m_OriginalColor;
	//Get the GameObject’s mesh renderer to access the GameObject’s material and color
	private MeshRenderer m_Renderer;
	// Hinge of the door
	public GameObject hinge_of_door;
	// The door
	public GameObject door;

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

	//Open and close the door
	void OnMouseDown()
	{
		if (hinge_of_door.transform.rotation.eulerAngles.y == 0)
			{
				hinge_of_door.transform.Rotate(0,90,0);
				door.GetComponent<Renderer>().material.color = Color.green;
			}
			else
			{
				hinge_of_door.transform.Rotate(0,-90,0);
				door.GetComponent<Renderer>().material.color = Color.blue;
			}
	}

}