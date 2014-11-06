using UnityEngine;
using System.Collections;

namespace Scripts.IO
{
		public class InputHandler : MonoBehaviour
		{
				public static bool mcUP = false;
				public static bool mcDown = false;
				public static bool mcLeft = false;
				public static bool mcRight = false;
				public static bool mcJump = false;
				public static bool mcSwitch = false;
		
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
		}
}
