using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour {

	public Transform Sphere;
	public int TargetNumber = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (TargetNumber <= 15) {
			TargetNumber++;
			Vector3 randVec = new Vector3 (Random.Range (-20, 20), 0, Random.Range (-20, 20));
			Instantiate (Sphere, randVec, new Quaternion (0, 0, 0, 0));
		}
	}
}
