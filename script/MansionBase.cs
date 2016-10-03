using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MansionBase : MonoBehaviour {

	public void Initialize( int _iMansionSerial)
	{
		foreach( RoomBase room in m_RoomList ){
			Destroy(room.gameObject);
		}
		m_RoomList.Clear();

		int iRoomNum = 2;
		if (_iMansionSerial == 2)
		{
			iRoomNum = 4;
		}
		Debug.LogError(iRoomNum);

		for( int i = 0; i < iRoomNum; i++)
		{
			RoomBase room = PrefabManager.Instance.MakeScript<RoomBase>("prefab/PrefRoom", m_goRoomRoot);
			room.Initialize(0);
			m_RoomList.Add(room);
		}

		m_iHeight = m_RoomList.Count / 2;
		m_layoutElement.preferredHeight = GetSizeHeight();

	}


	[SerializeField]
	private Text m_txtName;
	[SerializeField]
	private GameObject m_goRoomRoot;
	[SerializeField]
	private List<RoomBase> m_RoomList = new List<RoomBase>();

	public List<RoomBase> roomList
	{
		get { return m_RoomList; }
	}

	public LayoutElement m_layoutElement;

	[SerializeField]
	private int m_iHeight;
	public int height
	{
		get { return m_iHeight; }
	}
	[SerializeField]
	private int m_iWidth;
	public int width
	{
		get { return m_iWidth; }
	}

	public float GetSizeWidth()
	{
		float fRet = 0.0f;
		fRet += Define.MANSION_INTERVAL;
		fRet += width * Define.MANSION_SIZE_SINGLE;
		return fRet;
	}

	public float GetSizeHeight()
	{
		float fRet = 0.0f;
		fRet += Define.MANSION_HEADER;
		fRet += height * Define.MANSION_SIZE_SINGLE;
		return fRet;
	}


}





