﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMansionParam : CsvDataParam {
	public string id{ get; set; }
	public int status{ get; set; }
}

public class DataMansion : CsvData<DataMansionParam> {

}





