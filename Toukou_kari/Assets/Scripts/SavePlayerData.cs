using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SavePlayerData
{
    public int[] Item = new int[255];   // イベントフラグ管理
    public int Room;   // ルームフラグ管理
    public float x; // プレイヤーのx座標
    public float y; // プレイヤーのy座標
    public int[] Archivement = new int[25];  // すでに達成したエンドを保存
}
