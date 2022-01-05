using System;

namespace WindowsFormsApp2
{
    partial class 계산기
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butpercent = new System.Windows.Forms.Button();
            this.butCE = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butdivide = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.butmulti = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.butminus = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butplus = new System.Windows.Forms.Button();
            this.butplusminus = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.butdot = new System.Windows.Forms.Button();
            this.butequal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.butpercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.butdivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.but7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.but8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.but9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.butmulti, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.but4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.but5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.but6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.butminus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.but1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.but2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.but3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.butplus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.butplusminus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.but0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.butdot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.butequal, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 317);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // butpercent
            // 
            this.butpercent.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butpercent.Location = new System.Drawing.Point(3, 3);
            this.butpercent.Name = "butpercent";
            this.butpercent.Size = new System.Drawing.Size(94, 57);
            this.butpercent.TabIndex = 0;
            this.butpercent.Text = "%";
            this.butpercent.UseVisualStyleBackColor = true;
            this.butpercent.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCE
            // 
            this.butCE.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butCE.Location = new System.Drawing.Point(103, 3);
            this.butCE.Name = "butCE";
            this.butCE.Size = new System.Drawing.Size(94, 57);
            this.butCE.TabIndex = 1;
            this.butCE.Text = "CE";
            this.butCE.UseVisualStyleBackColor = true;
            this.butCE.Click += new System.EventHandler(this.button2_Click);
            // 
            // butC
            // 
            this.butC.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butC.Location = new System.Drawing.Point(203, 3);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(94, 57);
            this.butC.TabIndex = 2;
            this.butC.Text = "C";
            this.butC.UseVisualStyleBackColor = true;
            this.butC.Click += new System.EventHandler(this.button3_Click);
            // 
            // butdivide
            // 
            this.butdivide.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butdivide.Location = new System.Drawing.Point(303, 3);
            this.butdivide.Name = "butdivide";
            this.butdivide.Size = new System.Drawing.Size(94, 57);
            this.butdivide.TabIndex = 3;
            this.butdivide.Text = "/";
            this.butdivide.UseVisualStyleBackColor = true;
            this.butdivide.Click += new System.EventHandler(this.butplus_Click);
            // 
            // but7
            // 
            this.but7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but7.Location = new System.Drawing.Point(3, 66);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(94, 57);
            this.but7.TabIndex = 4;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but0_Click);
            // 
            // but8
            // 
            this.but8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but8.Location = new System.Drawing.Point(103, 66);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(94, 57);
            this.but8.TabIndex = 5;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but0_Click);
            // 
            // but9
            // 
            this.but9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but9.Location = new System.Drawing.Point(203, 66);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(94, 57);
            this.but9.TabIndex = 6;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but0_Click);
            // 
            // butmulti
            // 
            this.butmulti.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butmulti.Location = new System.Drawing.Point(303, 66);
            this.butmulti.Name = "butmulti";
            this.butmulti.Size = new System.Drawing.Size(94, 57);
            this.butmulti.TabIndex = 7;
            this.butmulti.Text = "X";
            this.butmulti.UseVisualStyleBackColor = true;
            this.butmulti.Click += new System.EventHandler(this.butplus_Click);
            // 
            // but4
            // 
            this.but4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but4.Location = new System.Drawing.Point(3, 129);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(94, 57);
            this.but4.TabIndex = 8;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but0_Click);
            // 
            // but5
            // 
            this.but5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but5.Location = new System.Drawing.Point(103, 129);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(94, 57);
            this.but5.TabIndex = 9;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but0_Click);
            // 
            // but6
            // 
            this.but6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but6.Location = new System.Drawing.Point(203, 129);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(94, 57);
            this.but6.TabIndex = 10;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but0_Click);
            // 
            // butminus
            // 
            this.butminus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butminus.Location = new System.Drawing.Point(303, 129);
            this.butminus.Name = "butminus";
            this.butminus.Size = new System.Drawing.Size(94, 57);
            this.butminus.TabIndex = 11;
            this.butminus.Text = "-";
            this.butminus.UseVisualStyleBackColor = true;
            this.butminus.Click += new System.EventHandler(this.butplus_Click);
            // 
            // but1
            // 
            this.but1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but1.Location = new System.Drawing.Point(3, 192);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(94, 57);
            this.but1.TabIndex = 12;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but0_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but2.Location = new System.Drawing.Point(103, 192);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(94, 57);
            this.but2.TabIndex = 13;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but0_Click);
            // 
            // but3
            // 
            this.but3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but3.Location = new System.Drawing.Point(203, 192);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(94, 57);
            this.but3.TabIndex = 14;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but0_Click);
            // 
            // butplus
            // 
            this.butplus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butplus.Location = new System.Drawing.Point(303, 192);
            this.butplus.Name = "butplus";
            this.butplus.Size = new System.Drawing.Size(94, 57);
            this.butplus.TabIndex = 15;
            this.butplus.Text = "+";
            this.butplus.UseVisualStyleBackColor = true;
            this.butplus.Click += new System.EventHandler(this.butplus_Click);
            // 
            // butplusminus
            // 
            this.butplusminus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butplusminus.Location = new System.Drawing.Point(3, 255);
            this.butplusminus.Name = "butplusminus";
            this.butplusminus.Size = new System.Drawing.Size(94, 59);
            this.butplusminus.TabIndex = 16;
            this.butplusminus.Text = "+/-";
            this.butplusminus.UseVisualStyleBackColor = true;
            this.butplusminus.Click += new System.EventHandler(this.button17_Click);
            // 
            // but0
            // 
            this.but0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but0.Location = new System.Drawing.Point(103, 255);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(94, 59);
            this.but0.TabIndex = 17;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // butdot
            // 
            this.butdot.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butdot.Location = new System.Drawing.Point(203, 255);
            this.butdot.Name = "butdot";
            this.butdot.Size = new System.Drawing.Size(94, 59);
            this.butdot.TabIndex = 18;
            this.butdot.Text = ".";
            this.butdot.UseVisualStyleBackColor = true;
            this.butdot.Click += new System.EventHandler(this.button19_Click);
            // 
            // butequal
            // 
            this.butequal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butequal.Location = new System.Drawing.Point(303, 255);
            this.butequal.Name = "butequal";
            this.butequal.Size = new System.Drawing.Size(94, 59);
            this.butequal.TabIndex = 19;
            this.butequal.Text = "=";
            this.butequal.UseVisualStyleBackColor = true;
            this.butequal.Click += new System.EventHandler(this.butequal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "계산기";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

      
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butpercent;
        private System.Windows.Forms.Button butCE;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butdivide;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button butmulti;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button butminus;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button butplus;
        private System.Windows.Forms.Button butplusminus;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button butdot;
        private System.Windows.Forms.Button butequal;
    }
}

