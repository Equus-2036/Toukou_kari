using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        // 変数にPlayerオブジェクトのtransformコンポーネントを代入
        Target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // カメラのx座標をPlayerオブジェクトのx座標から取得 y座標とz座標は現在の状態を維持
        transform.position = new Vector3(Target.position.x, Target.position.y, transform.position.z);
    }
}