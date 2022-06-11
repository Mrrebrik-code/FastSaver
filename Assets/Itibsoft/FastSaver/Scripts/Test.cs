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

		FastSave.CreateReader("test234").Read<string>();

		FastSave.CreateReader("test236")
			.Read<Test2>("data1", (result) => data = result)
			.Read<Test2>("data2", (result) => data = result)
			.Read<Test2>("data3", (result) => data = result);

		FastSave.CreateWriter("test231")
			.Write<string>(data)
			.Write<string>(data)
			.Commit();
	}

	public class Test2
	{
		public int Data;
		public int Data2;
	}
}
