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
        for(int i=0;i<12;i++){
        ImageSet(settingString[i],image[i]);
        }
    }
    public void ImageSet(string setting,Image image){
        string[] cardName=new string[90]{
            //Lv1R
            "0R02100",
            "0R30000",
            "0R20020",
            "0R11101",
            "0R21101",
            "0R20102",
            "0R10013",
            "1R40000",
            //Lv1K
            "0K00210",
            "0K00300",
            "0K20200",
            "0K11110",
            "0K12110",
            "0K22010",
            "0K00131",
            "1K04000",
            //Lv1W
            "0W00021",          
            "0W03000",
            "0W02002",
            "0W01111",
            "0W01211",
            "0W02201",
            "0W31001",
            "1W00400",
            //Lv1B
            "0B10002",
            "0B00003",
            "0B00202",
            "0B10111",
            "0B10121",
            "0B10220",
            "0B01310",
            "1B00040",
            //Lv1G
            "0G21000",
            "0G00030",
            "0G02020",
            "0G11011",
            "0G11012",
            "0G01022",
            "0G13010",
            "1G00004",
            //lv2R
            "1R20023",
            "1R03023",
            "2R14200",
            "2R30005",
            "2R00005",
            "3R00060",
            //Lv2K
            "1K32200",
            "1K30302",
            "2K01420",
            "2K00530",
            "2K50000",
            "3K00006",
            //Lv2W
            "1W00322",
            "1W20330",
            "2W00142",
            "2W00053",
            "2W00050",
            "3W60000",
            //Lv2G
            "1G23002",
            "1G30230",
            "2G42001",
            "2G05300",
            "2G00500",
            "3G00600",
            //lv2B
            "1B02230",
            "1B02303",
            "2B20014",
            "2B53000",
            "2B05000",
            "3B06000",
            //lv3R
            "3R35303",
            "4R03630",
            "4R00700",
            "5R00730",
            //lv3K
            "3K33503",
            "4K00363",
            "4K00070",
            "5K00073",
            //lv3W
            "3W03353",
            "4W30036",
            "4W00007",
            "5W30007",
            //lv3B
            "3B30335",
            "4B63003",
            "4B70000",
            "5B73000",
            //lv3G
            "3G50333",
            "4G36300",
            "4G07000",
            "5G07300"
            };

        for(int i=0;i<90;i++){
            if(setting==cardName[i]){image.sprite = sprite[i];}
            
        }
    }
}
