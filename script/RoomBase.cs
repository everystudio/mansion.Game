using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Button))]
public class RoomBase : MonoBehaviour {

	private Button m_btn = null;

	private void showRoomList()
	{
		UIAssistant.main.ShowPage("RoomList");
	}

	public void Initialize( int _iRoomSerial)
	{
		if(m_btn == null)
		{
			m_btn = gameObject.GetComponent<Button>();
			m_btn.onClick.AddListener(showRoomList);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
