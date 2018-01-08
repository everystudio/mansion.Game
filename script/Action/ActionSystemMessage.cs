using HutongGames.PlayMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemMessageShow : FsmStateAction
{
	public FsmString message;

	public override void OnEnter()
	{
		base.OnEnter();

		SystemMessage.Instance.Show(message.Value);
	}
}


public class SystemMessageDisable : FsmStateAction
{

	public override void OnEnter()
	{
		base.OnEnter();
		SystemMessage.Instance.Disable();
	}
}



