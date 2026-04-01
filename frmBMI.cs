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
            bool isHeightValid = double.TryParse(this.txtHeight.Text, out double heightCM);
            bool isWeightValid = double.TryParse(this.txtWeight.Text, out double weight);
            int age = (int)this.numAge.Value;

            if (isHeightValid)//身高有效
            {
                if (heightCM <= 0) {
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
                   
            double heightM = heightCM / 100; // 將身高從公分轉換為公尺

            double bmi = weight / (heightM * heightM); // BMI 計算公式：體重(kg) / 身高(m)^2

            double idealWeight = 22 * (heightM * heightM); // 理想體重計算公式：22 * 身高(m)^2，22 是一般認為的理想 BMI值

            double bmr = 0;
            if (rdoMale.Checked)
            {
                bmr = (10 * weight) + (6.25 * heightCM) - (5 * age) + 5; // 男性 BMR 計算公式：10 * 體重(kg) + 6.25 * 身高(cm) - 5 * 年齡 + 5
            }
            else
            {
                bmr = (10 * weight) + (6.25 * heightCM) - (5 * age) - 161; // 女性 BMR 計算公式：10 * 體重(kg) + 6.25 * 身高(cm) - 5 * 年齡 - 161
            }

            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = {
                ColorTranslator.FromHtml("#3498db"), // 藍
                ColorTranslator.FromHtml("#2ecc71"), // 綠
                ColorTranslator.FromHtml("#f1c40f"), // 黃
                ColorTranslator.FromHtml("#e67e22"), // 橘
                ColorTranslator.FromHtml("#e74c3c"), // 紅
                ColorTranslator.FromHtml("#6C3483")  // 紫
            };

            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;
            if (bmi < 18.5) resultIndex = 0;
            else if (bmi < 24) resultIndex = 1;
            else if (bmi < 27) resultIndex = 2;
            else if (bmi < 30) resultIndex = 3;
            else if (bmi < 35) resultIndex = 4;
            else resultIndex = 5;

            strResult = strResultList[resultIndex];
            colorResult = colorList[resultIndex];

            lblResult.Text = $"{bmi:F2} ({strResult})";
            lblResult.BackColor = colorResult;
            lblResult.Font = new Font(lblResult.Font, FontStyle.Bold); //加粗字體

            lblBMR.Text = $"基礎代謝率 (BMR) : {bmr:F0} kcal";
            lblIdeal.Text = $"理想體重 : {idealWeight:F1} kg";

            // 根據 BMI 結果給予建議
            double diff = weight - idealWeight;
            if (Math.Abs(diff) < 0.5) // 差距小於 0.5 公斤視為完美
            {
                lblAdvice.Text = "太棒了！請繼續維持目前的體態。";
            }
            else if (diff > 0)
            {
                lblAdvice.Text = $"建議減重: {Math.Abs(diff):F1} 公斤以達到理想體位。";
            }
            else
            {
                lblAdvice.Text = $"建議增重: {Math.Abs(diff):F1} 公斤以達到理想體位。";
            }

            // 取得當前的基準顏色
            Color baseColor = colorList[resultIndex];

            // 設定半透明度，建議 100~150 之間，既有顏色又不會太重
            int opacity = 120;

            // 重新合成半透明色並套用到 GroupBox
            grpInput.BackColor = Color.FromArgb(opacity, baseColor);

            // 為了讓文字在半透明背景下依然清晰，建議將 ForeColor 設為深灰色或黑色
            // 或者如果背景還是偏深，就維持白色
            grpInput.ForeColor = Color.Black;
        }


        private void frmBMI_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtHeight;//預設焦點在身高輸入框
        }
    }
}