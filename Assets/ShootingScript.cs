using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
	public Rigidbody projectile;
	public float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * speed);

			Destroy(clone.gameObject, 3);
		}
	}
}
