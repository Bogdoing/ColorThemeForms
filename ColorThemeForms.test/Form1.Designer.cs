namespace ColorThemeForms.test
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
            tb = new TextBox();
            btn = new Button();
            liteTheme = new RadioButton();
            darkTheme = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            enPerformans = new RadioButton();
            enBalance = new RadioButton();
            enSave = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb.Location = new Point(12, 12);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.Size = new Size(330, 30);
            tb.TabIndex = 0;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn.Location = new Point(225, 125);
            btn.Name = "btn";
            btn.Size = new Size(117, 51);
            btn.TabIndex = 1;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // liteTheme
            // 
            liteTheme.AutoSize = true;
            liteTheme.Location = new Point(3, 3);
            liteTheme.Name = "liteTheme";
            liteTheme.Size = new Size(100, 24);
            liteTheme.TabIndex = 2;
            liteTheme.TabStop = true;
            liteTheme.Text = "Lite theme";
            liteTheme.UseVisualStyleBackColor = true;
            liteTheme.Enter += onLiteTheme;
            // 
            // darkTheme
            // 
            darkTheme.AutoSize = true;
            darkTheme.Location = new Point(109, 3);
            darkTheme.Name = "darkTheme";
            darkTheme.Size = new Size(110, 24);
            darkTheme.TabIndex = 3;
            darkTheme.TabStop = true;
            darkTheme.Text = "Dark Theme";
            darkTheme.UseVisualStyleBackColor = true;
            darkTheme.Enter += onDarkTheme;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(liteTheme);
            panel1.Controls.Add(darkTheme);
            panel1.Location = new Point(12, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 32);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(enPerformans);
            panel2.Controls.Add(enBalance);
            panel2.Controls.Add(enSave);
            panel2.Location = new Point(12, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 33);
            panel2.TabIndex = 5;
            // 
            // enPerformans
            // 
            enPerformans.AutoSize = true;
            enPerformans.Location = new Point(218, 3);
            enPerformans.Name = "enPerformans";
            enPerformans.Size = new Size(104, 24);
            enPerformans.TabIndex = 2;
            enPerformans.TabStop = true;
            enPerformans.Text = "Performans";
            enPerformans.UseVisualStyleBackColor = true;
            enPerformans.Enter += onPerformans;
            // 
            // enBalance
            // 
            enBalance.AutoSize = true;
            enBalance.Location = new Point(130, 3);
            enBalance.Name = "enBalance";
            enBalance.Size = new Size(82, 24);
            enBalance.TabIndex = 1;
            enBalance.TabStop = true;
            enBalance.Text = "Balance";
            enBalance.UseVisualStyleBackColor = true;
            enBalance.Enter += onBalans;
            // 
            // enSave
            // 
            enSave.AutoSize = true;
            enSave.Location = new Point(3, 3);
            enSave.Name = "enSave";
            enSave.Size = new Size(121, 24);
            enSave.TabIndex = 0;
            enSave.TabStop = true;
            enSave.Text = "Energy saving";
            enSave.UseVisualStyleBackColor = true;
            enSave.Enter += onSaving;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 188);
            Controls.Add(panel2);
            Controls.Add(btn);
            Controls.Add(tb);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb;
        private Button btn;
        private RadioButton liteTheme;
        private RadioButton darkTheme;
        private Panel panel1;
        private Panel panel2;
        private RadioButton enPerformans;
        private RadioButton enBalance;
        private RadioButton enSave;
    }
}