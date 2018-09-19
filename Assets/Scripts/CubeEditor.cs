using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[ExecuteInEditMode]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Tooltip("Adjust the snapping distance")][Range(1f,20f)] float gridSize = 10;

    TextMesh textMesh;

    private void Start()
    {
        textMesh = GetComponentInChildren<TextMesh>();
    }

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize; // rounds the x coordinate of the gameobjecto and the sets it to the correct scale
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(snapPos.x, 0, snapPos.z);

        textMesh.text = snapPos.x/gridSize + "," + snapPos.z/gridSize;
    }
}
