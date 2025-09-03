using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanController : MonoBehaviour
{
     //アニメーションするためのコンポーネントを入れる
    Animator animator;

    // 地面の位置
    private float groundLevel = -3.0f;
    // ジャンプの速度の減衰


    //ゲームオーバーになる位置
    private float deadLine = -9;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // アニメータのコンポーネントを取得する
        this.animator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        // 走るアニメーションを再生するために、Animatorのパラメータを調節する
        this.animator.SetFloat("Horizontal", 1);

        // 着地しているかどうかを調べる
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        //デッドラインを超えた場合ゲームオーバーにする
        if (transform.position.x < this.deadLine)
        {
            //UIControllerのGameOver関数を呼び出して画面上に「GameOver」と表示する
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();

            //unityちゃんを破棄する
            Destroy(gameObject);
        }
    }
}
