using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  ////ここを追加////

public class ScoreText : MonoBehaviour
{

	//点数を格納する変数
	public int score = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		string s = score.ToString();
		this.GetComponent<Text>().text = s + "点";
	}
}