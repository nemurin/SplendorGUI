using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saveDataIO : MonoBehaviour
{
    [SerializeField]
    public GameManager gameManager;
    [SerializeField]
    public ImageController imageController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // JSON形式にシリアライズしてセーブ
    public void OnSave()
    {

        // JSON形式にシリアライズ
        var json = "{"+JsonUtility.ToJson(gameManager, false)+"},";

        // JSONデータをファイルに保存
        File.WriteAllText("Assets/Resources/1.txt", json);
    }
}
