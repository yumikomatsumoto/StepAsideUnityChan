using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

    private GameObject UnityChan;

    // Use this for initialization
    void Start () {

        //Unitychanオブジェクトを取得
        this.UnityChan= GameObject.Find("unitychan");
		

    }
	
	// Update is called once per frame
	void Update () {
        //ユニティちゃんが通り過ぎて画面外に出たらアイテムを破棄する。
        if (this.UnityChan.transform.position.z > transform.position.z +10) {
            Destroy(gameObject);
        }

    }
}
