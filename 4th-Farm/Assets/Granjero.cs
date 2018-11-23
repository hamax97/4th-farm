using UnityEngine;
using System.Collections;

public class Granjero : MonoBehaviour {
	
	private float movX; 
	private float movZ;
	private BoxCollider alien1;

	// Use this for initialization
	void Start () {
		alien1 = GameObject.Find("Alien1").GetComponent<BoxCollider> ();
	}

	void OnTriggerEnter(Collider other) {
		if (alien1 != null && other == alien1) {
			Destroy (other.gameObject);
			return;
		}
		this.GetComponent<BoxCollider> ().isTrigger = false;
	}

    void OnTriggerExit (Collider other) {	
		this.GetComponent<BoxCollider> ().isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		movX = Input.GetAxis("Horizontal")*0.1f;
		movZ = Input.GetAxis("Vertical")*0.1f;
		this.transform.Translate(movX, 0, movZ,Space.Self);
	}
}
