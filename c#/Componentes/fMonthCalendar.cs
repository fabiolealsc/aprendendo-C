using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fMonthCalendar : Form
    {
        public fMonthCalendar()
        {
            InitializeComponent();
        }

        private void btnPegarData_Click(object sender, EventArgs e)
        {
            textBox2.Text =  monthCalendar1.SelectionStart.ToShortDateString();
            textBox1.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
