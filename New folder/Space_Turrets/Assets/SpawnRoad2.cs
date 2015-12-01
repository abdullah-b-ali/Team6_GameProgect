using UnityEngine;
using System.Collections;

public class SpawnRoad2 : MonoBehaviour {
	public GameObject [] waypoints;
	public GameObject testEnemyPrefab;
	// Use this for initialization
	public void spawning ()  {
		Instantiate(testEnemyPrefab).GetComponent<MoveEnemy>().waypoints = waypoints;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
