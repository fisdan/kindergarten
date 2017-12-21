namespace Kindergarten
{
    partial class Registrierung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrierung));
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.txb_Benutzername = new System.Windows.Forms.TextBox();
            this.txb_Passwort = new System.Windows.Forms.TextBox();
            this.btn_Registrieren = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.chk_Eltern = new System.Windows.Forms.CheckBox();
            this.chk_Betreuer = new System.Windows.Forms.CheckBox();
            this.chk_Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Benutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Benutzername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Benutzername.Location = new System.Drawing.Point(10, 14);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(97, 16);
            this.lbl_Benutzername.TabIndex = 0;
            this.lbl_Benutzername.Text = "Benutzername:";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Passwort.Location = new System.Drawing.Point(10, 54);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(66, 16);
            this.lbl_Passwort.TabIndex = 1;
            this.lbl_Passwort.Text = "Passwort:";
            // 
            // txb_Benutzername
            // 
            this.txb_Benutzername.Location = new System.Drawing.Point(113, 13);
            this.txb_Benutzername.Name = "txb_Benutzername";
            this.txb_Benutzername.Size = new System.Drawing.Size(151, 20);
            this.txb_Benutzername.TabIndex = 2;
            // 
            // txb_Passwort
            // 
            this.txb_Passwort.Location = new System.Drawing.Point(113, 54);
            this.txb_Passwort.Name = "txb_Passwort";
            this.txb_Passwort.Size = new System.Drawing.Size(151, 20);
            this.txb_Passwort.TabIndex = 3;
            this.txb_Passwort.UseSystemPasswordChar = true;
            // 
            // btn_Registrieren
            // 
            this.btn_Registrieren.Location = new System.Drawing.Point(12, 140);
            this.btn_Registrieren.Name = "btn_Registrieren";
            this.btn_Registrieren.Size = new System.Drawing.Size(120, 37);
            this.btn_Registrieren.TabIndex = 4;
            this.btn_Registrieren.Text = "Registrieren";
            this.btn_Registrieren.UseVisualStyleBackColor = true;
            this.btn_Registrieren.Click += new System.EventHandler(this.btn_Registrieren_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(144, 140);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(120, 37);
            this.btn_Abbrechen.TabIndex = 5;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // chk_Eltern
            // 
            this.chk_Eltern.AutoSize = true;
            this.chk_Eltern.Location = new System.Drawing.Point(113, 96);
            this.chk_Eltern.Name = "chk_Eltern";
            this.chk_Eltern.Size = new System.Drawing.Size(53, 17);
            this.chk_Eltern.TabIndex = 6;
            this.chk_Eltern.Text = "Eltern";
            this.chk_Eltern.UseVisualStyleBackColor = true;
            // 
            // chk_Betreuer
            // 
            this.chk_Betreuer.AutoSize = true;
            this.chk_Betreuer.Location = new System.Drawing.Point(10, 96);
            this.chk_Betreuer.Name = "chk_Betreuer";
            this.chk_Betreuer.Size = new System.Drawing.Size(66, 17);
            this.chk_Betreuer.TabIndex = 7;
            this.chk_Betreuer.Text = "Betreuer";
            this.chk_Betreuer.UseVisualStyleBackColor = true;
            // 
            // chk_Admin
            // 
            this.chk_Admin.AutoSize = true;
            this.chk_Admin.Location = new System.Drawing.Point(209, 96);
            this.chk_Admin.Name = "chk_Admin";
            this.chk_Admin.Size = new System.Drawing.Size(55, 17);
            this.chk_Admin.TabIndex = 8;
            this.chk_Admin.Text = "Admin";
            this.chk_Admin.UseVisualStyleBackColor = true;
            // 
            // Registrierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kindergarten.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(271, 189);
            this.Controls.Add(this.chk_Admin);
            this.Controls.Add(this.chk_Betreuer);
            this.Controls.Add(this.chk_Eltern);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Registrieren);
            this.Controls.Add(this.txb_Passwort);
            this.Controls.Add(this.txb_Benutzername);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrierung";
            this.Text = "Registrierung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registrierung_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.TextBox txb_Benutzername;
        private System.Windows.Forms.TextBox txb_Passwort;
        private System.Windows.Forms.Button btn_Registrieren;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.CheckBox chk_Eltern;
        private System.Windows.Forms.CheckBox chk_Betreuer;
        private System.Windows.Forms.CheckBox chk_Admin;
    }
}