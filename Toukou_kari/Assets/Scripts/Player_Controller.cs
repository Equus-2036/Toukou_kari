using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * キャラの座標を変更するController
 */
public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    float SPEED = 4.0f;
    private Rigidbody2D rb;
    private Vector2 inputAxis;

    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // 速度を代入する
        rb.velocity = inputAxis.normalized * SPEED;
    }
}