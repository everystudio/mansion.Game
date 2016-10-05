using UnityEngine;
using System.Collections.Generic;

public class UITownList : UIListBase {
	[SerializeField]
	public List<BannerTown> m_bannerTownList = new List<BannerTown>();
	protected override void panelStart()
	{
		base.panelStart();
		//Debug.LogError("UIRoomList.panelStart");
		foreach (BannerTown room in m_bannerTownList)
		{
			Destroy(room.gameObject);
		}
		m_bannerTownList.Clear();

		for (int i = 0; i < 2; i++)
		{
			BannerRoot root = PrefabManager.Instance.MakeScript<BannerRoot>("prefab/BannerTown", m_goContent);
			BannerTown room = root.gameObject.AddComponent<BannerTown>();
			room.Initialize(root);
			m_bannerTownList.Add(room);
		}
	}
	/*
	デフォルトで前のページに戻るを実装してるので、とりあえずそっちを優先
	protected override void OnSelectCancel()
	{
		Debug.LogError("none");
	}
	*/

}
