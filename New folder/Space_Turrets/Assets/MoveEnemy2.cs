using UnityEngine;
using System.Collections;


public class MoveEnemy2 : MonoBehaviour {
	private bool move ;
	private GameObject button ;
	 
	public GameObject[] waypoints ;
	public int currentWaypoint = 0;
	public float lastWaypointSwitchTime;
	public Vector3 startPosition;
	public Vector3 endPosition;

	float dist ;

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {


		lastWaypointSwitchTime = Time.time;

	}
	void Update () {
			//1
		startPosition = waypoints [currentWaypoint].transform.position;
			endPosition = waypoints [currentWaypoint + 1].transform.position;
			//2
			float pathLength = Vector3.Distance (startPosition, endPosition);
			float totalTimeForPath = pathLength / speed;
			float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
			gameObject.transform.position = Vector3.Lerp (startPosition, endPosition,currentTimeOnPath / totalTimeForPath);
			//3

			if (gameObject.transform.position.Equals (endPosition)) {
				if (currentWaypoint < waypoints.Length - 2) {
					// 3.a 
					currentWaypoint++;
					lastWaypointSwitchTime = Time.time;
					// TODO: Rotate into move direction
				} else {
					// 3.b 
					Destroy (gameObject);
					
					AudioSource audioSource = gameObject.GetComponent<AudioSource> ();
					AudioSource.PlayClipAtPoint (audioSource.clip, transform.position);
					// TODO: deduct health
				}
			}
	
	}

		public void nextMove()
	{
		move = true;
	}
	}
	// Update is called once per frame


