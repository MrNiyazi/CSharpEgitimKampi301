using CSharpEgitimKampi301.BusinesLayer.Abstract;
using CSharpEgitimKampi301.BusinesLayer.Concrete;
using CSharpEgitimKampi301.DataAccesLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PransentationLayer
{
	public partial class FrmCategory : Form
	{
		private readonly ICategoryService _categoryService;

		public FrmCategory()
		{
			_categoryService = new CategoryManager(new EfCategoryDal());
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var categoryValues = _categoryService.TGetAll();
			dataGridView1.DataSource = categoryValues;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName = txtCategoryName.Text;
			category.CategoryStatus = true;
			_categoryService.TInsert(category);
			MessageBox.Show("Ekleme Başarılı");
		}
	}
}
