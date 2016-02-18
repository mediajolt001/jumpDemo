using UnityEngine;
using System.Collections;

public class jumpKa : MonoBehaviour
{
	public int jumpHeight;
	private Rigidbody rigid;
	private AudioSource giggle;

	// Use this for initialization
	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
		giggle = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Animation> ().Play ();
		}
	
	}

	void jumpUp ()
	{
		rigid.AddForce (Vector3.up * jumpHeight);
		giggle.Play ();

	}
}
