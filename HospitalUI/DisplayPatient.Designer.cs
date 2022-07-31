namespace HospitalUI
{
    partial class DisplayPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayPatientRecords = new System.Windows.Forms.DataGridView();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortalityRisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPatientRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Records";
            // 
            // DisplayPatientRecords
            // 
            this.DisplayPatientRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayPatientRecords.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayPatientRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayPatientRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.fullName,
            this.mortalityRisk,
            this.RiskDescription});
            this.DisplayPatientRecords.Location = new System.Drawing.Point(0, 74);
            this.DisplayPatientRecords.Name = "DisplayPatientRecords";
            this.DisplayPatientRecords.ReadOnly = true;
            this.DisplayPatientRecords.RowHeadersWidth = 51;
            this.DisplayPatientRecords.RowTemplate.Height = 29;
            this.DisplayPatientRecords.Size = new System.Drawing.Size(823, 265);
            this.DisplayPatientRecords.TabIndex = 1;
            // 
            // patientId
            // 
            this.patientId.HeaderText = "Patient ID";
            this.patientId.MinimumWidth = 6;
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // mortalityRisk
            // 
            this.mortalityRisk.HeaderText = "Mortality Risk ";
            this.mortalityRisk.MinimumWidth = 6;
            this.mortalityRisk.Name = "mortalityRisk";
            this.mortalityRisk.ReadOnly = true;
            // 
            // RiskDescription
            // 
            this.RiskDescription.HeaderText = "Risk Description";
            this.RiskDescription.MinimumWidth = 6;
            this.RiskDescription.Name = "RiskDescription";
            this.RiskDescription.ReadOnly = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(64, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(241, 28);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Back To Registration";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DisplayPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 451);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DisplayPatientRecords);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayPatient";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPatientRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView DisplayPatientRecords;
        private LinkLabel linkLabel1;
        private DataGridViewTextBoxColumn patientId;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn mortalityRisk;
        private DataGridViewTextBoxColumn RiskDescription;
    }
}