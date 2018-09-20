using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] List<Waypoint> path;

    // Use this for initialization
    void Start () {
        StartCoroutine(FollowPath());
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    IEnumerator FollowPath()
    {
        Debug.Log("Starting patrol");
        foreach (Waypoint waypoint in path)
        {
            Debug.Log("Visiting block: " + waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Ending patrol");
    }
}
