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
	public partial class FrmProduct : Form
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;
		public FrmProduct()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
			_categoryService = new CategoryManager(new EfCategoryDal());
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var values = _categoryService.TGetAll();
			comboBox1.DataSource = values;
			comboBox1.DisplayMember = "CategoryName";
			comboBox1.ValueMember = "CategoryId";
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
			int id = int.Parse(txtProductID.Text);
			var value = _productService.TGetById(id);
			_productService.TDelete(value);
			MessageBox.Show("silme işlemi başarılı");

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Product  product = new Product();
			product.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
			product.ProductPrice = decimal.Parse(txtProductPrice.Text);
			product.ProductName = txtProductName.Text;
			product.ProductDescription = txtProductDescription.Text;
			product.ProductStock = int.Parse(txtProductStock.Text);
			_productService.TInsert(product);
			MessageBox.Show("Ekleme işlemleri yapıldı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductID.Text);
			var value = _productService.TGetById(id);
			dataGridView1.DataSource = value;



		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductID.Text);
			var value = _productService.TGetById(id);
			value.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
			value.ProductDescription = txtProductDescription.Text;
			value.ProductPrice = decimal.Parse(txtProductPrice.Text);
			value.ProductStock = int.Parse(txtProductStock.Text);
			value.ProductName = txtProductName.Text;
			_productService.TUpdate(value);
			MessageBox.Show("Güncelleme işlemi başarıyla yapıldı");
		}
	}
}
