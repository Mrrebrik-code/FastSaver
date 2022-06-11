using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Itibsoft.FastSaver;

public class Test : MonoBehaviour
{
	private void Start()
	{
		var json = JSONHandler.Create(Application.persistentDataPath);
		var data = new Test2();
		data.Data = 1;
		data.Data2 = 2;
		json.WriteToJsonFile("test", data);

		Debug.Log(json.ExistFileName("test"));
		Debug.Log(json.ExistFileName("test2"));
		data.Data2 = 22;
		json.WriteToJsonFile("test2", data);
		Debug.Log(json.ExistFileName("test2"));
	}

	public class Test2
	{
		public int Data;
		public int Data2;
	}
}
