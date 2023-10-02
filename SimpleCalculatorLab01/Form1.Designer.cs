namespace SimpleCalculatorLab01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            lbl3 = new Label();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDivide = new Button();
            btnMod = new Button();
            btnClr = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(45, 71);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(156, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "First Number";
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(45, 142);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(189, 32);
            lbl2.TabIndex = 0;
            lbl2.Text = "Second Number";
            lbl2.Click += label1_Click;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstNumber.Location = new Point(275, 71);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(224, 33);
            txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondNumber.Location = new Point(275, 141);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(224, 33);
            txtSecondNumber.TabIndex = 1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(45, 217);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(80, 32);
            lbl3.TabIndex = 0;
            lbl3.Text = "Result";
            lbl3.Click += label1_Click;
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(275, 216);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(224, 33);
            txtResult.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(108, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 48);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(253, 290);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(107, 48);
            btnSub.TabIndex = 2;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(392, 290);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(107, 48);
            btnMult.TabIndex = 2;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(108, 344);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(107, 48);
            btnDivide.TabIndex = 2;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(253, 344);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(107, 48);
            btnMod.TabIndex = 2;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnClr
            // 
            btnClr.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClr.Location = new Point(392, 344);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(107, 48);
            btnClr.TabIndex = 2;
            btnClr.Text = "Clr";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 443);
            Controls.Add(btnClr);
            Controls.Add(btnMod);
            Controls.Add(btnMult);
            Controls.Add(btnDivide);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Label lbl3;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnDivide;
        private Button btnMod;
        private Button btnClr;
    }
}