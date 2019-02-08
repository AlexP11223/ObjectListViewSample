using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectListViewSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += (sender, args) => new Form2().Show();
        } 
    }
}
