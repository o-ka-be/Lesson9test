using UnityEngine;

public class CubeSE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //ColliderVolumeFlgを宣言
    private bool ColliderVolumeFlg = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブ同士が衝突した場合
        //ColliderVolumeFlgのフラグをtrueにする
        if (collision.gameObject.tag == "cube")
        {
            //ColliderVolumeFlgのフラグをtrueにする
            ColliderVolumeFlg = true;
        }

        //キューブが床に衝突した場合
        else if (collision.gameObject.tag == "ground")
        {
            //ColliderVolumeFlgのフラグをtrueにする
            ColliderVolumeFlg = true;
        }

        //ColliderVolumeFlgがtrueの場合音を再生する
        if (ColliderVolumeFlg)
        {
            GetComponent<AudioSource>().Play();
            //ColliderVolumeFlgのフラグをfalseにする
            ColliderVolumeFlg = false;
        }
    }
}
