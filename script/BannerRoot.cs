using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Button))]
public class BannerRoot : MonoBehaviourEx {
	[SerializeField]
	private Image m_imgIcon;
	[SerializeField]
	private Text m_txtName;
	[SerializeField]
	private Text m_txtEasyText;
	[SerializeField]
	private Text m_txtGold;
	[SerializeField]
	private Text m_txtDaily;

	public Image Icon{
		get{ return m_imgIcon; }
	}
	public Text Name{
		get{ return m_txtName; }
	}
	public Text EasyText{
		get{ return m_txtEasyText; }
	}
	public Text Gold{
		get{ return m_txtGold; }
	}
	public Text Daily{
		get{ return m_txtDaily; }
	}
}




