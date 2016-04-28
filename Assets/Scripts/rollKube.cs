using UnityEngine;
using System.Collections;
using Rewired;

public class rollKube : MonoBehaviour
{

	public int playerId = 0;
	public float kubeSpeed;
	float horiMove;
	//Rigidbody rigid;
	private Player player;
	public Animator anim;

	void Start ()
	{
		//rigid = GetComponent<Rigidbody> ();
		player = ReInput.players.GetPlayer (playerId);
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		horiMove = player.GetAxis ("Move Horizontal");
		transform.Translate (horiMove * kubeSpeed, 0, 0);
		GetMoving ();
	}

	//	void FixedUpdate ()
	//	{
	//
	//		//rigid.AddTorque (0, 0, horiMove);
	//
	//	}

	private void GetMoving ()
	{
		if (horiMove != 0) {
			anim.SetBool ("isMoving", true);
		} else {
			anim.SetBool ("isMoving", false);
		}
	}

}

