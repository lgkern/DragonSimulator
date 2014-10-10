using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F1))
		{
			transform.position = target.position + new Vector3(0,20,10);
		}

		if(Input.GetKeyDown(KeyCode.F2))
		{
			transform.position = target.position + new Vector3(0,25,-25);
		}
	}
}
