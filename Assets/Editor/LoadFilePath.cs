using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadFilePath : MonoBehaviour {

    public string getPathToFile(string title, string extension)
    {
        return EditorUtility.OpenFilePanel(title, "", extension);
    }
}
