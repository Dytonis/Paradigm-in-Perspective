using UnityEngine;
using System.Collections;

namespace Scripts.IO
{
	public static class ControllsBind
	{
		public static KeyCode UP = KeyCode.UpArrow;
		public static KeyCode JUMP = KeyCode.UpArrow;
		public static KeyCode DOWN = KeyCode.DownArrow;
		public static KeyCode LEFT = KeyCode.LeftArrow;
		public static KeyCode RIGHT = KeyCode.RightArrow;
		public static KeyCode SWITCH = KeyCode.Space;
	}
	
	public static class RecognizedInputCommands
	{
		public static string UP = "UP";
		public static string JUMP = "JUMP";
		public static string DOWN = "DOWN";
		public static string LEFT = "LEFT";
		public static string RIGHT = "RIGHT";
		public static string SWITCH = "SWITCH";
	}
}
