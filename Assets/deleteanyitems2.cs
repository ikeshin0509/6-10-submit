using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteanyitems2 : MonoBehaviour
{


	//ユニティちゃんをゲームシーン中に取得するための変数　
	private GameObject unitychan; 

	// Use this for initialization
	void Start () 
	{

		//ユニティちゃんの座標取得のためのコンポーネントを取得
		unitychan = GameObject.Find("unitychan"); 

	}

	// Update is called once per frame
	void Update () 
	{

		//各アイテムがユニティちゃんから10後ろに離れたところでアイテムを消去する
		if (this.transform.position.z + 10 < this.unitychan.transform.position.z) 
		{
			//アタッチされているアイテムを消去する
			Destroy(this.gameObject); 

		}

	}
}
