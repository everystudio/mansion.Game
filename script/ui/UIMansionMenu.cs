using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System;

public class UIMansionMenu : CPanel {

	static public void btnMansionList()
	{
		UIAssistant.main.ShowPage("MansionList");
	}
	private void btnMemberList()
	{
		return;
	}
	private void btnTownList()
	{
		UIAssistant.main.ShowPage("TownList");
	}

	/*
	protected override Dictionary<string, UnityAction> getButtonList()
	{
		return new Dictionary<string, UnityAction>();
		Dictionary<string, UnityAction> menu_list = new Dictionary<string, UnityAction>()
		{
			{ "娼館一覧",btnMansionList },
			{ "娼婦一覧",btnMemberList },
			{ "町へ",btnTownList }
		};
		return menu_list;
	}
	*/

	// Use this for initialization
	protected override void awake()
	{
		base.awake();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
