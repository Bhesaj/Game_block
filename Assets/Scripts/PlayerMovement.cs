using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public GameObject deathParticles;
	private float maxSpeed =5f;

	private Vector3 input;

	private Vector3 spawn;

	public AudioSource Death;

	// Use this for initialization
	void Start () {
		spawn = transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed) 
		{
			GetComponent<Rigidbody> ().AddRelativeForce (input*moveSpeed);
		}

		if (transform.position.y < -20) {
			die ();
		}

	}

	void OnTriggerStay(Collider other)
	{
		if (other.transform.tag == "Ogre") 
		{
			die ();
			Death.Play ();

		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal") {
			GameManager.CompleteLevel ();
		}
	}

	void die(){
		Instantiate (deathParticles, transform.position, Quaternion.identity);
		transform.position = spawn;
	}
}
