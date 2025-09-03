using UnityEngine;


public class CubeGenerator : MonoBehaviour
{
    //キューブのprefab
    public GameObject cubePrefab;

    //キューブの生成位置:x座標
    private float genPosX = 4;

    // キューブの生成位置オフセット
    private float offsetY = 0.3f;
    // キューブの縦方向の間隔
    private float spaceY = 6.9f;

    /// //////////////////////////////////

    //Attackボタン押下の判定（追加）
    private bool isAttackButtonDown = false;

    /// //////////////////////////////////




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        {
            {
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY * this.spaceY);
            }
        }
    }
    void Update()
    {
        /// //////////////////////////////////追加
        //attackボタンを押したらキューブを消す
        if (this.isAttackButtonDown)
            Destroy(gameObject);
    }
            
                //ジャンプボタンを押した場合の処理（追加）
    public void GetMyAttackButtonDown()
    {
        this.isAttackButtonDown = true;
    }

    //ジャンプボタンを離した場合の処理（追加）
    public void GetMyAttackButtonUp()
    {
        this.isAttackButtonDown = false;
    }
    /// //////////////////////////////////
    }

    



    


