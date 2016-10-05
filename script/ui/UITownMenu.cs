using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class UITownMenu : UIMenuPageBase {
	static public void btnMansionList()
	{
		UIAssistant.main.ShowPage("MansionList");
	}
	private void btnMemberList()
	{
		return;
	}
	protected override Dictionary<string, UnityAction> getButtonList()
	{
		Dictionary<string, UnityAction> menu_list = new Dictionary<string, UnityAction>()
		{
			{ "話す",btnMansionList },
			{ "アイテム店",btnMemberList }
		};
		return menu_list;
	}

}
