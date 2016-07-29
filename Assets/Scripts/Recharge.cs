using UnityEngine;
using System.Collections;

public class Recharge : MonoBehaviour {

	public float time;

	// Use this for initialization
	void Start () {
		time = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter2D(Collider2D coll){
		time = 0;
	}
	void OnTriggerStay2D(Collider2D coll){
		if (time >= 5 && gameObject.tag == ("urubuzinho"))
		{
			urubuzinho.Tirosdisponiveis ++;
			time = 0;
		}
		if (time >= 5 && gameObject.tag == ("picapa")) {
			picaPa.Tirosdisponiveis ++;
			time = 0;
		}
	}
	/*void OnTriggerExit2D(Collider2D coll){

	}
*/
}
