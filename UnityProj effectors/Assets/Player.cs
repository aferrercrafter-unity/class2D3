using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			rb.AddForce (Vector2.up * 10, ForceMode2D.Impulse);
		}
	}
}
