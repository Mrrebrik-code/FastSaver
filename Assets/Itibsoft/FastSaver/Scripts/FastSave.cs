using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itibsoft.FastSaver
{
	public static class FastSave
	{
		private static JSONHandler _jsonHandler;
		public static void Init(string pathSave)
		{
			_jsonHandler = JSONHandler.Create(pathSave);
		}

		public static SaveReader CreateReader(string nameCatalog)
		{
			if(ExistGroup(nameCatalog) == true)
			{
				return new SaveReader(nameCatalog);
			}

			return null;
		}

		public static SaveWriter CreateWriter(string nameGroup)
		{
			return new SaveWriter(nameGroup);
		}

		public static bool ExistGroup(string nameGroup)
		{
			return _jsonHandler.ExistFileName(nameGroup);
		}
	}
}

