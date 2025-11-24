using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampı301.BusinessLayer.Abstract;
using CSharpEgitimKampı301.BusinessLayer.Concrete;
using CSharpEgitimKampı301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampı301.PresentationLayer
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
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }
        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategory.DataSource = values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme işlemi yapıldı ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryID = int.Parse(cmbCategory.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.ProductDescription = txtDescription.Text;
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi yapıldı ");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int id))
            {
                MessageBox.Show("Lütfen Ürün ID alanına geçerli bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var value = _productService.TGetById(id);
            if (value != null)
            {
                txtProductName.Text = value.ProductName;
                txtProductPrice.Text = value.ProductPrice.ToString();
                txtProductStock.Text = value.ProductStock.ToString();
                txtDescription.Text = value.ProductDescription;
                MessageBox.Show($"{value.ProductName} adlı ürün başarıyla getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"ID'si {id} olan bir ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Clear();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.CategoryID = int.Parse(cmbCategory.SelectedValue.ToString());
            value.ProductDescription = txtDescription.Text;
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme işlemi yapıldı ");
        }
    }
}
