using UnityEngine;
using System.Collections;

namespace Scripts.IO
{
	public class InputHandler : MonoBehaviour
	{
		public bool mcUP = false;
		public bool mcDown = false;
		public bool mcLeft = false;
		public bool mcRight = false;
		public bool mcJump = false;
		public bool mcSwitch = false;
		
				// Use this for initialization
		public void Update ()
		{
			if (Input.GetKeyDown (ControllsBind.UP)) {
					mcUP = true;
			}
			if (Input.GetKeyDown (ControllsBind.DOWN)) {
					mcDown = true;
			}
			if (Input.GetKeyDown (ControllsBind.LEFT)) {
					mcLeft = true;
			}
			if (Input.GetKeyDown (ControllsBind.RIGHT)) {
					mcRight = true;
			}
			if (Input.GetKeyDown (ControllsBind.JUMP)) {
					mcJump = true;
			}
			if (Input.GetKeyDown (ControllsBind.SWITCH)) {
				mcSwitch = true;
			}

			if (Input.GetKeyUp (ControllsBind.UP)) {
					mcUP = false;
			}
			if (Input.GetKeyUp (ControllsBind.DOWN)) {
					mcDown = false;
			}
			if (Input.GetKeyUp (ControllsBind.LEFT)) {
					mcLeft = false;
			}
			if (Input.GetKeyUp (ControllsBind.RIGHT)) {
					mcRight = false;
			}
			if (Input.GetKeyUp (ControllsBind.JUMP)) {
					mcJump = false;
			}
			if (Input.GetKeyUp (ControllsBind.SWITCH)) {
								mcSwitch = false;
			}
		}

		public bool isAxis(string axis)
		{
			if(axis == RecognizedInputCommands.H)
			{
				if(!mcLeft && !mcRight)
					return false;
				else 
					return true;
			}
			else if (axis == RecognizedInputCommands.V)
			{
				if(!mcUP && !mcDown)
					return false;
				else
					return true;

			}

			return false;
		}
	}
}
