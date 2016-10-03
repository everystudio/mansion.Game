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

	void dummy_start()
	{
		m_bannerRoot = gameObject.GetComponent<BannerRoot> ();
		gameObject.GetComponent<Button>().onClick.AddListener(()=>
			{
				onClicked();
			});
	}

	public void Initialize(BannerRoot _root)
	{
		m_bannerRoot = _root;
		initialize();
	}

	virtual protected void initialize()
	{
		return;
	}
}
