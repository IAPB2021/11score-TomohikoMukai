using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 下記でTextを使うためのおまじない

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーのゲームオブジェクトを探し出す
        GameObject player = GameObject.Find("Player");
        // プレイヤーのスコア情報を取得する
        PlayerScore playerScore = player.GetComponent<PlayerScore>();
        // スコアボードのTextコンポーネントを取得
        Text text = GetComponent<Text>();
        // Textコンポーネントの内容(text)にスコアをセット
        // ※ int型の score を ToString() メソッドを介して表示用文字情報に変換
        text.text = playerScore.score.ToString();
    }
}
