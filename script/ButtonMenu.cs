using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Button))]
public class ButtonMenu : MonoBehaviour {
	[SerializeField]
	private Text m_txtName;

	Button m_btn;

	// Use this for initialization
	void Start () {
	}

	public void Initialize( string _strName , UnityAction _event )
	{
		m_txtName.text = _strName;
		m_btn = gameObject.GetComponent<Button>();

		m_btn.onClick.AddListener(_event);
	}



}
