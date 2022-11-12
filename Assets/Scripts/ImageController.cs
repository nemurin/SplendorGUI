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
    }

    // Update is called once per frame
    void Update()
    {
        ImageSet(settingString[0],image[0]);
    }
    public void ImageSet(string setting,Image image){
        int i=0;
        //Lv1R
        if(setting=="0R02100"){image.sprite = sprite[i];}i++;
        if(setting=="0R30000"){image.sprite = sprite[i];}i++;
        if(setting=="0R20020"){image.sprite = sprite[i];}i++;
        if(setting=="0R11101"){image.sprite = sprite[i];}i++;
        if(setting=="0R21101"){image.sprite = sprite[i];}i++;
        if(setting=="0R20102"){image.sprite = sprite[i];}i++;
        if(setting=="0R10013"){image.sprite = sprite[i];}i++;
        if(setting=="1R40000"){image.sprite = sprite[i];}i++;
        //Lv1K
        if(setting=="0K00210"){image.sprite = sprite[i];}i++;
        if(setting=="0K00300"){image.sprite = sprite[i];}i++;
        if(setting=="0K20200"){image.sprite = sprite[i];}i++;
        if(setting=="0K11110"){image.sprite = sprite[i];}i++;
        if(setting=="0K12110"){image.sprite = sprite[i];}i++;
        if(setting=="0K22010"){image.sprite = sprite[i];}i++;
        if(setting=="0K00131"){image.sprite = sprite[i];}i++;
        if(setting=="1K04000"){image.sprite = sprite[i];}i++;
        //Lv1W
        if(setting=="0W00021"){image.sprite = sprite[i];}i++;
        if(setting=="0W03000"){image.sprite = sprite[i];}i++;
        if(setting=="0W02002"){image.sprite = sprite[i];}i++;
        if(setting=="0W01111"){image.sprite = sprite[i];}i++;
        if(setting=="0W01211"){image.sprite = sprite[i];}i++;
        if(setting=="0W02201"){image.sprite = sprite[i];}i++;
        if(setting=="0W31001"){image.sprite = sprite[i];}i++;
        if(setting=="1W00400"){image.sprite = sprite[i];}i++;
        //Lv1B
        if(setting=="0B10002"){image.sprite = sprite[i];}i++;
        if(setting=="0B00003"){image.sprite = sprite[i];}i++;
        if(setting=="0B00202"){image.sprite = sprite[i];}i++;
        if(setting=="0B10111"){image.sprite = sprite[i];}i++;
        if(setting=="0B10121"){image.sprite = sprite[i];}i++;
        if(setting=="0B10220"){image.sprite = sprite[i];}i++;
        if(setting=="0B01310"){image.sprite = sprite[i];}i++;
        if(setting=="1B00040"){image.sprite = sprite[i];}i++;
        //Lv1G
        if(setting=="0G21000"){image.sprite = sprite[i];}i++;
        if(setting=="0G00030"){image.sprite = sprite[i];}i++;
        if(setting=="0G02020"){image.sprite = sprite[i];}i++;
        if(setting=="0G11011"){image.sprite = sprite[i];}i++;
        if(setting=="0G11012"){image.sprite = sprite[i];}i++;
        if(setting=="0G01022"){image.sprite = sprite[i];}i++;
        if(setting=="0G13010"){image.sprite = sprite[i];}i++;
        if(setting=="1G00004"){image.sprite = sprite[i];}i++;

        //lv2R
        if(setting=="1R20023"){image.sprite = sprite[i];}i++;
        if(setting=="1R03023"){image.sprite = sprite[i];}i++;
        if(setting=="2R14200"){image.sprite = sprite[i];}i++;
        if(setting=="2R30005"){image.sprite = sprite[i];}i++;
        if(setting=="2R00005"){image.sprite = sprite[i];}i++;
        if(setting=="3R00060"){image.sprite = sprite[i];}i++;
        //lv2K
        if(setting=="1K32200"){image.sprite = sprite[i];}i++;
        if(setting=="1K30302"){image.sprite = sprite[i];}i++;
        if(setting=="2K01420"){image.sprite = sprite[i];}i++;
        if(setting=="2K00530"){image.sprite = sprite[i];}i++;
        if(setting=="2K50000"){image.sprite = sprite[i];}i++;
        if(setting=="3K00006"){image.sprite = sprite[i];}i++;
        //lv2W
        if(setting=="1W00322"){image.sprite = sprite[i];}i++;
        if(setting=="1W20330"){image.sprite = sprite[i];}i++;
        if(setting=="2W00142"){image.sprite = sprite[i];}i++;
        if(setting=="2W00053"){image.sprite = sprite[i];}i++;
        if(setting=="2W00050"){image.sprite = sprite[i];}i++;
        if(setting=="3W60000"){image.sprite = sprite[i];}i++;
        //lv2G
        if(setting=="1G23002"){image.sprite = sprite[i];}i++;
        if(setting=="1G30230"){image.sprite = sprite[i];}i++;
        if(setting=="2G42001"){image.sprite = sprite[i];}i++;
        if(setting=="2G05300"){image.sprite = sprite[i];}i++;
        if(setting=="2G00500"){image.sprite = sprite[i];}i++;
        if(setting=="3G00600"){image.sprite = sprite[i];}i++;
        //lv2G
        if(setting=="1B02230"){image.sprite = sprite[i];}i++;
        if(setting=="1B02303"){image.sprite = sprite[i];}i++;
        if(setting=="2B20014"){image.sprite = sprite[i];}i++;
        if(setting=="2B53000"){image.sprite = sprite[i];}i++;
        if(setting=="2B05000"){image.sprite = sprite[i];}i++;
        if(setting=="3B06000"){image.sprite = sprite[i];}i++;

        //lv3R
        if(setting=="3R35303"){image.sprite = sprite[i];}i++;
        if(setting=="4R03630"){image.sprite = sprite[i];}i++;
        if(setting=="4R00700"){image.sprite = sprite[i];}i++;
        if(setting=="5R00730"){image.sprite = sprite[i];}i++;
        //lv3K
        if(setting=="3K33503"){image.sprite = sprite[i];}i++;
        if(setting=="4K00363"){image.sprite = sprite[i];}i++;
        if(setting=="4K00070"){image.sprite = sprite[i];}i++;
        if(setting=="5K00073"){image.sprite = sprite[i];}i++;
        //lv3W
        if(setting=="3W03353"){image.sprite = sprite[i];}i++;
        if(setting=="4W30036"){image.sprite = sprite[i];}i++;
        if(setting=="4W00007"){image.sprite = sprite[i];}i++;
        if(setting=="5W30007"){image.sprite = sprite[i];}i++;
        //lv3B
        if(setting=="3B30335"){image.sprite = sprite[i];}i++;
        if(setting=="4B63003"){image.sprite = sprite[i];}i++;
        if(setting=="4B70000"){image.sprite = sprite[i];}i++;
        if(setting=="5B73000"){image.sprite = sprite[i];}i++;
        //lv3G
        if(setting=="3G50333"){image.sprite = sprite[i];}i++;
        if(setting=="4G36300"){image.sprite = sprite[i];}i++;
        if(setting=="4G07000"){image.sprite = sprite[i];}i++;
        if(setting=="5G07300"){image.sprite = sprite[i];}i++;
    }
}
