using System;
using SQLite;

namespace EcuMed

{
	public interface Database
	{
		SQLiteAsyncConnection GetConnection();
	}
}

