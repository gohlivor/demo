using UnityEngine;
using System.Collections;

public class viewscript2 : MonoBehaviour {

	public GameObject[] ourObjects;
	Light theLight;
	bool hiddenChanged = false;
	int currentObject = 0;
	
	// Use this for initialization
	void Start () {
		//ourObjects = new GameObject[2];
		//ourObjects [0] = GameObject.Find ("thisHedge");
		//ourObjects [1] = GameObject.Find ("thisArch");
	}
	
	// Update is called once per frame
	void Update () {
		//Check if our current object is visible.
		if (!ourObjects [currentObject].renderer.isVisible && !hiddenChanged) {
			hiddenChanged = true;
			Debug.Log ("changing object");
			currentObject += 1;
			if (currentObject == ourObjects.Length) {
				currentObject = 0; //sets back to zero when the last object in array size is viewed
			}
			
			for (int i = 0; i < ourObjects.Length; i++)
			{
				if (i == currentObject)
				{
					ourObjects[i].SetActive (true);
					//ourObjects[i].renderer.enabled = true;

				}
				else
				{
					ourObjects[i].SetActive (false); // disables game object and all of its subcomponents
					//ourObjects[i].renderer.enabled = false;
					//GameObject.Destroy(ourObjects[0],2f);
				}
			}


		} else if (ourObjects [currentObject].renderer.isVisible ) {
			hiddenChanged = false;

		}
	}
}