using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMarketParam : CsvDataParam {
	public string id{ get; set; }
	public int status{ get; set; }
}

public class DataMarket : CsvData<DataMarketParam> {

}
