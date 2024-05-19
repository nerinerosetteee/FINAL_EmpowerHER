using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER.Admin_UC
{
    public partial class UC_View_Delete : UserControl
    {
        DbConnect conn = new DbConnect();
        String query;
        public UC_View_Delete()
        {
            InitializeComponent();
        }

        private void UC_View_Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
