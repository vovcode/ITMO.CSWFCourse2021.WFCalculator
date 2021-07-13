
namespace SimpleCalculator
{
    partial class SqrtEquation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.ansOut = new System.Windows.Forms.RichTextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ax^2 + bx + c = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите b";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(128, 60);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(51, 20);
            this.tb_a.TabIndex = 4;
            this.tb_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_a_KeyPress);
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(127, 86);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(51, 20);
            this.tb_b.TabIndex = 5;
            this.tb_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_b_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите c";
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(127, 111);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(51, 20);
            this.tb_c.TabIndex = 7;
            this.tb_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_c_KeyPress);
            // 
            // ansOut
            // 
            this.ansOut.Location = new System.Drawing.Point(194, 47);
            this.ansOut.Name = "ansOut";
            this.ansOut.Size = new System.Drawing.Size(241, 104);
            this.ansOut.TabIndex = 8;
            this.ansOut.Text = "";
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolve.Location = new System.Drawing.Point(44, 137);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(107, 36);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // SqrtEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(447, 181);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.ansOut);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SqrtEquation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратного уравнения";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.RichTextBox ansOut;
        private System.Windows.Forms.Button btnSolve;
    }
}