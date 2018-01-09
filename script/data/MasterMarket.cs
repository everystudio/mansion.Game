using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterMarketParam : CsvDataParam{
	public string id{ get; set;}
	public string name{ get; set; }

	public string[] shop_list;
}

public class MasterMarket : CsvData<MasterMarketParam> {

}
