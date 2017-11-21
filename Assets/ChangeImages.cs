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
using System;
using System.IO;
using UnityEngine.UI;

public class ChangeImages : MonoBehaviour
{
    public Text filesPath;
    public Text currentImg;
    public Text actionFlag;
    private RawImage image;
    private Texture2D img;
    private string[] filesPathArray;

    private void Start()
    {
        this.actionFlag.text = "true";
    }

    private void getImage(int number)
    {
        WWW imgLink = new WWW(this.filesPathArray[number]);
        this.img = imgLink.texture;
        this.image = gameObject.GetComponent<RawImage>();
        this.image.texture = this.img;
    }

    private int getCurrentImage(String currentImageText)
    {
        return Int32.Parse(currentImageText);
    }

    private void Update()
    {
        if (this.filesPath.text.Length > 0 && this.actionFlag.text == "true")
        {
            this.filesPathArray = Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\FilesImg\\", "*.jpg", SearchOption.AllDirectories);
            this.actionFlag.text = "false";
            int currentImg = this.getCurrentImage(this.currentImg.text);

            this.getImage(currentImg - 1);
        }
    }

    public void nextImage()
    {
        if (this.filesPath.text.Length > 0)
        {
            int currentImg = this.getCurrentImage(this.currentImg.text);
            currentImg++;
            if (currentImg <= this.filesPathArray.Length)
            {
                this.currentImg.text = (currentImg).ToString();

                this.getImage(currentImg - 1);
            }
        }
    }

    public void previousImage()
    {
        if (this.filesPath.text.Length > 0)
        {
            int currentImg = this.getCurrentImage(this.currentImg.text);
            currentImg--;
            if (currentImg > 0)
            {
                this.currentImg.text = (currentImg).ToString();

                this.getImage(currentImg - 1);
            }
        }
    }

    public void lastImage()
    {
        this.currentImg.text = (this.filesPathArray.Length).ToString();

        this.getImage(this.filesPathArray.Length - 1);
    }

    public void firstImage()
    {
        this.currentImg.text = "1";

        this.getImage(0);
    }
}
