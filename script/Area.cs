using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour {

	public string area_id;
	private bool m_bInitialized;
	[SerializeField]
	private AreaMansion[] areaMansionArr;
	[SerializeField]
	private AreaMarket[] areaMarketArr;

	public MasterMansionParam[] mansionParamArr;
	public MasterMarketParam[] marketParamArr;

	public void Initialize(){
		if (m_bInitialized) {
			Debug.LogWarning ("already initialized");
			return;
		}

		for (int i = 0; i < mansionParamArr.Length; i++) {
		}
		for (int i = 0; i < marketParamArr.Length; i++) {
		}

	}


}
