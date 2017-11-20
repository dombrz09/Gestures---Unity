using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.UI;
using System.Diagnostics;
using System;
using System.IO;

public class LoadFile : MonoBehaviour {

    public Text filesPath;
    private string pathDir;
    private string filename;
    private string filenameWithExtension;
    private string mainPath;
    public Text currentImg;
    public Text actionFlag;

    private void deleteOldFiles(String outputImagesPath)
    {
        System.IO.DirectoryInfo directory = new DirectoryInfo(outputImagesPath);

        foreach (FileInfo file in directory.GetFiles())
        {
            file.Delete();
        }
    }

    private void ConvertPDFToJPG(String inputPDFFile, String outputImagesPath)
    {
        this.deleteOldFiles(outputImagesPath);

        string ghostScriptPath = System.IO.Directory.GetCurrentDirectory()+"\\ghostscript\\bin\\gswin64.exe";

        String ars = "-dNOPAUSE -sDEVICE=jpeg -r300 -o" + outputImagesPath + "%d.jpg -sPAPERSIZE=a4 " + "\"" + inputPDFFile + "\"";
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        proc.StartInfo.FileName = ghostScriptPath;
        proc.StartInfo.Arguments = ars;
        proc.StartInfo.CreateNoWindow = true;
        proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        proc.Start();
        proc.WaitForExit();
    }

    public void loadFile()
    {
        //ścieżka do pliku .pdf
        string path = EditorUtility.OpenFilePanel("Load .pdf File", "", "pdf");
        path = path.Replace("/", "\\");
        string[] pathArray = path.Split('\\');
        this.filenameWithExtension = pathArray[pathArray.Length - 1];
        this.filename = System.IO.Path.GetFileNameWithoutExtension(this.filenameWithExtension);
        this.mainPath = path.Replace(this.filenameWithExtension, "");

        if (path.Length > 0)
        {
            this.pathDir = System.IO.Directory.GetCurrentDirectory() + "\\Assets\\FilesImg\\";

            this.filesPath.text = this.pathDir;
            this.currentImg.text = "1";
            this.actionFlag.text = "true";
            if (System.IO.Directory.Exists(this.pathDir) == false)
            {
                System.IO.DirectoryInfo dir = System.IO.Directory.CreateDirectory(this.pathDir);
            }

            this.ConvertPDFToJPG(path, this.pathDir);
            
        }
    }

    private void Start()
    {
        filesPath.text = System.IO.Directory.GetCurrentDirectory() + "\\Assets\\FilesImg\\";
    }
}
