﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinesLayer.Abstract
{
	public   interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TUpdate(T entity);
		void TDelete(T entity);
		List<T> TGetAll();
		T TGetById(int id);
	}
}