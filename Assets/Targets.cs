using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour {

	public Transform SphereNadal;
	public Transform SphereDjokovic;
	public int TargetNumber = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (TargetNumber < 15) {
			TargetNumber++;
			Vector3 randVec = new Vector3 (Random.Range (-10, 10), 0, Random.Range (-10, 10));
			Instantiate (SphereNadal, randVec, new Quaternion (0, 0, 0, 0));
		}
		if (TargetNumber < 15) {
			TargetNumber++;
			Vector3 randVec = new Vector3 (Random.Range (-10, 10), 0, Random.Range (-10, 10));
			Instantiate (SphereDjokovic, randVec, new Quaternion (0, 0, 0, 0));
		}
	}
}
