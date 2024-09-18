using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 실행 프로그램 작성
            // button1버튼 클릭시에 label영역에 "안녕 나는 C#이야" 라는 Text로 변한다. 
            label1.Text = "안녕 나는 C#이야";
        }
    }
}
