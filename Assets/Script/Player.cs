using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //リジッドボディ変数
    private Rigidbody2D rb;

    //プレイヤーの反転重力変数
    Vector2 playerReverseGravity = new Vector2(0, 9.81f * 2);

    //プレイヤーの元の重力変数
    Vector2 playerGravity = new Vector2(0, -9.81f * 2);

    // Start is called before the first frame update
    void Start()
    {
        //リジッドボディ取得
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //移動キー設定
        float horizontalKey = Input.GetAxis("Horizontal");

        //重力反転
        if (Input.GetKey(KeyCode.E))
        {
            Physics2D.gravity = new Vector2(0, 10.0f);
        }

        //重力を元に戻す
        if (Input.GetKey(KeyCode.R))
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
        }

        //プレイヤーの重力反転
        if (Input.GetKey(KeyCode.F))
        {
            rb.AddForce(playerReverseGravity);
        }

        //プレイヤーの重力を元に戻す
        if (Input.GetKey(KeyCode.G))
        {
            rb.AddForce(playerGravity);
        }

        //右移動
        if (horizontalKey > 0)
        {
            rb.AddForce(transform.right * 8.0f);
        }
        //左移動
        else if (horizontalKey < 0)
        {
            rb.AddForce(-transform.right * 8.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        if (Input.GetKey(KeyCode.Space))
        {
            // 入れ替えワープ
            myTransform.position = new Vector3(-6.0f, -1.0f, 0.0f);
        }
    }

}
