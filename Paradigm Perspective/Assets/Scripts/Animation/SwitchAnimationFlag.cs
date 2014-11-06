using UnityEngine;
using System.Collections;
using Scripts;
using Scripts.CharacterObject;

public class SwitchAnimationFlag : MonoBehaviour 
{
	// Use this for initialization
	public void Animation_Switch_STT_Start()
	{
		Time.timeScale = 0.1f;
		GameState.currentCameraState = CameraSwitchState.Switching;
	}
	public void Animation_Switch_TTS_Start()
	{
		Time.timeScale = 0.1f;
		GameState.currentCameraState = CameraSwitchState.Switching;
	}
	public void Animation_Switch_STT_End()
	{
		Time.timeScale = 1f;
		GameState.currentCameraState = CameraSwitchState.TopDown;

	}
	public void Animation_Switch_TTS_End()
	{
		Time.timeScale = 1f;
		GameState.currentCameraState = CameraSwitchState.SideScroll;
	}
}
