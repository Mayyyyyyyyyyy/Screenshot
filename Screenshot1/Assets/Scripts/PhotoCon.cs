using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Text = TMPro.TextMeshProUGUI;
using static UnityEditor.Progress;

public class PhotoCon : MonoBehaviour
{
    public Image image;
    public Sprite s2;
    private IMG2S IMG2;
    private string filepath;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        filepath = "Assets/Resources/image_";
        IMG2 = new IMG2S();
        //下面這行是測試IMG2S正常
        SetImage(filepath + "001"+".png");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            i++;
            countI();
        }
    }

    void countI()
    {
        if (i < 10)
        {
            SetImage(filepath + "00" + i + ".png");
        }
        else if (10 <=i && i < 100)
        {
            SetImage(filepath + "0" + i + ".png");
        }
        else if (100 <= i && i < 1000)
        {
            SetImage(filepath + i + ".png");
        }
    }

    void SetImage(string path)
    {
        image.GetComponent<Image>().sprite = IMG2.LoadNewSprite(path, 100.0f);
    }


}
