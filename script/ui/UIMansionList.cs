using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIMansionList : CPanel {

	[SerializeField]
	protected MansionView m_mansionView;

	protected override void panelStart()
	{
		base.panelStart();

		// ここはデータを利用する予定
		m_mansionView.Initialize();
		AddCancel();
	}

	protected override void panelEndStart()
	{
		base.panelEndStart();
		RemoveCancel();
	}

	private void AddCancel()
	{
		MansionMain.Instance.AddCancelEvent(pageName, OnSelectCancel);
	}
	private void RemoveCancel()
	{
		MansionMain.Instance.RemoveCancelEvent(pageName,OnSelectCancel);
	}


	virtual protected void OnSelectCancel(string _strPageName )
	{
		Debug.LogError(string.Format("OnSelectCancel:{0}", pageName));
		if (_strPageName.Equals(pageName))
		{
			UIAssistant.main.ShowPage("MansionMenu");
		}
	}
}







