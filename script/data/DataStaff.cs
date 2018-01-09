using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStaffParam : CsvDataParam {
	public string id{get;set;}
	public int status{ get; set; }
}

public class DataStaff : CsvData<DataStaffParam> {
}
