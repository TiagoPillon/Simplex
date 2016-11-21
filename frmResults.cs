using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simplex
{
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
        }

        public void AdicionarControle(Control controle)
        {
            controle.Dock = DockStyle.Top;
            controle.BringToFront();
            panContent.Controls.Add(controle);            
            
        }
}
