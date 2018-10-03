using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[ExecuteInEditMode]
[RequireComponent (typeof(Waypoint))] // This will add a Waypoint script to the gameobject if it does not have one yet

public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = gameObject.GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapPositionToGRid();
        UpdateLabel();
    }

    private void SnapPositionToGRid()
    {
        transform.position = new Vector3(
                waypoint.GetGridPosition().x,
                0,
                waypoint.GetGridPosition().y
            );
    }

    private void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int gridSize = waypoint.GetGridSize();

        string labelText = waypoint.GetGridPosition().x / gridSize + "," + waypoint.GetGridPosition().y / gridSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
