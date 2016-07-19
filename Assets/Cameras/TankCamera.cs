using UnityEngine;
using System.Collections;

public class TankCamera : MonoBehaviour {

    public Transform target;
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = target.position;
	}
}
