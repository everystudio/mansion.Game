using UnityEngine;
using System.Collections;

public class MansionBase : MonoBehaviour {

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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
