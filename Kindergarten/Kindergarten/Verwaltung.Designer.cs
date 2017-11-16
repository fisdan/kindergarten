namespace Kindergarten
{
    partial class Verwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verwaltung));
            this.btn_MVerwalten = new System.Windows.Forms.Button();
            this.btn_KVerwalten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MVerwalten
            // 
            this.btn_MVerwalten.Location = new System.Drawing.Point(134, 12);
            this.btn_MVerwalten.Name = "btn_MVerwalten";
            this.btn_MVerwalten.Size = new System.Drawing.Size(130, 47);
            this.btn_MVerwalten.TabIndex = 0;
            this.btn_MVerwalten.Text = "Verwalten";
            this.btn_MVerwalten.UseVisualStyleBackColor = true;
            this.btn_MVerwalten.Click += new System.EventHandler(this.btn_MVerwalten_Click);
            // 
            // btn_KVerwalten
            // 
            this.btn_KVerwalten.Location = new System.Drawing.Point(134, 70);
            this.btn_KVerwalten.Name = "btn_KVerwalten";
            this.btn_KVerwalten.Size = new System.Drawing.Size(130, 47);
            this.btn_KVerwalten.TabIndex = 1;
            this.btn_KVerwalten.Text = "Verwalten";
            this.btn_KVerwalten.UseVisualStyleBackColor = true;
            this.btn_KVerwalten.Click += new System.EventHandler(this.btn_KVerwalten_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mitarbeiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kinder:";
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kindergarten.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(276, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KVerwalten);
            this.Controls.Add(this.btn_MVerwalten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Verwaltung";
            this.Text = "Verwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MVerwalten;
        private System.Windows.Forms.Button btn_KVerwalten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}