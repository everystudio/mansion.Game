using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MansionView : MonoBehaviour {

	[SerializeField]
	private List<MansionBase> m_mansionList = new List<MansionBase>();
	public List<MansionBase> mansion_list
	{
		get { return m_mansionList; }
	}

	[SerializeField]
	private GameObject m_goMansionContent;

	public void MansionClear()
	{
		foreach (MansionBase mansion in mansion_list)
		{
			Destroy(mansion.gameObject);
		}
		m_mansionList.Clear();
	}

	public void Initialize()
	{
		// 最初にクリア
		MansionClear();
		float fHeight = 0.0f;

		for( int i = 1; i < 3; i++)
		{
			MansionBase mansion = PrefabManager.Instance.MakeScript<MansionBase>("prefab/PrefMansion", m_goMansionContent);
			mansion.Initialize(i);
			m_mansionList.Add(mansion);
		}

		foreach (MansionBase mansion in m_mansionList)
		{
			if (0.0f < fHeight)
			{
				fHeight += Define.MANSION_SIZE_BIAS;
			}
			fHeight += mansion.GetSizeHeight();
		}
		//Debug.LogError(fHeight);
		m_goMansionContent.transform.rectTransform().sizeDelta = new Vector2(
			m_goMansionContent.transform.rectTransform().sizeDelta.x,
			fHeight);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
