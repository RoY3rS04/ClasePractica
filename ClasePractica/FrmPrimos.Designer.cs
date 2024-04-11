namespace NumerosPrimos
{
    partial class FrmPrimos
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
            titleLbl = new Label();
            rangeTb = new TrackBar();
            rangeLbl = new Label();
            rangeValLbl = new Label();
            findPrimesBtn = new Button();
            primeNumbersTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)rangeTb).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(50, 25);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(279, 21);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Find Prime Numbers Between A Range";
            // 
            // rangeTb
            // 
            rangeTb.Location = new Point(50, 72);
            rangeTb.Maximum = 1000000;
            rangeTb.Name = "rangeTb";
            rangeTb.Size = new Size(279, 45);
            rangeTb.TabIndex = 1;
            rangeTb.Scroll += rangeTb_Scroll;
            // 
            // rangeLbl
            // 
            rangeLbl.AutoSize = true;
            rangeLbl.Location = new Point(50, 131);
            rangeLbl.Name = "rangeLbl";
            rangeLbl.Size = new Size(70, 15);
            rangeLbl.TabIndex = 2;
            rangeLbl.Text = "Your Range:";
            // 
            // rangeValLbl
            // 
            rangeValLbl.AutoSize = true;
            rangeValLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rangeValLbl.Location = new Point(143, 127);
            rangeValLbl.Name = "rangeValLbl";
            rangeValLbl.Size = new Size(0, 20);
            rangeValLbl.TabIndex = 3;
            // 
            // findPrimesBtn
            // 
            findPrimesBtn.Location = new Point(50, 170);
            findPrimesBtn.Name = "findPrimesBtn";
            findPrimesBtn.Size = new Size(115, 34);
            findPrimesBtn.TabIndex = 4;
            findPrimesBtn.Text = "Find Numbers";
            findPrimesBtn.UseVisualStyleBackColor = true;
            findPrimesBtn.Click += findPrimesBtn_Click;
            // 
            // primeNumbersTxt
            // 
            primeNumbersTxt.Location = new Point(54, 236);
            primeNumbersTxt.Multiline = true;
            primeNumbersTxt.Name = "primeNumbersTxt";
            primeNumbersTxt.ScrollBars = ScrollBars.Vertical;
            primeNumbersTxt.Size = new Size(275, 169);
            primeNumbersTxt.TabIndex = 5;
            // 
            // FrmPrimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(primeNumbersTxt);
            Controls.Add(findPrimesBtn);
            Controls.Add(rangeValLbl);
            Controls.Add(rangeLbl);
            Controls.Add(rangeTb);
            Controls.Add(titleLbl);
            Name = "FrmPrimos";
            Text = "FrmPrimos";
            ((System.ComponentModel.ISupportInitialize)rangeTb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private TrackBar rangeTb;
        private Label rangeLbl;
        private Label rangeValLbl;
        private Button findPrimesBtn;
        private TextBox primeNumbersTxt;
    }
}