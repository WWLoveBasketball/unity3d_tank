using UnityEngine;
using System.Collections;

public class tankweapon : MonoBehaviour {

    public GameObject shell;
    public float shootpower;
    public Transform shootpoint;
	private AudioSource shootAudio;
	void Start() {
		shootAudio = GetComponent<AudioSource> ();
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            shoot();
        }
	}

    void shoot() {
        GameObject newsheel = Instantiate(shell, shootpoint.position, shootpoint.rotation) as GameObject;
        Rigidbody r = newsheel.GetComponent<Rigidbody>();
        r.velocity = shootpoint.forward * shootpower;
		shootAudio.Play ();
    }
}
