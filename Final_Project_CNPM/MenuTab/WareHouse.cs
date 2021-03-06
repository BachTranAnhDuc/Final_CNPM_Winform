using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_CNPM.MenuTab
{
    public partial class WareHouse : Form
    {
        public WareHouse()
        {
            InitializeComponent();
        }

        private void WareHouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eShopManagerDataSet1.wareHouse' table. You can move, or remove it, as needed.
            this.wareHouseTableAdapter1.Fill(this.eShopManagerDataSet1.wareHouse);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            prdID.Text = row.Cells[0].Value.ToString();
            prdName.Text = row.Cells[1].Value.ToString();
            prdQuantity.Text = row.Cells[2].Value.ToString();
            prdPriceIn.Text = row.Cells[3].Value.ToString();
            prdPriceOut.Text = row.Cells[4].Value.ToString();
            prdCateName.Text = row.Cells[5].Value.ToString();
            prdEmID.Text = row.Cells[6].Value.ToString();
        }

        private void btnWareAdd_Click(object sender, EventArgs e)
        {
            /*eShopManagerDataSet1.wareHouse ware = this.eShopManagerDataSet1.wareHouse.AddwareHouseRow(prdID.Text, prdName.Text, Int32.Parse(prdQuantity.Text), Int32.Parse(prdPriceIn.Text), Int32.Parse(prdPriceOut.Text), prdCateName.Text, prdEmID.Text);
            this.wareHouseBindingSource1.Update(ware);
            MessageBox.Show("Product add successfully!");*/

            eShopManagerDataSet1.wareHouse ware = this.eShopManagerDataSet1.wareHouse.AddwareHouseRow(prdID.Text, prdName.Text, Int32.Parse(prdQuantity.Text), Int32.Parse(prdPriceIn.Text), Int32.Parse(prdPriceOut.Text), prdCateName.Text, prdEmID.Text);
        }

        private void btnWareDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                    "Are you sure", "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            
            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                eShopManagerDataSet1.wareHouseRow ware = (eShopManagerDataSet1.wareHouseRow)this.eShopManagerDataSet1.wareHouse.Rows[rowIndex];
                ware.Delete();

                this.wareHouseTableAdapter.Update(ware);

                MessageBox.Show("Product has been deleted!");
            }
        }

        private void btnWareUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
            eShopManagerDataSet1.wareHouseRow ware = (eShopManagerDataSet1.wareHouseRow)this.eShopManagerDataSet1.wareHouse.Rows[rowIndex];
            ware.productID = prdID.Text;
            ware.productName = prdName.Text;
            ware.quantity = Int32.Parse(prdQuantity.Text);
            ware.priceIn = Int32.Parse(prdPriceIn.Text);
            ware.priceOut = Int32.Parse(prdPriceOut.Text);
            ware.categoryName = prdCateName.Text;
            ware.employeeID = prdEmID.Text;


            this.wareHouseTableAdapter.Update(ware);

            MessageBox.Show("Product has been updated successfully!");
        }
    }
}
