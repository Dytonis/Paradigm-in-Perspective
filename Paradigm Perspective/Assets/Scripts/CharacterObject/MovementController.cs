using UnityEngine;
using System.Collections;
using Scripts.IO;
using Scripts.Game;
using Scripts;

public class MovementController : MonoBehaviour
{
	public bool grounded = false;

	private InputHandler io;
	private Rigidbody rig;
		// Use this for initialization
	public void Start()
	{
		io = gameObject.GetComponent<InputHandler>();
		rig = gameObject.GetComponent<Rigidbody>();

		Physics.gravity = new Vector3(0f, -Game.GravityStrength, 0f);
	}

	public void FixedUpdate ()
	{
		if(GameState.currentCameraState == CameraSwitchState.SideScroll)
		{
			if(io.mcRight)
			{
				if(rig.velocity.x <= Game.playerTerminalVelocity)
					rig.AddForce(70.0f, 0f, 0f);
			}
			if(io.mcLeft)
			{
				if(rig.velocity.x >= -Game.playerTerminalVelocity)
					rig.AddForce(-70.0f, 0f, 0f);
			}

			if(io.mcJump)
			{
				if(grounded)
				{
					rig.AddForce(0f, 2000f, 0f);
					rig.drag = 0;
				}
			}

			if(!io.isAxis(RecognizedInputCommands.H) && !io.mcJump)
			{
				if(grounded)
					rig.drag = Game.playerBrakingRate;
			}
			else
			{
				rigidbody.drag = 0;
			}
		}
		else if (GameState.currentCameraState == CameraSwitchState.TopDown)
		{
			rig.drag = Game.playerBrakingRate;

			if(io.mcRight)
			{
				if(rig.velocity.x <= Game.playerTerminalVelocity)
					rig.AddForce(100.0f, 0f, 0f);
			}
			if(io.mcLeft)
			{
				if(rig.velocity.x >= -Game.playerTerminalVelocity)
					rig.AddForce(-100.0f, 0f, 0f);
			}
			if(io.mcUP)
			{
				if(rig.velocity.z <= Game.playerTerminalVelocity)
					rig.AddForce(0f, 0f, 100f);
			}
			if(io.mcDown)
			{
				if(rig.velocity.z >= -Game.playerTerminalVelocity)
					rig.AddForce(0f, 0f, -100f);
			}
		}
	}

	public void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.layer == 8)
		{
			grounded = true;
		}
	}

	public void OnCollisionExit(Collision col)
	{
		if(col.gameObject.layer == 8)
		{
			grounded = false;
		}
	}
}
