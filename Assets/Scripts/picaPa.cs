using UnityEngine;
using System.Collections;

public class picaPa : MonoBehaviour 
{
	public Transform tiro;
	public GameObject spawntiroum;
	public int vidas = 3;
	public bool lastDirection = true; // true se esquerda
	public static int score;
	public static int Tirosdisponiveis = 3;
	public int tirosmaximos = 5;
	public Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W) && Grounded.grounded == true)
		{
			rb.AddForce(Vector2.up * 250f);
			//transform.Translate(new Vector2(0, 0.2f));
		}
		
		if (Input.GetKeyDown(KeyCode.A) && lastDirection == true)
		{
			transform.Rotate(new Vector3(0,-180,0));
			//transform.Translate(new Vector2(0.2f, 0));
			lastDirection = false;
		}
		
		if (Input.GetKeyDown(KeyCode.D) && lastDirection == false)
		{
			transform.Rotate(new Vector3(0,180,0));
			//transform.Translate(new Vector2(-0.2f, 0));
			lastDirection = true;
		}
		
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) 
		{
			transform.Translate(new Vector2(0.2f, 0));
		}
		

		if (Input.GetKeyDown(KeyCode.Space) && Tirosdisponiveis >= 1)
		{
			Transform newTiro;
			newTiro = Instantiate(tiro, spawntiroum.transform.position , tiro.transform.localRotation) as Transform;
			newTiro.GetComponent<direcaotiro>().shotTo = lastDirection;
			//Debug.Log(newTiro.transform.name);
			Tirosdisponiveis--;
		}
		//Debug.Log (lastDirection);
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		
		if (coll.gameObject.tag == "branca") {
			urubuzinho.score ++;
			Debug.Log("urubuzinho score: " + urubuzinho.score);
			//Destroy(this.gameObject);
		} else {
			//Debug.Log ("acerot");
		}
		/*if (vidas == 0)
			Destroy (this.gameObject);*/
	} 
}