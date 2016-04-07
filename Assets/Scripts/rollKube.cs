using UnityEngine;
using System.Collections;

public class rollKube : MonoBehaviour
{

	public int kubeSpeed;
	float horiMove;
	Rigidbody rigid;


	// Use this for initialization
	void Start ()
	{
		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		horiMove = Input.GetAxis ("Horizontal") * -kubeSpeed;
		rigid.AddTorque (0, 0, horiMove);
	}
}

