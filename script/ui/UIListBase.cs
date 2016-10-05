using UnityEngine;
using System.Collections.Generic;

public class UIListBase : CPanel
{
	protected GameObject m_goContent;

	protected override void awake()
	{
		base.awake();
		List<GameObject> list = MonoBehaviourEx.GetChildren("Content", gameObject);
		if (list.Count == 1)
		{
			m_goContent = list[0];
		}
		else
		{
			Debug.LogError("Error No Content");
		}

		// ダミーとかで付いてるやつを削除
		list = MonoBehaviourEx.GetAll(m_goContent);
		foreach (GameObject obj in list)
		{
			Destroy(obj);
		}
	}

	protected override void panelStart()
	{
		base.panelStart();
		MansionMain.Instance.AddCancelEvent( pageName , OnSelectCancel);
	}
	protected override void panelEndStart()
	{
		base.panelEndStart();
		MansionMain.Instance.RemoveCancelEvent(pageName, OnSelectCancel);
	}


	virtual protected void OnSelectCancel(string _strName )
	{
		Debug.LogError(string.Format("OnSelectCancel:{0} input:{1}",pageName, _strName));
		if (_strName.Equals(pageName))
		{
			UIAssistant.main.ShowPreviousPage();
		}
	}
}



