﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Config : MonoBehaviour {

	public string _local;
	public Text _localTexto;
	public Text _msg;

	// Use this for initialization
	void Start () {
		_local = Application.dataPath;
		_localTexto.text = _local;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (_localTexto != null)
		{

			_localTexto.text = _local;
		}
	}

	public void ColocarMsg(string _texto){
		_msg.text = _texto;
	}
}
