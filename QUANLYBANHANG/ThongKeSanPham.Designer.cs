namespace QUANLYBANHANG
{
    partial class ThongKeSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpNL = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpNL);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu theo tháng: ";
            // 
            // dpNL
            // 
            this.dpNL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNL.Location = new System.Drawing.Point(32, 42);
            this.dpNL.Name = "dpNL";
            this.dpNL.Size = new System.Drawing.Size(200, 26);
            this.dpNL.TabIndex = 0;
            this.dpNL.ValueChanged += new System.EventHandler(this.DpNL_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(597, 73);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 26);
            this.txtTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền";
            // 
            // ThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeSanPham";
            this.Text = "ThongKeSanPham";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpNL;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
    }
}