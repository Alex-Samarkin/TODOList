using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBindingSource.DataSource = List;
            listDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public List<TOTOItem> List { get; set; } = new List<TOTOItem>();

        private void listDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void listDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /// change the cell color
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
            try
            {
                if (e.ColumnIndex == 3)
                {
                    if (e.Value.ToString() == "True") e.CellStyle.BackColor = Color.Green;
                }
            }
            catch { }
        }
    }
}
