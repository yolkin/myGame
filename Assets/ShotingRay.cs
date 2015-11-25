using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ShotingRay : MonoBehaviour {

	public GameObject shit;
	public Rigidbody tennisBall;
	public Rigidbody tennisBallGravity;
	public AudioSource shot;
	public Text djokovic;
	public int djokovicScore = 0;
	public Text nadal;
	public int nadalScore = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1")) {
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			Physics.Raycast(ray, out hit);

			Debug.DrawRay(transform.position, transform.forward, Color.red, 3);


			if((hit.collider != null) && (hit.collider.tag == "Djokovic")) {
				GameObject ShitClone = (GameObject)Instantiate(shit, transform.position, transform.rotation);
				shot.Play();
				float distance = Vector3.Distance(hit.collider.transform.position, transform.position);
				Destroy(ShitClone, distance / 15);
				Destroy(hit.collider.gameObject, distance / 15);
				djokovicScore++;
				djokovic.text = "Djokovic: " + djokovicScore;
			}
	

			if((hit.collider != null) && (hit.collider.tag == "Nadal")) {
				GameObject tennisBallClone = (GameObject)Instantiate(tennisBall.gameObject, transform.position, transform.rotation);
				shot.Play ();
				float distance = Vector3.Distance(hit.collider.transform.position, transform.position);
				Destroy(tennisBallClone, distance / 15);
				Destroy(hit.collider.gameObject, distance / 15);
				nadalScore++;
				nadal.text = "Nadal: " + nadalScore;
			}

			if(!Physics.Raycast(ray, out hit)) {
				Rigidbody clone = Instantiate(tennisBallGravity, transform.position, transform.rotation) as Rigidbody;;
				clone.AddForce(transform.forward * 700);
				shot.Play();
				Destroy(clone.gameObject, 5);
			}
		}
	}
}
