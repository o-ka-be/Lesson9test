using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    //ゲームオーバーテキスト
    private GameObject gameOverText;
    //ゲームオーバ－の判定
    private bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //シーンビューからオブジェクトの実体を検索する
        this.gameOverText = GameObject.Find("GameOver");
        
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバーになった場合
        if (this.isGameOver == true)
        {
            //クリックされたらシーンをロードする
            if (Mouse.current.leftButton.isPressed)
            {
                //SampleSceneを読み込む
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

        
    public void GameOver()
    {
        //ゲームオーバーになったときに、画面上にゲームオーバーを表示する
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }

}