using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIRoomList : CPanel {

	[SerializeField]
	public List<GameObject> m_dummyDelete = new List<GameObject>();
	public List<BannerRoom> m_bannerRoomList = new List<BannerRoom>();
	public GameObject m_goContents;

	protected override void panelStart()
	{
		if (0 < m_dummyDelete.Count)
		{
			foreach (GameObject dummy in m_dummyDelete)
			{
				Destroy(dummy);
			}
			m_dummyDelete.Clear();
		}
		base.panelStart();
		//Debug.LogError("UIRoomList.panelStart");
		foreach( BannerRoom room in m_bannerRoomList)
		{
			Destroy(room.gameObject);
		}
		m_bannerRoomList.Clear();


		for(int i = 0; i < 5; i++)
		{
			BannerRoot root = PrefabManager.Instance.MakeScript<BannerRoot>("prefab/BannerRoom", m_goContents);

			BannerRoom room = root.gameObject.AddComponent<BannerRoom>();
			room.Initialize(root);
			m_bannerRoomList.Add(room);
		}

	}


}
