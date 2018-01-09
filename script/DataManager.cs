using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : DataManagerBase<DataManager> {

	public DataArea dataArea;
	public DataMansion dataMansion;
	public DataMarket dataMarket;
	public DataShop dataShop;
	public DataStaff dataStaff;

	public MasterArea masterArea;
	public MasterMansion masterMansion;
	public MasterMarket masterMarket;
	public MasterShop masterShop;
	public MasterStaff masterStaff;

	public override void Initialize ()
	{
		base.Initialize ();

		masterMansion = new MasterMansion ();
		masterMansion.SetSaveFilename ("master/master_mansion");
		if (masterMansion.Load () == false ) {
			masterMansion.Save ();
		}

	}

}
