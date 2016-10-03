using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class BannerRoom : BannerBase
{
	protected override void initialize()
	{
		base.initialize();
		gameObject.GetComponent<Button>().onClick.AddListener(() =>
		{
			UIAssistant.main.ShowPage("MansionList");
		});
	}
}
