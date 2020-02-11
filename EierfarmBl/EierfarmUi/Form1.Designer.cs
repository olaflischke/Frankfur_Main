namespace EierfarmUi
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChicken = new System.Windows.Forms.Button();
            this.btnDuck = new System.Windows.Forms.Button();
            this.btnPlatibus = new System.Windows.Forms.Button();
            this.cbxTiere = new System.Windows.Forms.ComboBox();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnLayEgg = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.cbxAnimalTypes = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChicken
            // 
            this.btnChicken.Location = new System.Drawing.Point(246, 58);
            this.btnChicken.Name = "btnChicken";
            this.btnChicken.Size = new System.Drawing.Size(75, 23);
            this.btnChicken.TabIndex = 0;
            this.btnChicken.Text = "Chicken";
            this.btnChicken.UseVisualStyleBackColor = true;
            this.btnChicken.Visible = false;
            this.btnChicken.Click += new System.EventHandler(this.btnChicken_Click);
            this.btnChicken.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnChicken_MouseMove);
            // 
            // btnDuck
            // 
            this.btnDuck.Location = new System.Drawing.Point(246, 87);
            this.btnDuck.Name = "btnDuck";
            this.btnDuck.Size = new System.Drawing.Size(75, 23);
            this.btnDuck.TabIndex = 1;
            this.btnDuck.Text = "Duck";
            this.btnDuck.UseVisualStyleBackColor = true;
            this.btnDuck.Visible = false;
            this.btnDuck.Click += new System.EventHandler(this.btnDuck_Click);
            // 
            // btnPlatibus
            // 
            this.btnPlatibus.Location = new System.Drawing.Point(246, 116);
            this.btnPlatibus.Name = "btnPlatibus";
            this.btnPlatibus.Size = new System.Drawing.Size(75, 23);
            this.btnPlatibus.TabIndex = 2;
            this.btnPlatibus.Text = "Platibus";
            this.btnPlatibus.UseVisualStyleBackColor = true;
            this.btnPlatibus.Visible = false;
            this.btnPlatibus.Click += new System.EventHandler(this.btnPlatibus_Click);
            // 
            // cbxTiere
            // 
            this.cbxTiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiere.FormattingEnabled = true;
            this.cbxTiere.Location = new System.Drawing.Point(59, 58);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(181, 21);
            this.cbxTiere.TabIndex = 3;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.HelpVisible = false;
            this.pgdTier.Location = new System.Drawing.Point(59, 87);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(181, 214);
            this.pgdTier.TabIndex = 4;
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(246, 176);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 1;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnLayEgg
            // 
            this.btnLayEgg.Location = new System.Drawing.Point(246, 205);
            this.btnLayEgg.Name = "btnLayEgg";
            this.btnLayEgg.Size = new System.Drawing.Size(75, 23);
            this.btnLayEgg.TabIndex = 2;
            this.btnLayEgg.Text = "Lay Egg";
            this.btnLayEgg.UseVisualStyleBackColor = true;
            this.btnLayEgg.Click += new System.EventHandler(this.btnLayEgg_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(246, 278);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 6;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(246, 249);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(75, 23);
            this.btnLaden.TabIndex = 5;
            this.btnLaden.Text = "Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            // 
            // cbxAnimalTypes
            // 
            this.cbxAnimalTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnimalTypes.FormattingEnabled = true;
            this.cbxAnimalTypes.Location = new System.Drawing.Point(59, 12);
            this.cbxAnimalTypes.Name = "cbxAnimalTypes";
            this.cbxAnimalTypes.Size = new System.Drawing.Size(181, 21);
            this.cbxAnimalTypes.TabIndex = 3;
            this.cbxAnimalTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(246, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnChicken_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 344);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxAnimalTypes);
            this.Controls.Add(this.cbxTiere);
            this.Controls.Add(this.btnLayEgg);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnPlatibus);
            this.Controls.Add(this.btnDuck);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChicken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChicken;
        private System.Windows.Forms.Button btnDuck;
        private System.Windows.Forms.Button btnPlatibus;
        private System.Windows.Forms.ComboBox cbxTiere;
        private System.Windows.Forms.PropertyGrid pgdTier;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnLayEgg;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.ComboBox cbxAnimalTypes;
        private System.Windows.Forms.Button btnNew;
    }
}

