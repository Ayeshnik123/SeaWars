using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWars
{
    public partial class Pole : Form
    {
        public Pole()
        {
            InitializeComponent();

        }

        private void Pole_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dataGridView1.ReadOnly = true; //запрет на ввод данных
            dataGridView2.ReadOnly = true; //запрет на ввод данных

            // конструктор поля
            //первое поле
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
            dataGridView1.Columns[0].HeaderText = "А";
            dataGridView1.Columns[1].HeaderText = "Б";
            dataGridView1.Columns[2].HeaderText = "В";
            dataGridView1.Columns[3].HeaderText = "Г";
            dataGridView1.Columns[4].HeaderText = "Д";
            dataGridView1.Columns[5].HeaderText = "Е";
            dataGridView1.Columns[6].HeaderText = "Ж";
            dataGridView1.Columns[7].HeaderText = "З";
            dataGridView1.Columns[8].HeaderText = "И";
            dataGridView1.Columns[9].HeaderText = "К";
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            dataGridView1.Rows[1].HeaderCell.Value = "2";
            dataGridView1.Rows[2].HeaderCell.Value = "3";
            dataGridView1.Rows[3].HeaderCell.Value = "4";
            dataGridView1.Rows[4].HeaderCell.Value = "5";
            dataGridView1.Rows[5].HeaderCell.Value = "6";
            dataGridView1.Rows[6].HeaderCell.Value = "7";
            dataGridView1.Rows[7].HeaderCell.Value = "8";
            dataGridView1.Rows[8].HeaderCell.Value = "9";
            dataGridView1.Rows[9].HeaderCell.Value = "10";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //второе поле
            dataGridView2.ColumnCount = 10;
            dataGridView2.RowCount = 10;
            dataGridView2.Columns[0].HeaderText = "А";
            dataGridView2.Columns[1].HeaderText = "Б";
            dataGridView2.Columns[2].HeaderText = "В";
            dataGridView2.Columns[3].HeaderText = "Г";
            dataGridView2.Columns[4].HeaderText = "Д";
            dataGridView2.Columns[5].HeaderText = "Е";
            dataGridView2.Columns[6].HeaderText = "Ж";
            dataGridView2.Columns[7].HeaderText = "З";
            dataGridView2.Columns[8].HeaderText = "И";
            dataGridView2.Columns[9].HeaderText = "К";
            dataGridView2.Rows[0].HeaderCell.Value = "1";
            dataGridView2.Rows[1].HeaderCell.Value = "2";
            dataGridView2.Rows[2].HeaderCell.Value = "3";
            dataGridView2.Rows[3].HeaderCell.Value = "4";
            dataGridView2.Rows[4].HeaderCell.Value = "5";
            dataGridView2.Rows[5].HeaderCell.Value = "6";
            dataGridView2.Rows[6].HeaderCell.Value = "7";
            dataGridView2.Rows[7].HeaderCell.Value = "8";
            dataGridView2.Rows[8].HeaderCell.Value = "9";
            dataGridView2.Rows[9].HeaderCell.Value = "10";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //первое поле
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
            dataGridView1.Columns[0].HeaderText = "А";
            dataGridView1.Columns[1].HeaderText = "Б";
            dataGridView1.Columns[2].HeaderText = "В";
            dataGridView1.Columns[3].HeaderText = "Г";
            dataGridView1.Columns[4].HeaderText = "Д";
            dataGridView1.Columns[5].HeaderText = "Е";
            dataGridView1.Columns[6].HeaderText = "Ж";
            dataGridView1.Columns[7].HeaderText = "З";
            dataGridView1.Columns[8].HeaderText = "И";
            dataGridView1.Columns[9].HeaderText = "К";
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            dataGridView1.Rows[1].HeaderCell.Value = "2";
            dataGridView1.Rows[2].HeaderCell.Value = "3";
            dataGridView1.Rows[3].HeaderCell.Value = "4";
            dataGridView1.Rows[4].HeaderCell.Value = "5";
            dataGridView1.Rows[5].HeaderCell.Value = "6";
            dataGridView1.Rows[6].HeaderCell.Value = "7";
            dataGridView1.Rows[7].HeaderCell.Value = "8";
            dataGridView1.Rows[8].HeaderCell.Value = "9";
            dataGridView1.Rows[9].HeaderCell.Value = "10";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //второе поле
            dataGridView2.ColumnCount = 10;
            dataGridView2.RowCount = 10;
            dataGridView2.Columns[0].HeaderText = "А";
            dataGridView2.Columns[1].HeaderText = "Б";
            dataGridView2.Columns[2].HeaderText = "В";
            dataGridView2.Columns[3].HeaderText = "Г";
            dataGridView2.Columns[4].HeaderText = "Д";
            dataGridView2.Columns[5].HeaderText = "Е";
            dataGridView2.Columns[6].HeaderText = "Ж";
            dataGridView2.Columns[7].HeaderText = "З";
            dataGridView2.Columns[8].HeaderText = "И";
            dataGridView2.Columns[9].HeaderText = "К";
            dataGridView2.Rows[0].HeaderCell.Value = "1";
            dataGridView2.Rows[1].HeaderCell.Value = "2";
            dataGridView2.Rows[2].HeaderCell.Value = "3";
            dataGridView2.Rows[3].HeaderCell.Value = "4";
            dataGridView2.Rows[4].HeaderCell.Value = "5";
            dataGridView2.Rows[5].HeaderCell.Value = "6";
            dataGridView2.Rows[6].HeaderCell.Value = "7";
            dataGridView2.Rows[7].HeaderCell.Value = "8";
            dataGridView2.Rows[8].HeaderCell.Value = "9";
            dataGridView2.Rows[9].HeaderCell.Value = "10";


            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[i,j].Style.BackColor = Color.White;
                }
            for (int i = 0; i < dataGridView2.RowCount; i++)
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2[i, j].Style.BackColor = Color.White;
                }

            groupBox1.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
               this.dataGridView1.CurrentCell.Style.BackColor = Color.Black;
            }
            if (radioButton2.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                        int poskol = dataGridView1.CurrentCell.ColumnIndex;
                        int posstr = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;
                    }
            }
            if (radioButton3.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                        int poskol = dataGridView1.CurrentCell.ColumnIndex;
                        int posstr = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;
                        dataGridView1[poskol + 2, posstr].Style.BackColor = Color.Black;
                    }
            }
            if (radioButton4.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.CurrentCell.Style.BackColor = Color.Black;
                        int poskol = dataGridView1.CurrentCell.ColumnIndex;
                        int posstr = dataGridView1.CurrentCell.RowIndex;
                        dataGridView1[poskol + 1, posstr].Style.BackColor = Color.Black;
                        dataGridView1[poskol + 2, posstr].Style.BackColor = Color.Black;
                        dataGridView1[poskol + 3, posstr].Style.BackColor = Color.Black;
                    }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2.CurrentCell.Style.BackColor = Color.Red;
        }

        private void korabli_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Enabled = true;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView2.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }
    }
}
