using HutongGames.PlayMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSelect : FsmStateAction
{
	public FsmGameObject root;

	public FsmGameObject list_button_root;
	public FsmGameObject map_root;


	public override void OnEnter()
	{
		base.OnEnter();

		root.Value.SetActive(true);

	}

	public override void OnExit()
	{
		base.OnExit();

		root.Value.SetActive(false);
	}

}
