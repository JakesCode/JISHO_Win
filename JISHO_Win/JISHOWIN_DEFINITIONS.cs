using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JISHO_Win
{
    public partial class JISHOWIN_DEFINITIONS : Form
    {
        public JISHOWIN_DEFINITIONS()
        {
            InitializeComponent();

            otherMeanings.AutoScroll = true;
            otherMeanings.HorizontalScroll.Enabled = true;
            otherMeanings.HorizontalScroll.Visible = true;
            //otherMeanings.HorizontalScroll.Maximum = 0;
            otherMeanings.AutoScroll = true;
        }

        private void JISHOWIN_DEFINITIONS_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
