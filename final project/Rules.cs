using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class lnkRules : Form
    {
        public lnkRules()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dhhim4ltzu1pj.cloudfront.net/media/documents/FaB_Comprehensive_Rules_v2_4_0.pdf");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|* CompRules.pdf";
            saveFileDialog.Title = "save file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("finalproject.CompRules.pdf");
                using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    stream.CopyTo(fileStream);
                }
            }
        }
    }
}
