using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Memo_Part
{
    public partial class Form3 : Form2
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txtWord.Text == "")
            {
                this.btnOk.Enabled = false; //버튼 비활성화
            }
            else
            {
                this.btnOk.Enabled = true; //버튼 활성화
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close(); //폼3 종료
        }


    }
}
