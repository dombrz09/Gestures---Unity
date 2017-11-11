/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Piotr Arent
//Date:         2017-11-11
//Description:  Ladowanie obiektu 3D
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:
//Date:
//Description:
/////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshObject : MonoBehaviour {

	void Start () {}
	
	void Update () {
        //objekt do importowanie plikow w formacie .obj
        var objImporter = new ObjImporter();

        //właściwe załadowanie pliku do pamięci
        Mesh loadedMesh = objImporter.ImportFile("C:\\tinker.obj");

        //pobranie referencji do objektu w unity
        MeshFilter unityMesh = GetComponent<MeshFilter>();
        Mesh myMesh = unityMesh.mesh;

        //przekopiowanie objektu pobranego z pliku do unity
        myMesh.Clear();
        myMesh.vertices = loadedMesh.vertices;
        myMesh.triangles = loadedMesh.triangles;
        myMesh.uv = loadedMesh.uv;
        myMesh.RecalculateNormals();
    }
}