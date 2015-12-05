using UnityEngine;
using System.Collections;


public class MoveEnemy : MonoBehaviour {
	private bool move ;
	private GameObject button ;
	 
		//[HideInInspector]
	public GameObject[] waypoints ;
	private int currentwaypoint = 0;
	private float lastwaypointSwitchTime;
	private Vector3 startPosition;
	private Vector3 endPosition;

	float dist ;

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {


		lastwaypointSwitchTime = Time.time;

	}
	void Update () {
		button = GameObject.Find ("Button");
		nextTurn nt = button.GetComponent<nextTurn>();
		move = nt.move;
		if (move) {
			startPosition = waypoints [currentwaypoint].transform.position;
			endPosition = waypoints [currentwaypoint + 1].transform.position;
		
			dist = Vector3.Distance (startPosition, endPosition);
			print (waypoints.Length);
		
		
		
			float currentTimeOnPath = Time.time - lastwaypointSwitchTime;

			gameObject.transform.position = Vector3.MoveTowards (startPosition, endPosition, dist);
			if (gameObject.transform.position.Equals (endPosition)) {
				if (currentwaypoint < waypoints.Length - 2) {
					currentwaypoint++;
					lastwaypointSwitchTime = Time.time;
				} else {
					Destroy (gameObject);
					AudioSource audioSource = gameObject.GetComponent<AudioSource> ();
					AudioSource.PlayClipAtPoint (audioSource.clip, transform.position);
				}
			
			}
		}

		nt.move = false;
	}

		public void nextMove()
	{
		move = true;
	}
	}
	// Update is called once per frame


