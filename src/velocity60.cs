using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move : MonoBehaviour {

	//try with 10, 15, 8
	private float seconds = 10;                       //10s to pass the whole lenght of the street
	public float start_time;                          //the time that the car starts moving
	public Vector3 start_point;                       //the first coordinates of the car
	public Vector3 final_point;                       //the final coordinates of the car
	public Vector3 difference;
	public float percent;
	public float elapsed_time;
	public GameObject car;
	
	//ShowAndHide = A function to display the car at the moment of the pressing the button
	//two input variables, the game object (go) and the delay time (delay)
	//the moment that user presses the button, the content of the SetActive command 
	//chages into true and the car displays
	//after a little delay, the car disappears again by changing the value of SetActive to false
//	IEnumerator ShowAndHide( GameObject go, float delay )   
//	{
//		go.SetActive(true);                                 
//		yield return new WaitForSeconds(delay);
//		go.SetActive(false);
//	}
	
	// Use this for initialization
	void Start () 
	{
		start_point = new Vector3 (42, 71, 0);         //the first coordinates of the car
		final_point = new Vector3 (42, 71, 600);       //the final coordinates of the car
		difference = final_point-start_point;          //shows the lenght of the street
		start_time = Time.time;                        //shows the time that the car starts moving
	}
	
	// Update is called once per frame
	void Update () 
	{
		elapsed_time = Time.time - start_time ;        //shows the time that has passed since the car starts moving
		if (elapsed_time <= seconds) 
		{
			//percent is a 0-1 float ,showing the percentage of time that has passed
			percent = elapsed_time / seconds;  
			//multiply the percentage to the difference of our two positions
			//and add to the start
			transform.position = start_point + difference * percent; 	                                                         
		}

		//try with 3, 4, 2
		if (elapsed_time >= 3.0f)                         //to disappear the car after 4s
		{
			car.SetActive(false);                      //using the SetActive(false) command to disappear the car
//			if (Input.GetKeyDown(KeyCode.A))           //getting input from user to show the car and the result
//			{	
//				ShowAndHide(car,0.5f);                 //introduced at the begining of the script (go = car, delay = 0.5s)
//				print("user pressed the key:" + elapsed_time);     //printing the measured time on the screen
//				print("AAA");
//				
//			}
		}
		//write the if statement in another script which is related to a stable obj
		//then link the scripts
		//if (Input.GetKey("space"))                   //another type of using GetKey command
		//{	
		//ShowAndHide(car,0.5f);
		//Debug.Log("user pressed the key:" + elapsed );
		
		//}
	}
}