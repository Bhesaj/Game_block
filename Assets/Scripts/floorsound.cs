using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorsound : MonoBehaviour {

	public AudioSource Bump;

	void OnCollisionEnter(){
		Bump.Play ();
	}
}
