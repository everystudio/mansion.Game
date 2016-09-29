using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(BannerRoot))]
public class BannerBase : MonoBehaviourEx {

	protected BannerRoot m_bannerRoot;
	public BannerRoot bannerRoot{
		get{ return m_bannerRoot; }
	}

	protected void onClicked(){
		Debug.LogError("not override onClicked");
		return;
	}

	void Start()
	{
		m_bannerRoot = gameObject.GetComponent<BannerRoot> ();
		gameObject.GetComponent<Button>().onClick.AddListener(()=>
			{
				onClicked();
			});
	}
}
