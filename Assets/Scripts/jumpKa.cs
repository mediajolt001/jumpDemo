using UnityEngine;
using System.Collections;
using Rewired;

public class jumpKa : MonoBehaviour
{
	public int jumpHeight;
	private Rigidbody rigid;
	private AudioSource giggle;
	public int playerId = 0;
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
		rigid = GetComponent<Rigidbody> ();
		giggle = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		getInput ();
		jumpUp ();

	}

	private void jumpUp ()
	{
		if (myJump) {
			GetComponent<Animation> ().Play ();
			rigid.AddForce (Vector3.up * jumpHeight);
			giggle.Play ();
		}

	}

	private void getInput ()
	{
		myJump = player.GetButtonDown ("Jump");
	}
}