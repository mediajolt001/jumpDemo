//using UnityEngine;
//using System.Collections;
//
//public class movement : MonoBehaviour
//{
//
//	public float forceSpeed;
//	public float jumpHeight;
//	public Rigidbody rigid;
//	bool grouxnded;
//
//	float horiMove;
//	float jumpMove;
//
//	// Use this for initialization
//	void Start ()
//	{
//		if (GetComponent<Rigidbody> () != null) {
//			return;
//		} else {
//			Debug.Log ("This GameObject needs a rigidbody");
//		}
//		rigid = GetComponent<Rigidbody> ();
//	}
//	
//	// Update is called once per frame
//	void FixedUpdate ()
//	{
//		horiMove = Input.GetAxis ("Mouse X") * forceSpeed;
//		jumpMove = Input.GetAxis ("Jump") * jumpHeight;
//		rigid.AddForce (horiMove, jumpMove, 0);
//
//	}
//
//	void OnCollisionEnter (Collision col)
//	{
//		if (col.gameObject.tag == "Ground") {
//			grounded = true;
//		}
//		Debug.Log (grounded);
//	}
//
//	void OnCollisionStay (Collision col)
//	{
//		if (col.gameObject.tag == "Ground") {
//			grounded = true;
//		}
//		Debug.Log (grounded);
//	}
//
//	void OnCollisionExit (Collision col)
//	{
//		if (col.gameObject.tag == "Ground") {
//			grounded = false;
//		}
//		Debug.Log (grounded);
//	}
//}
