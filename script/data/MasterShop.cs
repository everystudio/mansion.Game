using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterShopParam :CsvDataParam{
	public string id { get; set; }
	public string name{ get; set ; }
}

public class MasterShop : CsvData<MasterShopParam> {

}
