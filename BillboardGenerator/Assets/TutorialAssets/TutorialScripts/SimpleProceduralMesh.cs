using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimpleProceduralMesh : MonoBehaviour
{
    void OnEnable()
    {
        var mesh = new Mesh{
            name = "Procedural Mesh"
        };

        GenerateMesh(mesh);
    }

    void GenerateMesh(Mesh mesh) {
        Vector3[] vertices = new Vector3[] {
            Vector3.zero, Vector3.right, Vector3.up, new Vector3(1,1,0)
        };
        int[] triangles = new int[] {
            0, 2, 1,
            2, 3, 1
        };

        Vector3[] normals = new Vector3[] {
            Vector3.back, Vector3.back, Vector3.back, Vector3.back
        };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.normals = normals;

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
