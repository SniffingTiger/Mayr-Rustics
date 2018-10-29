using Rustics_Inventory;

namespace Rustics_Inventory
{
    partial class Form1
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
            System.Windows.Forms.Label productNameLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rusticsDBDataSet = new Rustics_Inventory.RusticsDBDataSet();
            this.fullProductNameListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullProductNameListTableAdapter = new Rustics_Inventory.RusticsDBDataSetTableAdapters.FullProductNameListTableAdapter();
            productNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rusticsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductNameListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 89);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Product Name:";
            productNameLabel.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Press this button to populate the below text box with the first product name in d" +
    "bo.Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fullProductNameListBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // rusticsDBDataSet
            // 
            this.rusticsDBDataSet.DataSetName = "RusticsDBDataSet";
            this.rusticsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullProductNameListBindingSource
            // 
            this.fullProductNameListBindingSource.DataMember = "FullProductNameList";
            this.fullProductNameListBindingSource.DataSource = this.rusticsDBDataSet;
            // 
            // fullProductNameListTableAdapter
            // 
            this.fullProductNameListTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rustics Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rusticsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductNameListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private RusticsDBDataSet rusticsDBDataSet;
        private System.Windows.Forms.BindingSource fullProductNameListBindingSource;
        private RusticsDBDataSetTableAdapters.FullProductNameListTableAdapter fullProductNameListTableAdapter;
    }
}

