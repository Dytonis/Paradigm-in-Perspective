using UnityEngine;

namespace Scripts.Resources
{
		public class Resources : MonoBehaviour
		{

				/// <summary>
				/// Hold the resources.
				/// </summary>
				public Resource[] resources;
		
				public int PrimaryBarElement;
				public int SecondaryBarElement;
		
				public bool hasPrimaryBar;
				public bool hasSecondaryBar;	
		
				public GameObject healthBarReference;		
				public GameObject pivotPointReference;
			
				private GameObject healthBar;
		
				private float rampRatio = 3.2f;
		
				public void Start ()
				{
						healthBar = Instantiate (healthBarReference, new Vector3 (0f, 1f, 0f), gameObject.transform.rotation) as GameObject;
						healthBar.transform.parent = Camera.main.transform;
						
						healthBar.transform.localPosition = new Vector3 (0f, -2.5f, 20f);
						healthBar.transform.localScale = new Vector3 (2f, 0.3f, 1f);
				}	
				
				public void Update ()
				{
						healthBar.transform.rotation = pivotPointReference.transform.rotation;
				}
		}
}