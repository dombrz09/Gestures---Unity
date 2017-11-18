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

    string basePath = "C:\\tinker.obj";

    void Start () {
        Load(basePath);
    }
	
	void Update () {

    }

    private void Load(string path) {
        //objekt do importowanie plikow w formacie .obj
        var objImporter = new ObjImporter();

        //właściwe załadowanie pliku do pamięci
        Mesh loadedMesh = objImporter.ImportFile(path);

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