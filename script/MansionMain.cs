using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections.Generic;

public class MansionMain : Singleton<MansionMain> {

	public override void Initialize()
	{
		base.Initialize();
		handle_page_stack.Clear();
	}
	private Stack<string> handle_page_stack = new Stack<string>();
	public string handle_page;
	//private string m_strHandlePage;
	protected UnityEventString IsCancelEvent = new UnityEventString();

	public void AddCancelEvent( string _pageName , UnityAction<string> _action)
	{
		handle_page_stack.Push(_pageName);
		handle_page = _pageName;
		IsCancelEvent.AddListener(_action);
	}
	public void RemoveCancelEvent(string _pageName, UnityAction<string> _action)
	{
		string strRemove = handle_page_stack.Pop();
		if(_pageName.Equals(strRemove))
		{
			if (0 < handle_page_stack.Count)
			{
				handle_page = handle_page_stack.Peek();
			}
			else
			{
				handle_page = "";
			}
			IsCancelEvent.RemoveListener(_action);			
		}
		else
		{
			Debug.LogError("different page name");
		}
	}

	void Update()
	{
		if (Input.GetMouseButtonUp(1))
		{
			IsCancelEvent.Invoke(handle_page);
		}
	}

}
