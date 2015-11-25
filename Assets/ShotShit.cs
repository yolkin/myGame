using UnityEngine;
using System.Collections;

public class ShotShit : MonoBehaviour {

	public float shitSpeed = 15;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += transform.forward * shitSpeed * Time.deltaTime;
	}
}
