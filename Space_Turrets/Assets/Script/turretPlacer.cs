using UnityEngine;
using System.Collections;

public class turretPlacer : MonoBehaviour {

		public GameObject turretPrefab;
		private GameObject turret;
		
		// Use this for initialization
		private bool canPlaceTurret()
		{
			return turret == null;
			
		}
		void OnMouseUp() {
			if (canPlaceTurret()) {
				turret =(GameObject)
					Instantiate(turretPrefab ,transform.position,Quaternion.identity);
				AudioSource audioSource = gameObject.GetComponent<AudioSource>();
				audioSource.PlayOneShot(audioSource.clip);
			}
		}
		void Start () {
			
		}
		
		
		
		// Update is called once per frame
		void Update () {
			
		}
	}

