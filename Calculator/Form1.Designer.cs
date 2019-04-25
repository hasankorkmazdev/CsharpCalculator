namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main = new System.Windows.Forms.Panel();
            this.History = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.HistoryAndProccesClear = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.Shift = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.History);
            this.Main.Controls.Add(this.btnPanel);
            this.Main.Controls.Add(this.Display);
            this.Main.Controls.Add(this.panel1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(382, 491);
            this.Main.TabIndex = 0;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.BackColor = System.Drawing.SystemColors.Window;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.History.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.History.Location = new System.Drawing.Point(5, 41);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(112, 25);
            this.History.TabIndex = 10;
            this.History.Text = "HistoryCalc";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.button5);
            this.btnPanel.Controls.Add(this.button1);
            this.btnPanel.Controls.Add(this.button23);
            this.btnPanel.Controls.Add(this.button2);
            this.btnPanel.Controls.Add(this.button22);
            this.btnPanel.Controls.Add(this.HistoryAndProccesClear);
            this.btnPanel.Controls.Add(this.button11);
            this.btnPanel.Controls.Add(this.button4);
            this.btnPanel.Controls.Add(this.button16);
            this.btnPanel.Controls.Add(this.Shift);
            this.btnPanel.Controls.Add(this.button8);
            this.btnPanel.Controls.Add(this.button21);
            this.btnPanel.Controls.Add(this.button19);
            this.btnPanel.Controls.Add(this.button10);
            this.btnPanel.Controls.Add(this.button9);
            this.btnPanel.Controls.Add(this.button15);
            this.btnPanel.Controls.Add(this.button14);
            this.btnPanel.Controls.Add(this.button20);
            this.btnPanel.Controls.Add(this.button3);
            this.btnPanel.Location = new System.Drawing.Point(0, 139);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(376, 350);
            this.btnPanel.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(1, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = ",";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Gainsboro;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(189, 278);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(184, 68);
            this.button23.TabIndex = 5;
            this.button23.Text = "=";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.EqualsClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(283, 134);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(90, 68);
            this.button22.TabIndex = 5;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.OperatorClick);
            // 
            // HistoryAndProccesClear
            // 
            this.HistoryAndProccesClear.BackColor = System.Drawing.Color.Gainsboro;
            this.HistoryAndProccesClear.FlatAppearance.BorderSize = 0;
            this.HistoryAndProccesClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryAndProccesClear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistoryAndProccesClear.Location = new System.Drawing.Point(95, 1);
            this.HistoryAndProccesClear.Name = "HistoryAndProccesClear";
            this.HistoryAndProccesClear.Size = new System.Drawing.Size(90, 57);
            this.HistoryAndProccesClear.TabIndex = 5;
            this.HistoryAndProccesClear.Text = "C";
            this.HistoryAndProccesClear.UseVisualStyleBackColor = false;
            this.HistoryAndProccesClear.Click += new System.EventHandler(this.HistoryClear);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(95, 278);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 68);
            this.button11.TabIndex = 5;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(189, 134);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 68);
            this.button16.TabIndex = 5;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Shift
            // 
            this.Shift.BackColor = System.Drawing.Color.Gainsboro;
            this.Shift.FlatAppearance.BorderSize = 0;
            this.Shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shift.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Shift.Location = new System.Drawing.Point(189, 1);
            this.Shift.Name = "Shift";
            this.Shift.Size = new System.Drawing.Size(90, 57);
            this.Shift.TabIndex = 5;
            this.Shift.Text = "<--";
            this.Shift.UseVisualStyleBackColor = false;
            this.Shift.Click += new System.EventHandler(this.ShiftCClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(95, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 68);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(283, 206);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 68);
            this.button21.TabIndex = 5;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.OperatorClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gainsboro;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(283, 1);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 57);
            this.button19.TabIndex = 5;
            this.button19.Text = "/";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.OperatorClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(95, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 68);
            this.button10.TabIndex = 5;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(95, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 68);
            this.button9.TabIndex = 5;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(189, 206);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 68);
            this.button15.TabIndex = 5;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(189, 62);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 68);
            this.button14.TabIndex = 5;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gainsboro;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(283, 62);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(90, 68);
            this.button20.TabIndex = 5;
            this.button20.Text = "x";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.OperatorClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 68);
            this.button3.TabIndex = 5;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Display
            // 
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Display.Location = new System.Drawing.Point(0, 38);
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(380, 98);
            this.Display.TabIndex = 8;
            this.Display.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 38);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesap Makinesi";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(282, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(331, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 38);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 491);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Shift;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button HistoryAndProccesClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Label History;
    }
}

