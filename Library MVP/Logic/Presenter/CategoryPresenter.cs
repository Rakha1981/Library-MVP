using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library_MVP.Logic.Services;
using Library_MVP.Views.Interface;
using System.Threading.Tasks;
using Library_MVP.Models;

namespace Library_MVP.Logic.Presenter
{
	class CategoryPresenter
	{
		ICategory icategory;
		CategoryModel catModel = new CategoryModel();
		public CategoryPresenter(ICategory view)
		{
			this.icategory = view;
		}
		private void connectBetweenModelInterface()
		{
			catModel.ID = icategory.ID;
			catModel.CatName = icategory.CatName;
		}
		public bool CatInsert()
		{
			connectBetweenModelInterface();
			return CategoryService.categoryInsert(catModel.ID, catModel.CatName);
		}
		public bool CatUpdate()
		{
			connectBetweenModelInterface();
			return CategoryService.categoryUpdate(catModel.ID, catModel.CatName);
		}
		public bool CatDelete()
		{
			connectBetweenModelInterface();
			return CategoryService.categoryDelete(catModel.ID);
		}
		public bool CatDeleteAll()
		{
			connectBetweenModelInterface();
			return CategoryService.categoryDeleteAll();
		}
		public void ClearFileds()
		{
			connectBetweenModelInterface();
			icategory.ID = 0;
			icategory.CatName = "";
		}
	}
}
