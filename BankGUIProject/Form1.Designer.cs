namespace BankGUIProject
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
            Checking = new ListBox();
            Savings = new ListBox();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            num0 = new Button();
            Reset = new Button();
            Decimal = new Button();
            Transfer1 = new Button();
            Transfer2 = new Button();
            Add1 = new Button();
            Add2 = new Button();
            Subtract1 = new Button();
            Subtract2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // Checking
            // 
            Checking.FormattingEnabled = true;
            Checking.ItemHeight = 25;
            Checking.Location = new Point(12, 75);
            Checking.Name = "Checking";
            Checking.Size = new Size(911, 479);
            Checking.TabIndex = 0;
            // 
            // Savings
            // 
            Savings.FormattingEnabled = true;
            Savings.ItemHeight = 25;
            Savings.Location = new Point(12, 651);
            Savings.Name = "Savings";
            Savings.Size = new Size(911, 479);
            Savings.TabIndex = 1;
            // 
            // num1
            // 
            num1.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num1.Location = new Point(964, 75);
            num1.Name = "num1";
            num1.Size = new Size(180, 180);
            num1.TabIndex = 2;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Arial Narrow", 36F);
            num2.Location = new Point(1168, 75);
            num2.Name = "num2";
            num2.Size = new Size(180, 180);
            num2.TabIndex = 3;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Arial Narrow", 36F);
            num3.Location = new Point(1373, 75);
            num3.Name = "num3";
            num3.Size = new Size(180, 180);
            num3.TabIndex = 4;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Arial Narrow", 36F);
            num4.Location = new Point(964, 279);
            num4.Name = "num4";
            num4.Size = new Size(180, 180);
            num4.TabIndex = 5;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Arial Narrow", 36F);
            num5.Location = new Point(1168, 279);
            num5.Name = "num5";
            num5.Size = new Size(180, 180);
            num5.TabIndex = 6;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Arial Narrow", 36F);
            num6.Location = new Point(1373, 279);
            num6.Name = "num6";
            num6.Size = new Size(180, 180);
            num6.TabIndex = 7;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num7
            // 
            num7.Font = new Font("Arial Narrow", 36F);
            num7.Location = new Point(964, 493);
            num7.Name = "num7";
            num7.Size = new Size(180, 180);
            num7.TabIndex = 8;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Arial Narrow", 36F);
            num8.Location = new Point(1168, 493);
            num8.Name = "num8";
            num8.Size = new Size(180, 180);
            num8.TabIndex = 9;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Arial Narrow", 36F);
            num9.Location = new Point(1374, 493);
            num9.Name = "num9";
            num9.Size = new Size(180, 180);
            num9.TabIndex = 10;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num0
            // 
            num0.Font = new Font("Arial Narrow", 36F);
            num0.Location = new Point(1586, 493);
            num0.Name = "num0";
            num0.Size = new Size(180, 180);
            num0.TabIndex = 11;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num1_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reset.Location = new Point(1586, 75);
            Reset.Name = "Reset";
            Reset.Size = new Size(180, 180);
            Reset.TabIndex = 12;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // Decimal
            // 
            Decimal.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Decimal.Location = new Point(1586, 279);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(180, 180);
            Decimal.TabIndex = 14;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            // 
            // Transfer1
            // 
            Transfer1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transfer1.Location = new Point(964, 689);
            Transfer1.Name = "Transfer1";
            Transfer1.Size = new Size(384, 150);
            Transfer1.TabIndex = 15;
            Transfer1.Text = "Transfer to Checking";
            Transfer1.UseVisualStyleBackColor = true;
            // 
            // Transfer2
            // 
            Transfer2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transfer2.Location = new Point(1373, 689);
            Transfer2.Name = "Transfer2";
            Transfer2.Size = new Size(393, 150);
            Transfer2.TabIndex = 16;
            Transfer2.Text = "Transfer to Savings";
            Transfer2.UseVisualStyleBackColor = true;
            // 
            // Add1
            // 
            Add1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add1.Location = new Point(53, 714);
            Add1.Name = "Add1";
            Add1.Size = new Size(406, 150);
            Add1.TabIndex = 17;
            Add1.Text = "Deposit to Checking";
            Add1.UseVisualStyleBackColor = true;
            // 
            // Add2
            // 
            Add2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add2.Location = new Point(485, 714);
            Add2.Name = "Add2";
            Add2.Size = new Size(406, 150);
            Add2.TabIndex = 18;
            Add2.Text = "Deposit to Saving";
            Add2.UseVisualStyleBackColor = true;
            // 
            // Subtract1
            // 
            Subtract1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Subtract1.Location = new Point(53, 870);
            Subtract1.Name = "Subtract1";
            Subtract1.Size = new Size(406, 150);
            Subtract1.TabIndex = 19;
            Subtract1.Text = "Withdraw from Checking";
            Subtract1.UseVisualStyleBackColor = true;
            // 
            // Subtract2
            // 
            Subtract2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Subtract2.Location = new Point(485, 870);
            Subtract2.Name = "Subtract2";
            Subtract2.Size = new Size(406, 150);
            Subtract2.TabIndex = 20;
            Subtract2.Text = "Withdraw from Savings";
            Subtract2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 21;
            label1.Text = "Checking Account: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 582);
            label2.Name = "label2";
            label2.Size = new Size(279, 46);
            label2.TabIndex = 22;
            label2.Text = "Savings Account: ";
            // 
            // txt1
            // 
            txt1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt1.Location = new Point(964, 16);
            txt1.Name = "txt1";
            txt1.Size = new Size(777, 49);
            txt1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1778, 1167);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Subtract2);
            Controls.Add(Subtract1);
            Controls.Add(Add2);
            Controls.Add(Add1);
            Controls.Add(Transfer2);
            Controls.Add(Transfer1);
            Controls.Add(Decimal);
            Controls.Add(Reset);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(Savings);
            Controls.Add(Checking);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Checking;
        private ListBox Savings;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button num0;
        private Button Decimal;
        private Button Transfer1;
        private Button Transfer2;
        private Button Add1;
        private Button Add2;
        private Button Subtract1;
        private Button Subtract2;
        private Button Reset;
        private Label label1;
        private Label label2;
        private TextBox txt1;
    }
}
