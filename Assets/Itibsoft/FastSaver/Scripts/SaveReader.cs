using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;

public class SaveReader 
{
	private string _catalog;
	public SaveReader(string nameCatalog)
	{
		_catalog = nameCatalog;
	}
	public static bool ExistKey()
	{
		return false;
	}
	public bool Read<T>()
	{
		return false;
	}

	public SaveReader Read<T>(string key, Action<T> result) where T : class
	{
		result.Invoke(null);
		return this;
	}

}
