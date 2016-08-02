using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	
		rb2D.AddForce(new Vector2(100,0));
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(rb2D.velocity);
	
	}
}
