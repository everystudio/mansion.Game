using UnityEngine;
using System.Collections;

public class MasterTownParam : CsvDataParam
{
	public int town_id { get; set; }
	public string name { get; set; }
	public int type { get; set; }
	public int size { get; set; }
	public string description { get; set; }
}

public class MasterTown : CsvData<MasterTownParam> {
	
}
