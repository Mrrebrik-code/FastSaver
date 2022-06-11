using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveWriter
{
	private string _catalog;
	public SaveWriter(string nameCatalog)
	{
		_catalog = nameCatalog;
	}

	public SaveWriter Write<T>(object data)
	{
		return this;
	} 

	public void Commit()
	{

	}
}
