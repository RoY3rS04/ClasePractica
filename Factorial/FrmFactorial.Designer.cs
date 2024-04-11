namespace Factorial
{
    partial class FrmFactorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            factorialLbl = new Label();
            getFactorialsBtn = new Button();
            factorialsTxt = new TextBox();
            SuspendLayout();
            // 
            // factorialLbl
            // 
            factorialLbl.AutoSize = true;
            factorialLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            factorialLbl.Location = new Point(41, 26);
            factorialLbl.Name = "factorialLbl";
            factorialLbl.Size = new Size(211, 25);
            factorialLbl.TabIndex = 0;
            factorialLbl.Text = "Factorials from 0 to 10";
            // 
            // getFactorialsBtn
            // 
            getFactorialsBtn.Location = new Point(41, 71);
            getFactorialsBtn.Name = "getFactorialsBtn";
            getFactorialsBtn.Size = new Size(211, 37);
            getFactorialsBtn.TabIndex = 1;
            getFactorialsBtn.Text = "Get Factorials";
            getFactorialsBtn.UseVisualStyleBackColor = true;
            getFactorialsBtn.Click += getFactorialsBtn_Click;
            // 
            // factorialsTxt
            // 
            factorialsTxt.Location = new Point(41, 136);
            factorialsTxt.Multiline = true;
            factorialsTxt.Name = "factorialsTxt";
            factorialsTxt.Size = new Size(211, 245);
            factorialsTxt.TabIndex = 2;
            // 
            // FrmFactorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 450);
            Controls.Add(factorialsTxt);
            Controls.Add(getFactorialsBtn);
            Controls.Add(factorialLbl);
            Name = "FrmFactorial";
            Text = "FrmFactorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label factorialLbl;
        private Button getFactorialsBtn;
        private TextBox factorialsTxt;
    }
}