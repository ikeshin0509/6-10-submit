using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteanyitems : MonoBehaviour {

	//画面外でアイテムを処理するための変数
	private Renderer dissappearItems;


	// Use this for initialization
	void Start () 
	{
	
		//rendererコンポーネント取得
		this.dissappearItems = GetComponent<Renderer>(); 

	}
	
	// Update is called once per frame
	void Update ()
	{
	
		//アイテムが画面外に出た時に消す　
		if (dissappearItems.isVisible) { 
			if (gameObject.tag == "CoinTag") {

				Debug.Log (gameObject.name); 

				Destroy (gameObject); 
			}
		}
	}
			
}
