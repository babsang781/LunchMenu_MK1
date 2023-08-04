namespace LunchMenu_MK1
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
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            panel2 = new Panel();
            linkLblLunch1 = new LinkLabel();
            btnLunch1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(169, 6);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 353);
            vScrollBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 1;
            label1.Text = "잡동사니";
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLblLunch1);
            panel2.Controls.Add(btnLunch1);
            panel2.Location = new Point(263, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 367);
            panel2.TabIndex = 3;
            // 
            // linkLblLunch1
            // 
            linkLblLunch1.AutoSize = true;
            linkLblLunch1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblLunch1.Location = new Point(147, 209);
            linkLblLunch1.Name = "linkLblLunch1";
            linkLblLunch1.Size = new Size(229, 21);
            linkLblLunch1.TabIndex = 2;
            linkLblLunch1.TabStop = true;
            linkLblLunch1.Text = "오늘의 점심 메뉴는 뭘까~요??";
            linkLblLunch1.LinkClicked += linkLblLunch1_LinkClicked;
            // 
            // btnLunch1
            // 
            btnLunch1.Font = new Font("맑은 고딕", 35F, FontStyle.Regular, GraphicsUnit.Point);
            btnLunch1.Location = new Point(44, 34);
            btnLunch1.Name = "btnLunch1";
            btnLunch1.Size = new Size(427, 81);
            btnLunch1.TabIndex = 0;
            btnLunch1.Text = "나와라 점심 메뉴!";
            btnLunch1.UseVisualStyleBackColor = true;
            btnLunch1.Click += btnLunch1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 28);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "점심 메뉴 추천 - 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(vScrollBar1);
            panel1.Location = new Point(9, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 359);
            panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(14, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "* 점심 메뉴 추천 - 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLblLunch1;
        private Button btnLunch1;
    }
}