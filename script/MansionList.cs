using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MansionList : MonoBehaviour {

	[SerializeField]
	private GameObject m_goMansionContents;

	// Use this for initialization
	void Start () {
		AssetBundleManager.Instance.Initialize("dummy", 0);
		Debug.Log("load start");

		string strAssetName = "assets/mansion.game/prefab/assetbundle/prefmansionbanner";
		StartCoroutine(AssetBundleManager.Instance.LoadAssetBundle(strAssetName, ((bool isSuccess, string error) =>
		{
			if (isSuccess)
			{
				//Debug.Log("ロード成功");
				Debug.Log(AssetBundleManager.Instance.GetAssetBundle(strAssetName).LoadAsset(strAssetName + ".prefab", typeof(GameObject)) as GameObject);
				GameObject pref = AssetBundleManager.Instance.GetAssetBundle(strAssetName).LoadAsset(strAssetName + ".prefab", typeof(GameObject)) as GameObject;
				PrefabManager.Instance.MakeObject(pref, m_goMansionContents);
				PrefabManager.Instance.MakeObject(AssetBundleManager.Instance.GetAsset<GameObject>("assets/mansion.game/prefab/assetbundle/prefmansionbanner", "assets/mansion.game/prefab/assetbundle/prefmansionbanner.prefab"), m_goMansionContents);
			}
			else {
				Debug.Log("ロード失敗 : " + error);
			}
		})));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
