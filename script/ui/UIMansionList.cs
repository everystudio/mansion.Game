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





	}

}







