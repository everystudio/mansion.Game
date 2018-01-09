using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterAreaParam : CsvDataParam{
	public string id{ get;set;}
	public string name{ get; set; }
}

public class MasterArea : CsvData<MasterAreaParam> {

}
