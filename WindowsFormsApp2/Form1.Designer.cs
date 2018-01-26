namespace DaysCalculate
{
    partial class DaysCalculate
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
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.Result_lb = new MetroFramework.Controls.MetroLabel();
            this.Calculate_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.metroDateTime1.Location = new System.Drawing.Point(68, 113);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(272, 35);
            this.metroDateTime1.TabIndex = 5;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.metroDateTime2.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.metroDateTime2.Location = new System.Drawing.Point(68, 179);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 35);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(272, 35);
            this.metroDateTime2.TabIndex = 6;
            // 
            // Result_lb
            // 
            this.Result_lb.AutoSize = true;
            this.Result_lb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Result_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Result_lb.Location = new System.Drawing.Point(206, 250);
            this.Result_lb.Name = "Result_lb";
            this.Result_lb.Size = new System.Drawing.Size(68, 25);
            this.Result_lb.TabIndex = 7;
            this.Result_lb.Text = "0 Days";
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Calculate_btn.Location = new System.Drawing.Point(373, 132);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(157, 69);
            this.Calculate_btn.TabIndex = 8;
            this.Calculate_btn.Text = "Calculate";
            this.Calculate_btn.UseSelectable = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // DaysCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 339);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Result_lb);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DaysCalculate";
            this.Padding = new System.Windows.Forms.Padding(33, 92, 33, 31);
            this.Resizable = false;
            this.Text = "Days Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel Result_lb;
        private MetroFramework.Controls.MetroButton Calculate_btn;
    }
}

