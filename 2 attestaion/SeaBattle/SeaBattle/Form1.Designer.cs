namespace SeaBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Horizontal = new System.Windows.Forms.Button();
            this.Vertical = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horizontal";
            // 
            // Horizontal
            // 
            this.Horizontal.BackColor = System.Drawing.Color.Silver;
            this.Horizontal.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horizontal.Location = new System.Drawing.Point(42, 320);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(93, 30);
            this.Horizontal.TabIndex = 2;
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.UseVisualStyleBackColor = false;
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // Vertical
            // 
            this.Vertical.BackColor = System.Drawing.Color.Silver;
            this.Vertical.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vertical.Location = new System.Drawing.Point(42, 358);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(93, 30);
            this.Vertical.TabIndex = 3;
            this.Vertical.Text = "Vertical";
            this.Vertical.UseVisualStyleBackColor = false;
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Silver;
            this.Start.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(383, 341);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 30);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.START_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 484);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Vertical);
            this.Controls.Add(this.Horizontal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BATTLESHIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Horizontal;
        private System.Windows.Forms.Button Vertical;
        private System.Windows.Forms.Button Start;
    }
}

