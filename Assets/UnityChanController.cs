using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanController : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
     /// ///////////別の動きとして使用する可能性もあるため残しています
    Animator animator;

    // 地面の位置
    // ////アニメーションを止めると落下モーションのままとなり不自然且つ　後ほど地面に立つ動きに変える可能性があるため残しています

    private float groundLevel = -3.0f;

    //ゲームオーバーになる位置　　////HPが0になった場合の処理として後述部分を使う可能性が高い為関連のものは残しています
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
        // ////アニメーションを止めると落下モーションのままとなり不自然且つ　後ほど地面に立つ動きに変える可能性があるため残しています
        this.animator.SetFloat("Horizontal", 1);

        // 着地しているかどうかを調べる
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

　　　　　//////////以下は進行後にHPが0になった場合の処理として一部を使う為残しています
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
