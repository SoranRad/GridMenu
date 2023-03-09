using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetFramework.Models;

namespace DotNetFramework
{
    public partial class FormMain : Form
    {
        private List<Person> People;

        public FormMain()
        {
            InitializeComponent();
            
            gridMenu1.AddItem();
            gridMenu2.AddItem();
            gridMenu3.AddItem();

            toolStripDropDownButton1.DropDown = gridMenu2;
            toolStripDropDownButton2.DropDown = gridMenuFun2;
            FileMenu.DropDown = gridMenu3;

            gridMenuFun1.AddItem();
            gridMenuFun2.AddItem();
            popupControl1.AddItem();

            People = new List<Person>()
            {
                new Person()
                {
                    Name = "James",Family = "Ford" , Age = 40
                },
                new Person()
                {
                    Name = "Nicol",Family = "Kiddy" , Age = 25
                },
                new Person()
                {
                    Name = "Nicolas",Family = "cage" , Age = 65
                },
            };

            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Width = 25,
                
            });
            dataGridView1.DataSource = People;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            gridMenu1.Show(this.btnGridMenu1, new Point(0, btnGridMenu1.Height), ToolStripDropDownDirection.BelowRight);
        }

        private void btnGridMenu2_Click(object sender, EventArgs e)
        {
            gridMenuFun1.Show(this.btnGridMenu2, new Point(0, btnGridMenu2.Height), ToolStripDropDownDirection.BelowRight);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var rec = dataGridView1.GetCellDisplayRectangle(0, e.RowIndex, true);
                var point =new Point(rec.Location.X,rec.Location.Y + rec.Height); 
                gridMenu1.Show(dataGridView1, point, ToolStripDropDownDirection.BelowRight);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            popupControl1.Show(this.button1, new Point(0, button1.Height), ToolStripDropDownDirection.BelowRight);

        }

        private void FileMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
