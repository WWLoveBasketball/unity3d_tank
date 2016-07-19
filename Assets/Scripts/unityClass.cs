using UnityEngine;
using System.Collections;

public class unityClass : MonoBehaviour {
	public int Health = 100;
	public GameObject ObjectDead;
	public void Status (int attack) {
		Health -= attack;
		if (Health <= 0) {
            Destroy(gameObject);
			Instantiate (ObjectDead, transform.position, transform.rotation);
		}
	}

}
