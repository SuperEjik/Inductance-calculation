
namespace Inductance_calculation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_N = new System.Windows.Forms.Label();
            this.button_calculation = new System.Windows.Forms.Button();
            this.label_R = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_radius = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label_L = new System.Windows.Forms.Label();
            this.label_nu = new System.Windows.Forms.Label();
            this.textBox_nu = new System.Windows.Forms.TextBox();
            this.textBox_nu0 = new System.Windows.Forms.TextBox();
            this.textBox_pi = new System.Windows.Forms.TextBox();
            this.label_nu0 = new System.Windows.Forms.Label();
            this.label_pi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_N.Location = new System.Drawing.Point(33, 49);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(44, 21);
            this.label_N.TabIndex = 0;
            this.label_N.Text = "N = ";
            // 
            // button_calculation
            // 
            this.button_calculation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculation.Location = new System.Drawing.Point(87, 294);
            this.button_calculation.Name = "button_calculation";
            this.button_calculation.Size = new System.Drawing.Size(75, 28);
            this.button_calculation.TabIndex = 1;
            this.button_calculation.Text = "Расчёт";
            this.button_calculation.UseVisualStyleBackColor = true;
            this.button_calculation.Click += new System.EventHandler(this.button_calculation_Click);
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_R.Location = new System.Drawing.Point(33, 101);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(44, 21);
            this.label_R.TabIndex = 2;
            this.label_R.Text = "R = ";
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_radius.Location = new System.Drawing.Point(33, 127);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(37, 21);
            this.label_radius.TabIndex = 4;
            this.label_radius.Text = "r = ";
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_h.Location = new System.Drawing.Point(33, 153);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(40, 21);
            this.label_h.TabIndex = 3;
            this.label_h.Text = "h = ";
            // 
            // textBox_N
            // 
            this.textBox_N.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_N.Location = new System.Drawing.Point(74, 42);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 29);
            this.textBox_N.TabIndex = 5;
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_N_KeyPress);
            // 
            // textBox_R
            // 
            this.textBox_R.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_R.Location = new System.Drawing.Point(74, 94);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(100, 29);
            this.textBox_R.TabIndex = 6;
            this.textBox_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_R_KeyPress);
            // 
            // textBox_radius
            // 
            this.textBox_radius.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_radius.Location = new System.Drawing.Point(74, 120);
            this.textBox_radius.Name = "textBox_radius";
            this.textBox_radius.Size = new System.Drawing.Size(100, 29);
            this.textBox_radius.TabIndex = 7;
            this.textBox_radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_radius_KeyPress);
            // 
            // textBox_h
            // 
            this.textBox_h.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_h.Location = new System.Drawing.Point(74, 146);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 29);
            this.textBox_h.TabIndex = 8;
            this.textBox_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_h_KeyPress);
            // 
            // textBox_L
            // 
            this.textBox_L.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_L.Location = new System.Drawing.Point(74, 342);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.ReadOnly = true;
            this.textBox_L.Size = new System.Drawing.Size(100, 29);
            this.textBox_L.TabIndex = 9;
            this.textBox_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_L
            // 
            this.label_L.AutoSize = true;
            this.label_L.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_L.Location = new System.Drawing.Point(33, 350);
            this.label_L.Name = "label_L";
            this.label_L.Size = new System.Drawing.Size(41, 21);
            this.label_L.TabIndex = 10;
            this.label_L.Text = "L = ";
            // 
            // label_nu
            // 
            this.label_nu.AutoSize = true;
            this.label_nu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nu.Location = new System.Drawing.Point(33, 76);
            this.label_nu.Name = "label_nu";
            this.label_nu.Size = new System.Drawing.Size(42, 21);
            this.label_nu.TabIndex = 11;
            this.label_nu.Text = "µ = ";
            // 
            // textBox_nu
            // 
            this.textBox_nu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nu.Location = new System.Drawing.Point(74, 68);
            this.textBox_nu.Name = "textBox_nu";
            this.textBox_nu.Size = new System.Drawing.Size(100, 29);
            this.textBox_nu.TabIndex = 12;
            this.textBox_nu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_nu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nu_KeyPress);
            // 
            // textBox_nu0
            // 
            this.textBox_nu0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nu0.Location = new System.Drawing.Point(74, 201);
            this.textBox_nu0.Name = "textBox_nu0";
            this.textBox_nu0.ReadOnly = true;
            this.textBox_nu0.Size = new System.Drawing.Size(100, 29);
            this.textBox_nu0.TabIndex = 13;
            this.textBox_nu0.Text = "4π · 10^(-7)";
            this.textBox_nu0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_pi
            // 
            this.textBox_pi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pi.Location = new System.Drawing.Point(74, 227);
            this.textBox_pi.Name = "textBox_pi";
            this.textBox_pi.ReadOnly = true;
            this.textBox_pi.Size = new System.Drawing.Size(100, 29);
            this.textBox_pi.TabIndex = 14;
            this.textBox_pi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_nu0
            // 
            this.label_nu0.AutoSize = true;
            this.label_nu0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nu0.Location = new System.Drawing.Point(24, 203);
            this.label_nu0.Name = "label_nu0";
            this.label_nu0.Size = new System.Drawing.Size(50, 21);
            this.label_nu0.TabIndex = 15;
            this.label_nu0.Text = "μ0 = ";
            // 
            // label_pi
            // 
            this.label_pi.AutoSize = true;
            this.label_pi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pi.Location = new System.Drawing.Point(33, 230);
            this.label_pi.Name = "label_pi";
            this.label_pi.Size = new System.Drawing.Size(41, 21);
            this.label_pi.TabIndex = 16;
            this.label_pi.Text = "π = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "шт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(180, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "м";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(180, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "м";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(180, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "м";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(180, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Гн/м";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(180, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Гн";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_pi);
            this.Controls.Add(this.label_nu0);
            this.Controls.Add(this.textBox_pi);
            this.Controls.Add(this.textBox_nu0);
            this.Controls.Add(this.textBox_nu);
            this.Controls.Add(this.label_nu);
            this.Controls.Add(this.label_L);
            this.Controls.Add(this.textBox_L);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_radius);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.label_radius);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.label_R);
            this.Controls.Add(this.button_calculation);
            this.Controls.Add(this.label_N);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Расчёт индуктивности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Button button_calculation;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_radius;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label_L;
        private System.Windows.Forms.Label label_nu;
        private System.Windows.Forms.TextBox textBox_nu;
        private System.Windows.Forms.TextBox textBox_nu0;
        private System.Windows.Forms.TextBox textBox_pi;
        private System.Windows.Forms.Label label_nu0;
        private System.Windows.Forms.Label label_pi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

