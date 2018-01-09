using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataShopParam : CsvDataParam {
	public string id{ get; set; }
	public int status{ get; set; }
}

public class DataShop : CsvData<DataShopParam> {

}
