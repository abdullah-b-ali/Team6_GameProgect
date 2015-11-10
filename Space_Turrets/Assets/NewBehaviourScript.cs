using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject Enemy1, Enemy2;
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public bool move = false;
    // Use this for initialization
    void Start () {

        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    public void OnClick()
    {

    }

    public void StartAnim()
    {
        move = true;
    }
    // Update is called once per frame
    void Update () {
        if (move == true)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            Enemy1.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
        }

    }
}
