using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

abstract public class UIMenuPageBase : CPanel {

	protected GameObject m_goContent;
	protected Dictionary<string, ButtonMenu> buttonList = new Dictionary<string, ButtonMenu>();
	abstract protected Dictionary<string, UnityAction> getButtonList();
	protected Dictionary<string, UnityAction> test()
	{
		return new Dictionary<string, UnityAction>();

	}



	protected override void awake()
	{
		base.awake();
		List<GameObject> list = MonoBehaviourEx.GetChildren("Content", gameObject);
		if( list.Count == 1)
		{
			m_goContent = list[0];
		}
		else
		{
			return;
		}

		// ダミーとかで付いてるやつを削除
		list = MonoBehaviourEx.GetAll(m_goContent);
		foreach( GameObject obj in list)
		{
			Destroy(obj);
		}
		buttonList.Clear();

		Dictionary<string, UnityAction> tempButtonList = getButtonList();
		foreach(KeyValuePair<string, UnityAction> button in tempButtonList)
		{
			ButtonMenu script = PrefabManager.Instance.MakeScript<ButtonMenu>("prefab/ButtonMenu", m_goContent);
			script.Initialize(button.Key, button.Value);
			buttonList.Add(button.Key, script);
		}
	}
	
}
