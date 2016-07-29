using UnityEngine;
using System.Collections;

public class urubuzinho : MonoBehaviour
{
    public Transform tiro;
	public GameObject spawntirodois;
	public int vidas = 3;
	public bool lastDirection = true; // true se esquerda
	public  static int score;
	public static int Tirosdisponiveis;
	public int tirosmaximos = 5;
	public Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D> ();
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded.grounded == true)
        {
			rb.AddForce(Vector2.up * 250f);
			//transform.Translate(new Vector2(0, 0.2f));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && lastDirection == true)
        {
			transform.Rotate(new Vector3(0,-180,0));
            //transform.Translate(new Vector2(0.2f, 0));
			lastDirection = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && lastDirection == false)
        {
			transform.Rotate(new Vector3(0,180,0));
            //transform.Translate(new Vector2(-0.2f, 0));
			lastDirection = true;
        }

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(new Vector2(0.2f, 0));
		}


        if (Input.GetKeyDown(KeyCode.Keypad0) && Tirosdisponiveis >= 1)
        {
			Transform newTiro;
			newTiro = Instantiate(tiro, spawntirodois.transform.position , tiro.transform.localRotation) as Transform;
			newTiro.GetComponent<direcaotiro>().shotTo = lastDirection;
			Tirosdisponiveis --;
			//Debug.Log(newTiro.transform.name);
		}
		//Debug.Log (lastDirection);
    }

	void OnCollisionEnter2D(Collision2D coll)
	{
		
		if (coll.gameObject.tag == "verde") {
			picaPa.score ++;
			Debug.Log("picapa score: " + picaPa.score);
		} else {
			//Debug.Log ("acerot");
		}
		/*if (vidas == 0)
			Destroy (this.gameObject);*/
	}
}