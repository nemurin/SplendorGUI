using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public int playerNum;
    [SerializeField]
    public Player player;

    public int[] gems = new int[6]; 
    // Start is called before the first frame update
    void Start()
    {
        gems=new int[]{5,5,5,5,5,5};
        playerNum=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WhiteGem(){
        if(playerNum==0){gems[0]--;player.gems[0]++;}
    }
    public void BlueGem(){
        if(playerNum==0){gems[1]--;player.gems[1]++;}
    }
    public void GreenGem(){
        if(playerNum==0){gems[1]--;player.gems[1]++;}
    }
    public void RedGem(){
        if(playerNum==0){gems[1]--;player.gems[1]++;}
    }
    public void BlackGem(){
        if(playerNum==0){gems[1]--;player.gems[1]++;}
    }
}
