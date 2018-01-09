using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAreaParam :CsvDataParam {
	public string id{ get; set;}
	public int status{ get; set; }
}

public class DataArea : CsvData<DataAreaParam> {

}
