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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = "White:"+gameManager.gems[0]+"Blue:"+gameManager.gems[1]+"Green:"+gameManager.gems[2]+"Red:"+gameManager.gems[3]+"Black:"+gameManager.gems[4]+"Gold:"+gameManager.gems[5];
        debugText.text += "White:"+gameManager.player1_gems[0]+"Blue:"+gameManager.player1_gems[1]+"Green:"+gameManager.player1_gems[2]+"Red:"+gameManager.player1_gems[3]+"Black:"+gameManager.player1_gems[4]+"Gold:"+gameManager.player1_gems[5];
    }
}
