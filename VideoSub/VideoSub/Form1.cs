using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            
            StartPosition = FormStartPosition.CenterScreen;
            btnDoChange.Location = new Point( 0, ClientRectangle.Height / 4 );
            btnDoChange.Size = new Size( ClientRectangle.Width / 2, ClientRectangle.Height / 2 );
            btnAddMenu.Location = new Point( ClientRectangle.Width / 2, ClientRectangle.Height / 4 );
            btnAddMenu.Size = new Size( ClientRectangle.Width / 2, ClientRectangle.Height / 2 );
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if ( keyData == Keys.Escape )
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey( ref msg, keyData );
        }
    }
}
