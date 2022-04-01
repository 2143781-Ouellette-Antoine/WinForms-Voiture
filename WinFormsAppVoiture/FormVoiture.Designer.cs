namespace WinFormsAppVoiture
{
    partial class FormVoiture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreSectionCreerVoiture = new System.Windows.Forms.Label();
            this.panelSectionCreer = new System.Windows.Forms.Panel();
            this.labelCreerKg = new System.Windows.Forms.Label();
            this.buttonCreerVoiture = new System.Windows.Forms.Button();
            this.textBoxCreerPoid = new System.Windows.Forms.TextBox();
            this.labelCreerPoid = new System.Windows.Forms.Label();
            this.textBoxCreerPlaque = new System.Windows.Forms.TextBox();
            this.labelCreerPlaque = new System.Windows.Forms.Label();
            this.textBoxCreerNom = new System.Windows.Forms.TextBox();
            this.labelCreerNom = new System.Windows.Forms.Label();
            this.panelSectionUtiliser = new System.Windows.Forms.Panel();
            this.buttonUtiliserFairePleinEssence = new System.Windows.Forms.Button();
            this.buttonUtiliserAvancer = new System.Windows.Forms.Button();
            this.labelUtiliserKm = new System.Windows.Forms.Label();
            this.numericUpDownUtiliserKmAAvancer = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUtiliserVoiture = new System.Windows.Forms.ComboBox();
            this.labelUtiliserVoiture = new System.Windows.Forms.Label();
            this.titreSectionUtiliser = new System.Windows.Forms.Label();
            this.panelSectionInformations = new System.Windows.Forms.Panel();
            this.labelInformationsKm = new System.Windows.Forms.Label();
            this.textBoxInformationsOdometre = new System.Windows.Forms.TextBox();
            this.labelInformationsOdometre = new System.Windows.Forms.Label();
            this.labelInformationsKg = new System.Windows.Forms.Label();
            this.textBoxInformationsPoid = new System.Windows.Forms.TextBox();
            this.labelInformationsPoid = new System.Windows.Forms.Label();
            this.textBoxInformationsPlaque = new System.Windows.Forms.TextBox();
            this.labelInformationsPlaque = new System.Windows.Forms.Label();
            this.labelInformationsNbrKmRestant = new System.Windows.Forms.Label();
            this.labelInformationsRestant = new System.Windows.Forms.Label();
            this.labelInformationReservoir = new System.Windows.Forms.Label();
            this.labelInformationsPourcentageReservoir = new System.Windows.Forms.Label();
            this.informationsGaugeReservoirGrise = new System.Windows.Forms.PictureBox();
            this.informationsGaugeReservoirBleu = new System.Windows.Forms.PictureBox();
            this.progressBarInformationsReservoir_hidden = new System.Windows.Forms.ProgressBar();
            this.titreSectionInformations = new System.Windows.Forms.Label();
            this.panelSectionCreer.SuspendLayout();
            this.panelSectionUtiliser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUtiliserKmAAvancer)).BeginInit();
            this.panelSectionInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationsGaugeReservoirGrise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationsGaugeReservoirBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // titreSectionCreerVoiture
            // 
            this.titreSectionCreerVoiture.AutoSize = true;
            this.titreSectionCreerVoiture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titreSectionCreerVoiture.Location = new System.Drawing.Point(0, 0);
            this.titreSectionCreerVoiture.Name = "titreSectionCreerVoiture";
            this.titreSectionCreerVoiture.Size = new System.Drawing.Size(178, 28);
            this.titreSectionCreerVoiture.TabIndex = 0;
            this.titreSectionCreerVoiture.Text = "Créer une Voiture";
            // 
            // panelSectionCreer
            // 
            this.panelSectionCreer.Controls.Add(this.labelCreerKg);
            this.panelSectionCreer.Controls.Add(this.buttonCreerVoiture);
            this.panelSectionCreer.Controls.Add(this.textBoxCreerPoid);
            this.panelSectionCreer.Controls.Add(this.labelCreerPoid);
            this.panelSectionCreer.Controls.Add(this.textBoxCreerPlaque);
            this.panelSectionCreer.Controls.Add(this.labelCreerPlaque);
            this.panelSectionCreer.Controls.Add(this.textBoxCreerNom);
            this.panelSectionCreer.Controls.Add(this.labelCreerNom);
            this.panelSectionCreer.Controls.Add(this.titreSectionCreerVoiture);
            this.panelSectionCreer.Location = new System.Drawing.Point(12, 12);
            this.panelSectionCreer.Name = "panelSectionCreer";
            this.panelSectionCreer.Size = new System.Drawing.Size(499, 142);
            this.panelSectionCreer.TabIndex = 1;
            // 
            // labelCreerKg
            // 
            this.labelCreerKg.AutoSize = true;
            this.labelCreerKg.Location = new System.Drawing.Point(223, 92);
            this.labelCreerKg.Name = "labelCreerKg";
            this.labelCreerKg.Size = new System.Drawing.Size(25, 20);
            this.labelCreerKg.TabIndex = 8;
            this.labelCreerKg.Text = "kg";
            // 
            // buttonCreerVoiture
            // 
            this.buttonCreerVoiture.Location = new System.Drawing.Point(270, 85);
            this.buttonCreerVoiture.Name = "buttonCreerVoiture";
            this.buttonCreerVoiture.Size = new System.Drawing.Size(214, 34);
            this.buttonCreerVoiture.TabIndex = 7;
            this.buttonCreerVoiture.Text = "Créer la voiture";
            this.buttonCreerVoiture.UseVisualStyleBackColor = true;
            this.buttonCreerVoiture.Click += new System.EventHandler(this.ButtonCreerVoiture_Click);
            // 
            // textBoxCreerPoid
            // 
            this.textBoxCreerPoid.Location = new System.Drawing.Point(62, 89);
            this.textBoxCreerPoid.Name = "textBoxCreerPoid";
            this.textBoxCreerPoid.Size = new System.Drawing.Size(155, 27);
            this.textBoxCreerPoid.TabIndex = 6;
            // 
            // labelCreerPoid
            // 
            this.labelCreerPoid.AutoSize = true;
            this.labelCreerPoid.Location = new System.Drawing.Point(15, 92);
            this.labelCreerPoid.Name = "labelCreerPoid";
            this.labelCreerPoid.Size = new System.Drawing.Size(41, 20);
            this.labelCreerPoid.TabIndex = 5;
            this.labelCreerPoid.Text = "Poid:";
            this.labelCreerPoid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCreerPlaque
            // 
            this.textBoxCreerPlaque.Location = new System.Drawing.Point(353, 41);
            this.textBoxCreerPlaque.Name = "textBoxCreerPlaque";
            this.textBoxCreerPlaque.Size = new System.Drawing.Size(131, 27);
            this.textBoxCreerPlaque.TabIndex = 4;
            // 
            // labelCreerPlaque
            // 
            this.labelCreerPlaque.AutoSize = true;
            this.labelCreerPlaque.Location = new System.Drawing.Point(290, 44);
            this.labelCreerPlaque.Name = "labelCreerPlaque";
            this.labelCreerPlaque.Size = new System.Drawing.Size(57, 20);
            this.labelCreerPlaque.TabIndex = 3;
            this.labelCreerPlaque.Text = "Plaque:";
            this.labelCreerPlaque.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCreerNom
            // 
            this.textBoxCreerNom.Location = new System.Drawing.Point(62, 41);
            this.textBoxCreerNom.Name = "textBoxCreerNom";
            this.textBoxCreerNom.Size = new System.Drawing.Size(186, 27);
            this.textBoxCreerNom.TabIndex = 2;
            // 
            // labelCreerNom
            // 
            this.labelCreerNom.AutoSize = true;
            this.labelCreerNom.Location = new System.Drawing.Point(11, 44);
            this.labelCreerNom.Name = "labelCreerNom";
            this.labelCreerNom.Size = new System.Drawing.Size(45, 20);
            this.labelCreerNom.TabIndex = 1;
            this.labelCreerNom.Text = "Nom:";
            this.labelCreerNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelSectionUtiliser
            // 
            this.panelSectionUtiliser.Controls.Add(this.buttonUtiliserFairePleinEssence);
            this.panelSectionUtiliser.Controls.Add(this.buttonUtiliserAvancer);
            this.panelSectionUtiliser.Controls.Add(this.labelUtiliserKm);
            this.panelSectionUtiliser.Controls.Add(this.numericUpDownUtiliserKmAAvancer);
            this.panelSectionUtiliser.Controls.Add(this.comboBoxUtiliserVoiture);
            this.panelSectionUtiliser.Controls.Add(this.labelUtiliserVoiture);
            this.panelSectionUtiliser.Controls.Add(this.titreSectionUtiliser);
            this.panelSectionUtiliser.Location = new System.Drawing.Point(12, 160);
            this.panelSectionUtiliser.Name = "panelSectionUtiliser";
            this.panelSectionUtiliser.Size = new System.Drawing.Size(499, 180);
            this.panelSectionUtiliser.TabIndex = 2;
            // 
            // buttonUtiliserFairePleinEssence
            // 
            this.buttonUtiliserFairePleinEssence.Location = new System.Drawing.Point(113, 122);
            this.buttonUtiliserFairePleinEssence.Name = "buttonUtiliserFairePleinEssence";
            this.buttonUtiliserFairePleinEssence.Size = new System.Drawing.Size(255, 34);
            this.buttonUtiliserFairePleinEssence.TabIndex = 12;
            this.buttonUtiliserFairePleinEssence.Text = "Faire le plein d\'essence";
            this.buttonUtiliserFairePleinEssence.UseVisualStyleBackColor = true;
            this.buttonUtiliserFairePleinEssence.Click += new System.EventHandler(this.ButtonUtiliserFairePleinEssence_Click);
            // 
            // buttonUtiliserAvancer
            // 
            this.buttonUtiliserAvancer.Location = new System.Drawing.Point(219, 79);
            this.buttonUtiliserAvancer.Name = "buttonUtiliserAvancer";
            this.buttonUtiliserAvancer.Size = new System.Drawing.Size(149, 34);
            this.buttonUtiliserAvancer.TabIndex = 11;
            this.buttonUtiliserAvancer.Text = "Avancer";
            this.buttonUtiliserAvancer.UseVisualStyleBackColor = true;
            this.buttonUtiliserAvancer.Click += new System.EventHandler(this.ButtonUtiliserAvancer_Click);
            // 
            // labelUtiliserKm
            // 
            this.labelUtiliserKm.AutoSize = true;
            this.labelUtiliserKm.Location = new System.Drawing.Point(184, 86);
            this.labelUtiliserKm.Name = "labelUtiliserKm";
            this.labelUtiliserKm.Size = new System.Drawing.Size(29, 20);
            this.labelUtiliserKm.TabIndex = 13;
            this.labelUtiliserKm.Text = "km";
            // 
            // numericUpDownUtiliserKmAAvancer
            // 
            this.numericUpDownUtiliserKmAAvancer.Location = new System.Drawing.Point(113, 84);
            this.numericUpDownUtiliserKmAAvancer.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownUtiliserKmAAvancer.Name = "numericUpDownUtiliserKmAAvancer";
            this.numericUpDownUtiliserKmAAvancer.Size = new System.Drawing.Size(65, 27);
            this.numericUpDownUtiliserKmAAvancer.TabIndex = 10;
            // 
            // comboBoxUtiliserVoiture
            // 
            this.comboBoxUtiliserVoiture.FormattingEnabled = true;
            this.comboBoxUtiliserVoiture.Location = new System.Drawing.Point(178, 41);
            this.comboBoxUtiliserVoiture.Name = "comboBoxUtiliserVoiture";
            this.comboBoxUtiliserVoiture.Size = new System.Drawing.Size(190, 28);
            this.comboBoxUtiliserVoiture.TabIndex = 8;
            this.comboBoxUtiliserVoiture.SelectedValueChanged += new System.EventHandler(this.ComboBoxUtiliserVoiture_SelectedValueChanged);
            // 
            // labelUtiliserVoiture
            // 
            this.labelUtiliserVoiture.AutoSize = true;
            this.labelUtiliserVoiture.Location = new System.Drawing.Point(113, 44);
            this.labelUtiliserVoiture.Name = "labelUtiliserVoiture";
            this.labelUtiliserVoiture.Size = new System.Drawing.Size(59, 20);
            this.labelUtiliserVoiture.TabIndex = 10;
            this.labelUtiliserVoiture.Text = "Voiture:";
            // 
            // titreSectionUtiliser
            // 
            this.titreSectionUtiliser.AutoSize = true;
            this.titreSectionUtiliser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titreSectionUtiliser.Location = new System.Drawing.Point(0, 0);
            this.titreSectionUtiliser.Name = "titreSectionUtiliser";
            this.titreSectionUtiliser.Size = new System.Drawing.Size(196, 28);
            this.titreSectionUtiliser.TabIndex = 9;
            this.titreSectionUtiliser.Text = "Utiliser une Voiture";
            // 
            // panelSectionInformations
            // 
            this.panelSectionInformations.Controls.Add(this.labelInformationsKm);
            this.panelSectionInformations.Controls.Add(this.textBoxInformationsOdometre);
            this.panelSectionInformations.Controls.Add(this.labelInformationsOdometre);
            this.panelSectionInformations.Controls.Add(this.labelInformationsKg);
            this.panelSectionInformations.Controls.Add(this.textBoxInformationsPoid);
            this.panelSectionInformations.Controls.Add(this.labelInformationsPoid);
            this.panelSectionInformations.Controls.Add(this.textBoxInformationsPlaque);
            this.panelSectionInformations.Controls.Add(this.labelInformationsPlaque);
            this.panelSectionInformations.Controls.Add(this.labelInformationsNbrKmRestant);
            this.panelSectionInformations.Controls.Add(this.labelInformationsRestant);
            this.panelSectionInformations.Controls.Add(this.labelInformationReservoir);
            this.panelSectionInformations.Controls.Add(this.labelInformationsPourcentageReservoir);
            this.panelSectionInformations.Controls.Add(this.informationsGaugeReservoirGrise);
            this.panelSectionInformations.Controls.Add(this.informationsGaugeReservoirBleu);
            this.panelSectionInformations.Controls.Add(this.progressBarInformationsReservoir_hidden);
            this.panelSectionInformations.Controls.Add(this.titreSectionInformations);
            this.panelSectionInformations.Location = new System.Drawing.Point(12, 346);
            this.panelSectionInformations.Name = "panelSectionInformations";
            this.panelSectionInformations.Size = new System.Drawing.Size(499, 208);
            this.panelSectionInformations.TabIndex = 3;
            // 
            // labelInformationsKm
            // 
            this.labelInformationsKm.AutoSize = true;
            this.labelInformationsKm.Location = new System.Drawing.Point(451, 153);
            this.labelInformationsKm.Name = "labelInformationsKm";
            this.labelInformationsKm.Size = new System.Drawing.Size(29, 20);
            this.labelInformationsKm.TabIndex = 15;
            this.labelInformationsKm.Text = "km";
            // 
            // textBoxInformationsOdometre
            // 
            this.textBoxInformationsOdometre.Location = new System.Drawing.Point(290, 150);
            this.textBoxInformationsOdometre.Name = "textBoxInformationsOdometre";
            this.textBoxInformationsOdometre.ReadOnly = true;
            this.textBoxInformationsOdometre.Size = new System.Drawing.Size(155, 27);
            this.textBoxInformationsOdometre.TabIndex = 18;
            // 
            // labelInformationsOdometre
            // 
            this.labelInformationsOdometre.AutoSize = true;
            this.labelInformationsOdometre.Location = new System.Drawing.Point(204, 153);
            this.labelInformationsOdometre.Name = "labelInformationsOdometre";
            this.labelInformationsOdometre.Size = new System.Drawing.Size(80, 20);
            this.labelInformationsOdometre.TabIndex = 28;
            this.labelInformationsOdometre.Text = "Odomêtre:";
            this.labelInformationsOdometre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInformationsKg
            // 
            this.labelInformationsKg.AutoSize = true;
            this.labelInformationsKg.Location = new System.Drawing.Point(451, 108);
            this.labelInformationsKg.Name = "labelInformationsKg";
            this.labelInformationsKg.Size = new System.Drawing.Size(25, 20);
            this.labelInformationsKg.TabIndex = 27;
            this.labelInformationsKg.Text = "kg";
            // 
            // textBoxInformationsPoid
            // 
            this.textBoxInformationsPoid.Location = new System.Drawing.Point(290, 105);
            this.textBoxInformationsPoid.Name = "textBoxInformationsPoid";
            this.textBoxInformationsPoid.ReadOnly = true;
            this.textBoxInformationsPoid.Size = new System.Drawing.Size(155, 27);
            this.textBoxInformationsPoid.TabIndex = 16;
            // 
            // labelInformationsPoid
            // 
            this.labelInformationsPoid.AutoSize = true;
            this.labelInformationsPoid.Location = new System.Drawing.Point(243, 108);
            this.labelInformationsPoid.Name = "labelInformationsPoid";
            this.labelInformationsPoid.Size = new System.Drawing.Size(41, 20);
            this.labelInformationsPoid.TabIndex = 25;
            this.labelInformationsPoid.Text = "Poid:";
            this.labelInformationsPoid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxInformationsPlaque
            // 
            this.textBoxInformationsPlaque.Location = new System.Drawing.Point(290, 58);
            this.textBoxInformationsPlaque.Name = "textBoxInformationsPlaque";
            this.textBoxInformationsPlaque.ReadOnly = true;
            this.textBoxInformationsPlaque.Size = new System.Drawing.Size(131, 27);
            this.textBoxInformationsPlaque.TabIndex = 14;
            // 
            // labelInformationsPlaque
            // 
            this.labelInformationsPlaque.AutoSize = true;
            this.labelInformationsPlaque.Location = new System.Drawing.Point(227, 61);
            this.labelInformationsPlaque.Name = "labelInformationsPlaque";
            this.labelInformationsPlaque.Size = new System.Drawing.Size(57, 20);
            this.labelInformationsPlaque.TabIndex = 23;
            this.labelInformationsPlaque.Text = "Plaque:";
            this.labelInformationsPlaque.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInformationsNbrKmRestant
            // 
            this.labelInformationsNbrKmRestant.AutoSize = true;
            this.labelInformationsNbrKmRestant.Location = new System.Drawing.Point(122, 101);
            this.labelInformationsNbrKmRestant.Name = "labelInformationsNbrKmRestant";
            this.labelInformationsNbrKmRestant.Size = new System.Drawing.Size(49, 20);
            this.labelInformationsNbrKmRestant.TabIndex = 22;
            this.labelInformationsNbrKmRestant.Text = "50 km";
            this.labelInformationsNbrKmRestant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInformationsRestant
            // 
            this.labelInformationsRestant.AutoSize = true;
            this.labelInformationsRestant.Location = new System.Drawing.Point(117, 81);
            this.labelInformationsRestant.Name = "labelInformationsRestant";
            this.labelInformationsRestant.Size = new System.Drawing.Size(61, 20);
            this.labelInformationsRestant.TabIndex = 21;
            this.labelInformationsRestant.Text = "Restant:";
            this.labelInformationsRestant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInformationReservoir
            // 
            this.labelInformationReservoir.AutoSize = true;
            this.labelInformationReservoir.Location = new System.Drawing.Point(22, 182);
            this.labelInformationReservoir.Name = "labelInformationReservoir";
            this.labelInformationReservoir.Size = new System.Drawing.Size(70, 20);
            this.labelInformationReservoir.TabIndex = 20;
            this.labelInformationReservoir.Text = "Réservoir";
            this.labelInformationReservoir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInformationsPourcentageReservoir
            // 
            this.labelInformationsPourcentageReservoir.AutoSize = true;
            this.labelInformationsPourcentageReservoir.Location = new System.Drawing.Point(35, 162);
            this.labelInformationsPourcentageReservoir.Name = "labelInformationsPourcentageReservoir";
            this.labelInformationsPourcentageReservoir.Size = new System.Drawing.Size(45, 20);
            this.labelInformationsPourcentageReservoir.TabIndex = 19;
            this.labelInformationsPourcentageReservoir.Text = "100%";
            this.labelInformationsPourcentageReservoir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // informationsGaugeReservoirGrise
            // 
            this.informationsGaugeReservoirGrise.BackColor = System.Drawing.SystemColors.ControlLight;
            this.informationsGaugeReservoirGrise.Location = new System.Drawing.Point(17, 39);
            this.informationsGaugeReservoirGrise.Name = "informationsGaugeReservoirGrise";
            this.informationsGaugeReservoirGrise.Size = new System.Drawing.Size(81, 120);
            this.informationsGaugeReservoirGrise.TabIndex = 17;
            this.informationsGaugeReservoirGrise.TabStop = false;
            // 
            // informationsGaugeReservoirBleu
            // 
            this.informationsGaugeReservoirBleu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.informationsGaugeReservoirBleu.Location = new System.Drawing.Point(17, 39);
            this.informationsGaugeReservoirBleu.Name = "informationsGaugeReservoirBleu";
            this.informationsGaugeReservoirBleu.Size = new System.Drawing.Size(81, 120);
            this.informationsGaugeReservoirBleu.TabIndex = 18;
            this.informationsGaugeReservoirBleu.TabStop = false;
            // 
            // progressBarInformationsReservoir_hidden
            // 
            this.progressBarInformationsReservoir_hidden.Location = new System.Drawing.Point(17, 39);
            this.progressBarInformationsReservoir_hidden.Name = "progressBarInformationsReservoir_hidden";
            this.progressBarInformationsReservoir_hidden.Size = new System.Drawing.Size(100, 38);
            this.progressBarInformationsReservoir_hidden.Step = 1;
            this.progressBarInformationsReservoir_hidden.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarInformationsReservoir_hidden.TabIndex = 16;
            this.progressBarInformationsReservoir_hidden.Value = 60;
            this.progressBarInformationsReservoir_hidden.Visible = false;
            // 
            // titreSectionInformations
            // 
            this.titreSectionInformations.AutoSize = true;
            this.titreSectionInformations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titreSectionInformations.Location = new System.Drawing.Point(0, 0);
            this.titreSectionInformations.Name = "titreSectionInformations";
            this.titreSectionInformations.Size = new System.Drawing.Size(190, 28);
            this.titreSectionInformations.TabIndex = 15;
            this.titreSectionInformations.Text = "Informations sur ...";
            // 
            // FormVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 569);
            this.Controls.Add(this.panelSectionInformations);
            this.Controls.Add(this.panelSectionUtiliser);
            this.Controls.Add(this.panelSectionCreer);
            this.Name = "FormVoiture";
            this.Text = "Application Voiture";
            this.panelSectionCreer.ResumeLayout(false);
            this.panelSectionCreer.PerformLayout();
            this.panelSectionUtiliser.ResumeLayout(false);
            this.panelSectionUtiliser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUtiliserKmAAvancer)).EndInit();
            this.panelSectionInformations.ResumeLayout(false);
            this.panelSectionInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationsGaugeReservoirGrise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationsGaugeReservoirBleu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label titreSectionCreerVoiture;
        private Panel panelSectionCreer;
        private TextBox textBoxCreerNom;
        private Label labelCreerNom;
        private Label labelCreerKg;
        private Button buttonCreerVoiture;
        private TextBox textBoxCreerPoid;
        private Label labelCreerPoid;
        private TextBox textBoxCreerPlaque;
        private Label labelCreerPlaque;
        private Panel panelSectionUtiliser;
        private ComboBox comboBoxUtiliserVoiture;
        private Label labelUtiliserVoiture;
        private Label titreSectionUtiliser;
        private Button buttonUtiliserFairePleinEssence;
        private Button buttonUtiliserAvancer;
        private Label labelUtiliserKm;
        private NumericUpDown numericUpDownUtiliserKmAAvancer;
        private Panel panelSectionInformations;
        private PictureBox informationsGaugeReservoirGrise;
        private ProgressBar progressBarInformationsReservoir_hidden;
        private Label titreSectionInformations;
        private PictureBox informationsGaugeReservoirBleu;
        private Label labelInformationReservoir;
        private Label labelInformationsPourcentageReservoir;
        private Label labelInformationsNbrKmRestant;
        private Label labelInformationsRestant;
        private TextBox textBoxInformationsOdometre;
        private Label labelInformationsOdometre;
        private Label labelInformationsKg;
        private TextBox textBoxInformationsPoid;
        private Label labelInformationsPoid;
        private TextBox textBoxInformationsPlaque;
        private Label labelInformationsPlaque;
        private Label labelInformationsKm;
    }
}