using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();

	// Use this for initialization
	void Start () {
        LoadBlocks();
	}

    private void LoadBlocks()
    {
        Waypoint [] waypoints = FindObjectsOfType<Waypoint>();

        foreach (Waypoint waypoint in waypoints)
        {
            if ( grid.ContainsKey(waypoint.GetGridPosition()) ) // if there is an overlapping cube print a warning
            {
                Debug.LogWarning("Skipping overlapping block " + waypoint);
            }
            else // else add the block to the dictionary
            {
                grid.Add(waypoint.GetGridPosition(), waypoint);
            }
        }
        print("Loaded " + grid.Count + " blocks");
    }
}
