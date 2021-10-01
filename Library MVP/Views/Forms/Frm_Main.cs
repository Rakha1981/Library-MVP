using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Library_MVP.Views.Forms
{
	public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void ribbon_Click(object sender, EventArgs e)
		{

		}

		private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
		{
			Frm_Category frm = new Frm_Category();
			frm.ShowDialog();
		}

		private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
		{
			Frm_BookPlace frm = new Frm_BookPlace();
			frm.ShowDialog();
		}

		private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
		{
			Frm_DarNashr frm = new Frm_DarNashr();
			frm.ShowDialog();
		}

		private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
		{
			Frm_Country frm = new Frm_Country();
			frm.ShowDialog();
		}

		private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
		{
			Frm_Authors frm = new Frm_Authors();
			frm.ShowDialog();
		}
	}
}