using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening2 : MonoBehaviour
//==========================================================================
//Proximity sensor : when the mouse hovers over the GameObject, it turns to this color (red)
{
	private Color m_MouseOverColor = Color.red;
	//This stores the GameObject’s original color
	private Color m_OriginalColor;
	//Get the GameObject’s mesh renderer to access the GameObject’s material and color
	private MeshRenderer m_Renderer;
	//The number of times the button has been clicked before the door closing
	private int clickingCount = -5;
	//Movement speed
	public float speed = 1;
	//The first door
	public GameObject door1;
	//The second door
	public GameObject door2;

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
			if(clickingCount == -5)
			{
				clickingCount = 0;
			}
			if (clickingCount == -1)
			{
				clickingCount = 1; 
			}
			clickingCount += 1;
		}
		if (clickingCount > 0 & clickingCount % 2 == 1)
		{
			//Debug.Log(door1.transform.position);
			door1.transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
			door2.transform.Translate(0, speed * Time.deltaTime, 0, Space.World);
			door1.GetComponent<Renderer>().material.color = Color.green;
			door2.GetComponent<Renderer>().material.color = Color.green;
			//Debug.Log(door1.transform.position);
		}
		else if (clickingCount > 0 & clickingCount % 2 == 0)
		{
			door1.transform.Translate(0, speed * Time.deltaTime, 0, Space.World);
			door2.transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
			door1.GetComponent<Renderer>().material.color = Color.green;
			door2.GetComponent<Renderer>().material.color = Color.green;
		}
		if (door1.transform.position.y <= 25 & clickingCount != -5)
		{
			clickingCount = -1;
			door1.GetComponent<Renderer>().material.color = Color.blue;
			door2.GetComponent<Renderer>().material.color = Color.blue;
		}
		else if (door1.transform.position.y >= 29.1 & clickingCount != -5)
		{
			clickingCount = 0;
			door1.GetComponent<Renderer>().material.color = Color.blue;
			door2.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}