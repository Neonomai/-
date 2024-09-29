namespace WindowsFormsApp4
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
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.rbLand = new System.Windows.Forms.RadioButton();
            this.rbAir = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(93, 69);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 0;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(93, 111);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 20);
            this.txtKg.TabIndex = 1;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Location = new System.Drawing.Point(96, 166);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(66, 17);
            this.rbWater.TabIndex = 0;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "По воде";
            this.rbWater.UseVisualStyleBackColor = true;
            // 
            // rbLand
            // 
            this.rbLand.AutoSize = true;
            this.rbLand.Location = new System.Drawing.Point(96, 190);
            this.rbLand.Name = "rbLand";
            this.rbLand.Size = new System.Drawing.Size(67, 17);
            this.rbLand.TabIndex = 1;
            this.rbLand.TabStop = true;
            this.rbLand.Text = "По суше";
            this.rbLand.UseVisualStyleBackColor = true;
            // 
            // rbAir
            // 
            this.rbAir.AutoSize = true;
            this.rbAir.Location = new System.Drawing.Point(96, 214);
            this.rbAir.Name = "rbAir";
            this.rbAir.Size = new System.Drawing.Size(81, 17);
            this.rbAir.TabIndex = 2;
            this.rbAir.TabStop = true;
            this.rbAir.Text = "По воздуху";
            this.rbAir.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 261);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Расчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(90, 296);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расстояние (км)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вес (кг)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAir);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rbLand);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbWater);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Логистический калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.RadioButton rbAir;
        private System.Windows.Forms.RadioButton rbLand;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

