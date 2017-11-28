﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : Gimmick {

    // Use this for initialization
    override protected void Start () {
        base.Start();
	}

    // Update is called once per frame
    override protected void Update () {
        base.Update();

        //ギミックの上にいるなら
        if (base.OnFloor() == true)
        {

            //プレイヤーの充電を回復する
            CharacterManager.SetBattery(CharacterManager.GetBattery() + 0.01f);
        }
        //トラップから抜けたら
        else if (base.OnFloor() == false)
        {
            //Debug.Log("当たっていません");
        }
    }
}
