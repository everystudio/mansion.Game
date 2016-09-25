using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MansionView : MonoBehaviour {

	[SerializeField]
	private List<MansionBase> m_mansionList = new List<MansionBase>();

	[SerializeField]
	private GameObject m_MansionContent;



	// Use this for initialization
	void Start () {

		float fWidth = 0.0f;

		foreach( MansionBase mansion in m_mansionList)
		{
			if( 0.0f < fWidth)
			{
				fWidth += Define.MANSION_SIZE_BIAS;
			}
			fWidth += mansion.GetSizeWidth();
		}

		m_MansionContent.transform.rectTransform().sizeDelta = new Vector2(Define.MANSION_VIEW_OFFSET + fWidth, Define.MANSION_VIEW_HEIGHT);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
