using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
// ↑ LoadSceneを使うためのおまじない

public class PlayerScore : MonoBehaviour
{
    public int score; //スコアを記録するフィールド
    void Start()
    {
        score = 0;        
    }
    void Update()
    {        
    }
    void OnTriggerEnter2D(Collider2D c) // 落ち葉と当たってトリガーが発生したとき
    {
        ++score; // スコアアップ
        if (score >= 10)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
