using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This calss handles the health of the player and updates the GUI accordingly
public class Health : MonoBehaviour 
{	
	private int currentHealth; // The current health value

	public Slider healthSlider; // A reference to the 2D GUI Slider 

	public int damageTaken; // The value that each enemy inflicts

	// Use this for initialization
	void Start () 
	{
		currentHealth = 100; //We initialize the health value in 100
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision)
	{
		// Remove the damage from the current health variable
		currentHealth = currentHealth - damageTaken; 

		//Visually update the health slider
		healthSlider.value = currentHealth;

		//Check if the player has life remaining
		if (currentHealth <= 0 )
		{
			//Game Over Code
			Debug.Log("GAME OVER, YOU LOST!");
		}
	}
}
