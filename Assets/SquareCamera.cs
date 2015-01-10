using UnityEngine;
using System.Collections;

public class SquareCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Upon loading all assets, use this to adjust the width of the camera.
	void Awake(){
	
        Vector2 screenRes = new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight);
		float planeScale = 30.0f;
		MeshFilter plane = GetComponent(typeof(MeshFilter)) as MeshFilter;

		Vector3 v3 = plane.transform.localScale;
		Debug.Log("Image screen size: " + v3.x  + " x " + v3.y); 



	}

	// Update is called once per frame
	void Update () {
	
	}
}
