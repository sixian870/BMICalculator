using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {   
            bool isHeightValid = double.TryParse(this.txtHeight.Text, out double height);
            bool isWeightValid = double.TryParse(this.txtWeight.Text, out double weight);

            if (isHeightValid)//身高有效
            {
                if (height <= 0) {
                    MessageBox.Show("身高必須大於零。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的身高數值。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isWeightValid)//體重有效
            {
                if (weight <= 0)
                {
                    MessageBox.Show("體重必須大於零。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的體重數值。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                   
            height = height / 100; // 將身高從公分轉換為公尺
            double bmi = weight / (height * height);

            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;
            if (bmi < 18.5) resultIndex = 0;
            if (bmi < 24) resultIndex = 1;
            if (bmi < 27) resultIndex = 2;
            if (bmi < 30) resultIndex = 3;
            if (bmi < 35) resultIndex = 4;
            if (bmi >= 35) resultIndex = 5;

            strResult = strResultList[resultIndex];
            colorResult = colorList[resultIndex];

            lblResult.Text = $"{bmi:F2} ({strResult})";
            lblResult.BackColor = colorResult;
        }
    }
}
