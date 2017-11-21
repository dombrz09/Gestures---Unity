/////////////////////////////////////////////////
//                  CREATE                      
//Author:       Dawid SKlorz
//Date:         2017-11-18
//Description:  Pobranie ścieżki do obiektu
/////////////////////////////////////////////////
//                  CHANGE                      
//Author:       
//Date:         
//Description:  
/////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using System.Text;
using UnityEngine.UI;

public class Load3dObject : MonoBehaviour {

    public Text objectPath;

    public void load3dObject()
    {
        //ścieżka do pliku .obj
        //string path = EditorUtility.OpenFilePanel("Load 3D Object", "", "obj");
        string path = System.IO.Directory.GetCurrentDirectory() + "\\Assets\\tinker.obj";
        if (path.Length > 0)
        {
            objectPath.text = path;
        }
    }

}
