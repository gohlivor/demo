using UnityEngine;
using System.Collections;

public class viewscript : MonoBehaviour {

	GameObject[] ourObjects;
	Light theLight;
	bool hiddenChanged = false;
	int currentObject = 0;

	// Use this for initialization
	void Start () {
		ourObjects = new GameObject[3];
		ourObjects [0] = GameObject.Find ("theBox");
		ourObjects [1] = GameObject.Find ("theSphere");
		ourObjects [2] = GameObject.Find ("theCylinder");
	}
	
	// Update is called once per frame
	void Update () {
		//Check if our current object is visible.
		if (!ourObjects [currentObject].renderer.isVisible && !hiddenChanged) {
			hiddenChanged = true;
			Debug.Log ("changing object");
			currentObject += 1;
			if (currentObject == 3) {
					currentObject = 0;
			}

			for (int i = 0; i < 3; i++)
			{
				if (i == currentObject)
				{
					ourObjects[i].renderer.enabled = true;
				}
				else
				{
					ourObjects[i].renderer.enabled = false;
				}
			}
		} else if (ourObjects [currentObject].renderer.isVisible ) {
			hiddenChanged = false;
		}

		
	}
}
