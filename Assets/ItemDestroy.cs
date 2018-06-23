using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

    private GameObject UnityChan;

    //Itemが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    // Use this for initialization
    void Start () {

        //Unitychanオブジェクトを取得
        this.UnityChan= GameObject.Find("UnityChan");
		

    }
	
	// Update is called once per frame
	void Update () {
        //ユニティちゃんが通り過ぎて画面外に出たらアイテムを破棄する。
        if (transform.position.z < visiblePosZ && this.UnityChan) {
            Destroy(gameObject);
        }

    }
}
