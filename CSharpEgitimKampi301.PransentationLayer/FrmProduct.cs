using CSharpEgitimKampi301.BusinesLayer.Abstract;
using CSharpEgitimKampi301.BusinesLayer.Concrete;
using CSharpEgitimKampi301.DataAccesLayer.EntityFramework;
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
	public partial class FrmProduct : Form
	{
		private readonly IProductService _productService;
		public FrmProduct()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{

		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetAll();
			dataGridView1.DataSource = values;
		}

		private void btnList2_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetProductsWithCategory();
			dataGridView1.DataSource= values;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
