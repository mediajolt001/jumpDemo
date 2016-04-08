using UnityEngine;
using System.Collections;
using Rewired;

public class jumpKa : MonoBehaviour
{
	public int jumpHeight;
	private Rigidbody rigid;
	private AudioSource giggle;
	public int playerId = 0;
	public Animator anim;
	// The Rewired player id of this character

	private Player player;
	// The Rewired Player
	private bool myJump;

	void Awake ()
	{
		// Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
		player = ReInput.players.GetPlayer (playerId);
	}

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		rigid = GetComponent<Rigidbody> ();
		giggle = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		getInput ();
		getGoing ();
	}

	private void getInput ()
	{
		myJump = player.GetButtonDown ("Jump");
	}

	private void getGoing ()
	{
		if (myJump) {
			anim.SetBool ("isJumping", true);
		}
	}

	void jumpUp ()
	{
		rigid.AddForce (Vector3.up * jumpHeight);
		anim.SetBool ("isJumping", false);
	}

	void theGiggle ()
	{
		giggle.Play ();
	}
}