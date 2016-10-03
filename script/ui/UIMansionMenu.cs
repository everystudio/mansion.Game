using UnityEngine;
using System.Collections;

public class UIMansionMenu : CPanel {

	public ButtonMenu m_btnMansionList;
	public ButtonMenu m_btnMemberList;

	public void btnMansionList()
	{
		UIAssistant.main.ShowPage("MansionList");
	}

	private void btnMemberList()
	{
		return;
	}
	

	// Use this for initialization
	protected override void awake()
	{
		m_btnMansionList.Initialize("娼館一覧", btnMansionList);
		m_btnMemberList.Initialize("娼婦一覧", btnMemberList);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
