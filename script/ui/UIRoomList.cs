using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIRoomList : UIListBase {

	[SerializeField]
	public List<BannerRoom> m_bannerRoomList = new List<BannerRoom>();
	protected override void panelStart()
	{
		base.panelStart();
		//Debug.LogError("UIRoomList.panelStart");
		foreach( BannerRoom room in m_bannerRoomList)
		{
			Destroy(room.gameObject);
		}
		m_bannerRoomList.Clear();

		for(int i = 0; i < 5; i++)
		{
			BannerRoot root = PrefabManager.Instance.MakeScript<BannerRoot>("prefab/BannerRoom", m_goContent);

			BannerRoom room = root.gameObject.AddComponent<BannerRoom>();
			room.Initialize(root);
			m_bannerRoomList.Add(room);
		}

	}


}
