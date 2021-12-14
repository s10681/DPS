namespace DPS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxAkt = new System.Windows.Forms.CheckBox();
            this.TB_opis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_nip = new System.Windows.Forms.TextBox();
            this.TB_nazwa = new System.Windows.Forms.TextBox();
            this.cboTyp = new System.Windows.Forms.ComboBox();
            this._DPS_DPSModelContextDataSet = new DPS._DPS_DPSModelContextDataSet();
            this.typKontrahentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typKontrahentaTableAdapter = new DPS._DPS_DPSModelContextDataSetTableAdapters.TypKontrahentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._DPS_DPSModelContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typKontrahentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj / edytuj kontrahenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa kontrahenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(50, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typ kontrahenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(50, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis firmy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kontrahent aktywny:";
            // 
            // checkBoxAkt
            // 
            this.checkBoxAkt.AutoSize = true;
            this.checkBoxAkt.Checked = true;
            this.checkBoxAkt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAkt.Location = new System.Drawing.Point(200, 240);
            this.checkBoxAkt.Name = "checkBoxAkt";
            this.checkBoxAkt.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAkt.TabIndex = 6;
            this.checkBoxAkt.UseVisualStyleBackColor = true;
            // 
            // TB_opis
            // 
            this.TB_opis.Location = new System.Drawing.Point(200, 160);
            this.TB_opis.Name = "TB_opis";
            this.TB_opis.Size = new System.Drawing.Size(257, 20);
            this.TB_opis.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_nip
            // 
            this.TB_nip.Location = new System.Drawing.Point(200, 100);
            this.TB_nip.Name = "TB_nip";
            this.TB_nip.Size = new System.Drawing.Size(257, 20);
            this.TB_nip.TabIndex = 10;
            // 
            // TB_nazwa
            // 
            this.TB_nazwa.Location = new System.Drawing.Point(200, 70);
            this.TB_nazwa.Name = "TB_nazwa";
            this.TB_nazwa.Size = new System.Drawing.Size(257, 20);
            this.TB_nazwa.TabIndex = 11;
            // 
            // cboTyp
            // 
            this.cboTyp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typKontrahentaBindingSource, "Id", true));
            this.cboTyp.DataSource = this.typKontrahentaBindingSource;
            this.cboTyp.DisplayMember = "Typ";
            this.cboTyp.FormattingEnabled = true;
            this.cboTyp.Location = new System.Drawing.Point(200, 130);
            this.cboTyp.Name = "cboTyp";
            this.cboTyp.Size = new System.Drawing.Size(257, 21);
            this.cboTyp.TabIndex = 12;
            this.cboTyp.ValueMember = "Id";
            // 
            // _DPS_DPSModelContextDataSet
            // 
            this._DPS_DPSModelContextDataSet.DataSetName = "_DPS_DPSModelContextDataSet";
            this._DPS_DPSModelContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typKontrahentaBindingSource
            // 
            this.typKontrahentaBindingSource.DataMember = "TypKontrahenta";
            this.typKontrahentaBindingSource.DataSource = this._DPS_DPSModelContextDataSet;
            // 
            // typKontrahentaTableAdapter
            // 
            this.typKontrahentaTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.cboTyp);
            this.Controls.Add(this.TB_nazwa);
            this.Controls.Add(this.TB_nip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_opis);
            this.Controls.Add(this.checkBoxAkt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DPS_DPSModelContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typKontrahentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxAkt;
        private System.Windows.Forms.TextBox TB_opis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_nip;
        private System.Windows.Forms.TextBox TB_nazwa;
        private System.Windows.Forms.ComboBox cboTyp;
        private _DPS_DPSModelContextDataSet _DPS_DPSModelContextDataSet;
        private System.Windows.Forms.BindingSource typKontrahentaBindingSource;
        private _DPS_DPSModelContextDataSetTableAdapters.TypKontrahentaTableAdapter typKontrahentaTableAdapter;
    }
}