using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour {
	public GameObject sheelExplosion;
	public float radius;
	public float explosionForce;
    public int attack;

	void OnCollisionEnter () {
		GameObject instant = Instantiate (sheelExplosion, transform.position, transform.rotation) as GameObject;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
		int l = colliders.Length;
        Debug.Log(l);
        for (int i = 0; i < l; i++)
        {
            Rigidbody r = colliders[i].GetComponent<Rigidbody>();
            if (r != null)
            {
                r.AddExplosionForce(explosionForce, transform.position, radius);
            }
            unityClass tank = colliders[i].GetComponent<unityClass>();
            if (tank != null)
            {
                Debug.Log("attack");
                tank.Status(attack);
            }
        }
		Destroy(gameObject);
		Destroy (instant, (float)1.5 );
	}
}
