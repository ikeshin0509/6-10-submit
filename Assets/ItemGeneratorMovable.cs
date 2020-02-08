using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorMovable : MonoBehaviour 
{

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;
	//unityちゃんの座標位置取得のコンポーネント　
	private GameObject unitychan; 
	//最初にアイテムを生成した際の座標を保存するための変数　
	public float genePosZ;
	//最後にアイテムを生成するタイミングの座標軸　
	public float endGene;

	// Use this for initialization
	void Start ()
	{
		//unityちゃんのゲームシーンを取得　
		this.unitychan = GameObject.Find ("unitychan"); 

		//最初にアイテムを生成する位置情報　
		genePosZ = -160f;

		//最後にアイテムを生成するタイミング　
		endGene = 80; 
	}



	// Use per once prame 
	void Update()

	{

		////一定の距離ごとにアイテムを生成
		for (float i = unitychan.transform.position.z; i > genePosZ -40 && endGene > i; genePosZ+=40) 
		{
	
			//どのアイテムを出すのかをランダムに設定
			int num = Random.Range (1, 11);
			if (num <= 2) 
			{
				//コーンをx軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f)
				{
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i + 40f);

			
				}
			} else 
			{

				//レーンごとにアイテムを生成
				for (int j = -1; j <= 1; j++)
				{
					//アイテムの種類を決める
					int item = Random.Range (1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5, 6);
					//60%コイン配置:30%車配置:10%何もなし
					if (1 <= item && item <= 6) 
					{
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + 40f + offsetZ);
					} else if (7 <= item && item <= 9) 
					{
						//車を生成
						GameObject car = Instantiate (carPrefab) as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + 40f + offsetZ);
					

					}
				}
			}
		}
	}

}