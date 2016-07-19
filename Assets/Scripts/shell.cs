using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour {
	public GameObject sheelExplosion;
	public float radius;
	public float explosionForce;

	void OnCollisionEnter () {
		GameObject instant = Instantiate (sheelExplosion, transform.position, transform.rotation) as GameObject;
		Collider[] colliders = Physics.OverlapSphere (transform.position, radius);
		int l = colliders.Length;
		for (int i = 0; i < l; i++) {
			Rigidbody r = colliders [i].GetComponent<Rigidbody>();
			if (r != null) {
				r.AddExplosionForce (explosionForce, transform.position, radius);
			}
		}

		Destroy(gameObject);
		Destroy (instant, (float)1.5 );
	}
}
