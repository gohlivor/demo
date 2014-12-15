using UnityEngine;
using System.Collections;

public class viewscript2 : MonoBehaviour {

	GameObject[] ourObjects;
	Light theLight;
	bool hiddenChanged = false;
	int currentObject = 0;
	
	// Use this for initialization
	void Start () {
		ourObjects = new GameObject[2];
		ourObjects [0] = GameObject.Find ("thisHedge");
		ourObjects [1] = GameObject.Find ("thisArch");
	}
	
	// Update is called once per frame
	void Update () {
		//Check if our current object is visible.
		if (!ourObjects [currentObject].renderer.isVisible && !hiddenChanged) {
			hiddenChanged = true;
			Debug.Log ("changing object");
			currentObject += 1;
			if (currentObject == 2) {
				currentObject = 0;
			}
			
			for (int i = 0; i < 2; i++)
			{
				if (i == currentObject)
				{
					ourObjects[i].renderer.enabled = true;

				}
				else
				{
					ourObjects[i].renderer.enabled = false;
					//GameObject.Destroy(ourObjects[0],2f);
				}
			}


		} else if (ourObjects [currentObject].renderer.isVisible ) {
			hiddenChanged = false;

		}
	}
}