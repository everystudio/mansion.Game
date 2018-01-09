using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterMansionParam : CsvDataParam{
	public string id { get; set;}
	public string name{ get; set; }
}

public class MasterMansion : CsvData<MasterMansionParam> {

}



