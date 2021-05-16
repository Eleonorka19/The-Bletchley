using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Bletchley__code_breakers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] nums = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] choseNum = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Random rd = new Random();
                int randomIndex = rd.Next(0, 7);
                choseNum[i] = randomIndex;
            }
        }
    }
}
