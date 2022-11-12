using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public int playerNum;

    public int[] gems = new int[6];

    public int[] player1_gems = new int[6]; 

    public ImageController imageController;
    public string[] settingString; 
    // Start is called before the first frame update
    void Start()
    {
        gems=new int[]{5,5,5,5,5,5};
        player1_gems=new int[]{0,0,0,0,0,0};
        playerNum=0;
    }

    // Update is called once per frame
    void Update()
    {
        settingString = imageController.settingString;
    }
    public void WhiteGem(){
        if(playerNum==0){gems[0]--;player1_gems[0]++;}
    }
    public void BlueGem(){
        if(playerNum==0){gems[1]--;player1_gems[1]++;}
    }
    public void GreenGem(){
        if(playerNum==0){gems[2]--;player1_gems[2]++;}
    }
    public void RedGem(){
        if(playerNum==0){gems[3]--;player1_gems[3]++;}
    }
    public void BlackGem(){
        if(playerNum==0){gems[4]--;player1_gems[4]++;}
    }
}
