using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * キャラの座標を変更するController
 */
public class Player_Controller : MonoBehaviour
{
    public readonly float SPEED = 0.1f;
    private Rigidbody2D rb;
    private Vector2 input;

    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        if (input == Vector2.zero)
        {
            return;
        }

        // 既存のポジションに対して，移動量(vector)を加算する
        rb.position += input * SPEED;
    }
}