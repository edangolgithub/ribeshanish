namespace ribeshanish
{
    partial class Form1
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
            this.okbbutton = new System.Windows.Forms.Button();
            this.radiustextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.centiconvertbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ferentxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okbbutton
            // 
            this.okbbutton.ForeColor = System.Drawing.Color.Black;
            this.okbbutton.Location = new System.Drawing.Point(145, 163);
            this.okbbutton.Name = "okbbutton";
            this.okbbutton.Size = new System.Drawing.Size(100, 23);
            this.okbbutton.TabIndex = 0;
            this.okbbutton.Text = "area of circle";
            this.okbbutton.UseVisualStyleBackColor = true;
            this.okbbutton.Click += new System.EventHandler(this.okbbutton_Click);
            // 
            // radiustextbox
            // 
            this.radiustextbox.Location = new System.Drawing.Point(145, 137);
            this.radiustextbox.Name = "radiustextbox";
            this.radiustextbox.Size = new System.Drawing.Size(100, 20);
            this.radiustextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the radius of circle";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.centiconvertbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ferentxtbox);
            this.groupBox1.Controls.Add(this.okbbutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radiustextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 369);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area Of Circle";
            // 
            // centiconvertbtn
            // 
            this.centiconvertbtn.ForeColor = System.Drawing.Color.Black;
            this.centiconvertbtn.Location = new System.Drawing.Point(432, 161);
            this.centiconvertbtn.Name = "centiconvertbtn";
            this.centiconvertbtn.Size = new System.Drawing.Size(100, 23);
            this.centiconvertbtn.TabIndex = 3;
            this.centiconvertbtn.Text = "convert to celsius";
            this.centiconvertbtn.UseVisualStyleBackColor = true;
            this.centiconvertbtn.Click += new System.EventHandler(this.centiconvertbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(305, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the farenhiet";
            // 
            // ferentxtbox
            // 
            this.ferentxtbox.Location = new System.Drawing.Point(432, 135);
            this.ferentxtbox.Name = "ferentxtbox";
            this.ferentxtbox.Size = new System.Drawing.Size(100, 20);
            this.ferentxtbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 369);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okbbutton;
        private System.Windows.Forms.TextBox radiustextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button centiconvertbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ferentxtbox;
    }
}

