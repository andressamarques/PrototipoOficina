using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {

	public static bool grounded = false;

	void OnTriggerEnter2D(Collider2D coll){
		grounded = true;
	}
	void OnTriggerStay2D(Collider2D coll){
		grounded = true;
	}
	void OnTriggerExit2D(Collider2D coll){
		grounded = false;
	}
}
