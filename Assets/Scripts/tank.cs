using UnityEngine;
using System.Collections;

public class tank : unityClass {

    public float movespeed, rotatespeed;
	
	void Update () {

		float horizontal = Input.GetAxis ("Horizontal1");
		float vertical = Input.GetAxis ("Vertical1");
		transform.Translate (new Vector3 (0, 0, 1) * movespeed * Time.deltaTime * vertical);
		transform.Rotate (new Vector3 (0, 1, 0) * rotatespeed * Time.deltaTime * horizontal);
		/*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * rotatespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * rotatespeed * Time.deltaTime);
        }
        */
	}
}
