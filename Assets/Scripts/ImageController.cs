using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    [SerializeField]
    public string[] settingString;
    [SerializeField]
    public Image[] image;
    [SerializeField]
    private Sprite[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        if(settingString[0]=="ok")image[0].sprite = sprite[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(settingString[0]=="ok")image[0].sprite = sprite[0];
    }
}
