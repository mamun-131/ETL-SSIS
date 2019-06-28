using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunPackage1_Click(object sender, EventArgs e)
        {

      string pkgLocation;
            Package pkg;
            Microsoft.SqlServer.Dts.Runtime.Application app;
            DTSExecResult pkgResults;

            pkgLocation = @"C:\Mamun\Semester6\COMP307_DataWearhouse\ForWalmart\SSDT1\ETL-SSIS\SSDT1\Package_DataDownload.dtsx";
            app = new Microsoft.SqlServer.Dts.Runtime.Application();
            pkg = app.LoadPackage(pkgLocation, null);
            pkgResults = pkg.Execute();

            if (pkgResults == DTSExecResult.Success)
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error");
        }
    }
}
