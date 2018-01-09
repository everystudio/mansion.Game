using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTownParam : CsvDataParam{
	public string id{ get; set; }
	public int status{ get; set; }
}

public class DataTown : CsvData<DataTownParam> {

}
