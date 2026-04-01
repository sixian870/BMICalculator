namespace BMI計算機
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBMR = new System.Windows.Forms.Label();
            this.lblIdeal = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grpInput.Controls.Add(this.numAge);
            this.grpInput.Controls.Add(this.lblAge);
            this.grpInput.Controls.Add(this.lblGender);
            this.grpInput.Controls.Add(this.rdoFemale);
            this.grpInput.Controls.Add(this.rdoMale);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(27, 46);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(491, 254);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "資料輸入";
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(166, 164);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(139, 34);
            this.txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(166, 106);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(139, 34);
            this.txtHeight.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRun.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.Location = new System.Drawing.Point(337, 106);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(114, 92);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeight.Location = new System.Drawing.Point(37, 164);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(105, 30);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHeight.Location = new System.Drawing.Point(37, 106);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(111, 30);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高(cm)";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grpOutput.Controls.Add(this.lblAdvice);
            this.grpOutput.Controls.Add(this.lblIdeal);
            this.grpOutput.Controls.Add(this.lblBMR);
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBMI);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(27, 317);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(491, 293);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "分析報告";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(250, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(201, 30);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBMI.Location = new System.Drawing.Point(26, 49);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(218, 30);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "身體質量指數(BMI)";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.rdoMale.Location = new System.Drawing.Point(113, 48);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(57, 29);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(179, 48);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(57, 29);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblGender.Location = new System.Drawing.Point(37, 48);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 30);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "性別";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblAge.Location = new System.Drawing.Point(263, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(61, 30);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "年齡";
            // 
            // lblBMR
            // 
            this.lblBMR.AutoSize = true;
            this.lblBMR.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblBMR.Location = new System.Drawing.Point(26, 106);
            this.lblBMR.Name = "lblBMR";
            this.lblBMR.Size = new System.Drawing.Size(214, 30);
            this.lblBMR.TabIndex = 9;
            this.lblBMR.Text = "基礎代謝率(BMR) :";
            // 
            // lblIdeal
            // 
            this.lblIdeal.AutoSize = true;
            this.lblIdeal.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblIdeal.Location = new System.Drawing.Point(26, 164);
            this.lblIdeal.Name = "lblIdeal";
            this.lblIdeal.Size = new System.Drawing.Size(165, 30);
            this.lblIdeal.TabIndex = 10;
            this.lblIdeal.Text = "理想體重(kg) :";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(337, 46);
            this.numAge.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(114, 34);
            this.numAge.TabIndex = 9;
            this.numAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAdvice.Location = new System.Drawing.Point(26, 222);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(121, 30);
            this.lblAdvice.TabIndex = 11;
            this.lblAdvice.Text = "體重建議 :";
            // 
            // frmBMI
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(549, 656);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI計算機";
            this.Load += new System.EventHandler(this.frmBMI_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblIdeal;
        private System.Windows.Forms.Label lblBMR;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblAdvice;
    }
}

