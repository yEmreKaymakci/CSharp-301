using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampı301.BusinessLayer.Concrete;
using CSharpEgitimKampı301.DataAccessLayer.EntityFramework;

namespace CSharpEgitimKampı301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new EfProductDal());
        

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = productManager.TGetAll();
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

        }
    }
}
