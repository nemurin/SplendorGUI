using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugText : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI debugText;

    [SerializeField]
    public GameManager gameManager;

    [SerializeField]
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = "White:"+gameManager.gems[0]+"Blue:"+gameManager.gems[1]+"Green:"+gameManager.gems[2]+"Red:"+gameManager.gems[3]+"Black:"+gameManager.gems[4]+"Gold:"+gameManager.gems[5];
        debugText.text += "White:"+player.gems[0]+"Blue:"+player.gems[1]+"Green:"+player.gems[2]+"Red:"+player.gems[3]+"Black:"+player.gems[4]+"Gold:"+player.gems[5];
    }
}
