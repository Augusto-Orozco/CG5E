using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class PiramidMesh : MonoBehaviour
{
    [SerializeField]
    Mesh mesh;

    Vector3[] vertices;

    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        mesh.name = "GeneratedMesh";
        GetComponent<MeshFilter>().mesh = mesh;
        UpdateMesh();
    }

    // Update is called once per frame
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = generativeVertices();
        mesh.triangles = generativeTriangles();
    }

    private int[] generativeTriangles()
    {
        return new int[] {
            0, 1, 2, 2, 1, 3,
            0, 2, 4,
            2, 3, 4,
            3, 1, 4,
            1, 0, 4
        };

    }

    private Vector3[] generativeVertices()
    {
        return new Vector3[]
        {
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3(0f, 0.5f, 0f)        
        };
    }
}