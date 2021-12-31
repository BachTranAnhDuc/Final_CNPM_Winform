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
            // TODO: This line of code loads data into the 'eShopManagerDataSet.wareHouse' table. You can move, or remove it, as needed.
            this.wareHouseTableAdapter.Fill(this.eShopManagerDataSet.wareHouse);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            /*txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();*/
            prdID.Text = row.Cells[0].Value.ToString();
            prdName.Text = row.Cells[1].Value.ToString();
            prdQuantity.Text = row.Cells[2].Value.ToString();
            prdPriceIn.Text = row.Cells[3].Value.ToString();
            prdPriceOut.Text = row.Cells[4].Value.ToString();
        }

        private void btnWareAdd_Click(object sender, EventArgs e)
        {
            eShopManagerDataSet.wareHouseRow ware = this.eShopManagerDataSet.wareHouse.AddwareHouseRow(prdID.Text, prdName.Text, Int32.Parse(prdQuantity.Text), Int32.Parse(prdPriceIn.Text), Int32.Parse(prdPriceOut.Text));
            this.wareHouseTableAdapter.Update(ware);
            MessageBox.Show("Product add successfully!");
        }

        private void btnWareDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                    "Are you sure", "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            
            if (dr == DialogResult.Yes)
            {
                int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                eShopManagerDataSet.wareHouseRow ware = (eShopManagerDataSet.wareHouseRow)this.eShopManagerDataSet.wareHouse.Rows[rowIndex];
                ware.Delete();

                this.wareHouseTableAdapter.Update(ware);

                MessageBox.Show("Product has been deleted!");
            }
        }

        private void btnWareUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
            eShopManagerDataSet.wareHouseRow ware = (eShopManagerDataSet.wareHouseRow)this.eShopManagerDataSet.wareHouse.Rows[rowIndex];
            ware.productID = prdID.Text;
            ware.productName = prdName.Text;
            ware.quantity = Int32.Parse(prdQuantity.Text);
            ware.priceIn = Int32.Parse(prdPriceIn.Text);
            ware.priceOut = Int32.Parse(prdPriceOut.Text);

            this.wareHouseTableAdapter.Update(ware);

            MessageBox.Show("Product has been updated successfully!");
        }
    }
}
