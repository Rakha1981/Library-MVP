using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_MVP.Logic.Presenter;
using Library_MVP.Views.Interface;

namespace Library_MVP.Views.Forms
{
	public partial class Frm_Category : Form,ICategory
	{
		CategoryPresenter catPresenter;
		public Frm_Category()
		{
			InitializeComponent();
			catPresenter = new CategoryPresenter(this);
		}

		public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text=value.ToString(); }
		public string CatName { get => txtName.Text; set => txtName.Text = value.ToString(); }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool check=catPresenter.CatInsert();
			if(check==true)
			{
				MessageBox.Show("تم الاضافه بنجاح");
			}
			else
			{
				MessageBox.Show("لم يتم الاضافه ");
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool check = catPresenter.CatUpdate();
			if (check == true)
			{
				MessageBox.Show("تم التعديل بنجاح");
			}
			else
			{
				MessageBox.Show("لم يتم التعديل ");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool check = catPresenter.CatDelete();
			if (check == true)
			{
				MessageBox.Show("تم الحذف بنجاح");
			}
			else
			{
				MessageBox.Show("لم يتم الحذف ");
			}
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			bool check = catPresenter.CatDeleteAll();
			if (check == true)
			{
				MessageBox.Show("تم خذف الجميع بنجاح");
			}
			else
			{
				MessageBox.Show("لم يتم حذف الجميع ");
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			catPresenter.ClearFileds();
		}
	}
}
