using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour {
	public GameObject sheelExplosion;

	void OnCollisionEnter () {
		Instantiate (sheelExplosion, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
