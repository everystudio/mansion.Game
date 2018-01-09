using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterStaffParam : CsvDataParam {

	public string id { get; set; }
	public string name{ get; set; }

}

public class MasterStaff : CsvData<MasterStaffParam> {

}
