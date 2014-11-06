//Resource

using UnityEngine;
using System.Collections;
using System;

namespace Scripts.Resources
{
		public class Resource : MonoBehaviour
		{
				public delegate void valueChangedAction (string name);
				public static event valueChangedAction OnResourceValueChanged;

				private float _v = 0;

				/// <summary>
				/// The name of the given resource.
				/// </summary>
				// replace Object.name
				new public string name = "unnamed resource";

				/// <summary>
				/// Value for given resource.
				/// </summary>
				public float v {
						get { return _v; }
						set {
								_v = value;
								if (OnResourceValueChanged != null)
										OnResourceValueChanged (name);
						}
				}
		
				/// <summary>
				/// Finds the resource.
				/// </summary>
				/// <returns><c>true</c>, if resource was found, <c>false</c> otherwise.</returns>
				/// <param name="n">The name of the resource to be found.</param>
				public bool findResource (string n)
				{
						if (n.Equals (name))
								return true;
						else
								return false;
				}
		}
}
