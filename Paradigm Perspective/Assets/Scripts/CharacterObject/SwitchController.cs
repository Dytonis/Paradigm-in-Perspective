//
//   Paradigm Perspective
//   Tanner Wright
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using Scripts.IO;

namespace Scripts.CharacterObject
{
	public class SwitchController : MonoBehaviour
	{
		InputHandler io;
		SwitchAnimationFlag swf;
		Animation anim;

		public GameObject seeker;

		public void Start()
		{
			io = gameObject.GetComponent<InputHandler>();
			swf = gameObject.GetComponent<SwitchAnimationFlag>();
			anim = seeker.GetComponent<Animation>();

			GameState.currentCameraState = CameraSwitchState.SideScroll;
		}

		public void Update()
		{
			if(io.mcSwitch)
			{
				Time.timeScale = 0.1f;
				if(GameState.currentCameraState == CameraSwitchState.SideScroll)
				{
					seeker.animation["Switch_STT"].speed = 3.0f;
					anim.Play("Switch_STT");
				}
				else if (GameState.currentCameraState == CameraSwitchState.TopDown)
				{

					seeker.animation["Switch_TTS"].speed = 3.0f;
					anim.Play ("Switch_TTS");
				}
			}
		}
	}
}

