using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemMessage : Singleton<SystemMessage> {

	[SerializeField]
	private Text m_txt;


	public void Show(string _str)
	{
		if( gameObject.activeSelf == false)
		{
			gameObject.SetActive(true);
		}
		m_txt.text = _str;
	}

	public void Disable()
	{
		gameObject.SetActive(false);
	}

}
