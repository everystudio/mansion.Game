using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Button))]
public class RoomBanner : MonoBehaviour
{

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

	void Start()
	{
		gameObject.GetComponent<Button>().onClick.AddListener(()=>
		{
			Debug.LogError("here");
		});
	}

}
