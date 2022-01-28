namespace CRUD {
    partial class Main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.form = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnFormInsert = new System.Windows.Forms.Button();
            this.btnFormSelectByID = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.functions = new System.Windows.Forms.GroupBox();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputID
            // 
            this.inputID.Enabled = false;
            this.inputID.Location = new System.Drawing.Point(93, 28);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(146, 20);
            this.inputID.TabIndex = 1;
            this.inputID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Enabled = false;
            this.inputName.Location = new System.Drawing.Point(93, 66);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(146, 20);
            this.inputName.TabIndex = 3;
            this.inputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cost:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputCost
            // 
            this.inputCost.Enabled = false;
            this.inputCost.Location = new System.Drawing.Point(93, 104);
            this.inputCost.MaxLength = 999999;
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(146, 20);
            this.inputCost.TabIndex = 9;
            this.inputCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputPrice
            // 
            this.inputPrice.Enabled = false;
            this.inputPrice.Location = new System.Drawing.Point(93, 139);
            this.inputPrice.MaxLength = 999999;
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(146, 20);
            this.inputPrice.TabIndex = 10;
            this.inputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // form
            // 
            this.form.Controls.Add(this.inputID);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.inputName);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.inputCost);
            this.form.Controls.Add(this.label1);
            this.form.Controls.Add(this.label2);
            this.form.Controls.Add(this.inputPrice);
            this.form.Location = new System.Drawing.Point(13, 265);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(259, 170);
            this.form.TabIndex = 13;
            this.form.TabStop = false;
            this.form.Text = "Form";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(283, 196);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(454, 306);
            this.dataGrid.TabIndex = 15;
            // 
            // btnFormInsert
            // 
            this.btnFormInsert.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFormInsert.Location = new System.Drawing.Point(6, 19);
            this.btnFormInsert.Name = "btnFormInsert";
            this.btnFormInsert.Size = new System.Drawing.Size(134, 57);
            this.btnFormInsert.TabIndex = 14;
            this.btnFormInsert.Text = "Form Insert";
            this.btnFormInsert.UseVisualStyleBackColor = true;
            this.btnFormInsert.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnFormSelectByID
            // 
            this.btnFormSelectByID.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFormSelectByID.Location = new System.Drawing.Point(146, 18);
            this.btnFormSelectByID.Name = "btnFormSelectByID";
            this.btnFormSelectByID.Size = new System.Drawing.Size(162, 57);
            this.btnFormSelectByID.TabIndex = 16;
            this.btnFormSelectByID.Text = "Form Select By ID";
            this.btnFormSelectByID.UseVisualStyleBackColor = true;
            this.btnFormSelectByID.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(12, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 57);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "INSERT";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnGet
            // 
            this.btnGet.Enabled = false;
            this.btnGet.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGet.Location = new System.Drawing.Point(152, 18);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(134, 57);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "SELECT BY ID";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(434, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 57);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.Location = new System.Drawing.Point(292, 18);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(134, 57);
            this.btnShowAll.TabIndex = 21;
            this.btnShowAll.Text = "SELECT ALL";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(574, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 57);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFormInsert);
            this.groupBox1.Controls.Add(this.btnFormSelectByID);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Forms";
            // 
            // functions
            // 
            this.functions.Controls.Add(this.btnUpdate);
            this.functions.Controls.Add(this.btnDelete);
            this.functions.Controls.Add(this.btnShowAll);
            this.functions.Controls.Add(this.btnNew);
            this.functions.Controls.Add(this.btnGet);
            this.functions.Location = new System.Drawing.Point(12, 109);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(714, 81);
            this.functions.TabIndex = 17;
            this.functions.TabStop = false;
            this.functions.Text = "Actions";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 514);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.form);
            this.Name = "Main";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.functions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.GroupBox form;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnFormInsert;
        private System.Windows.Forms.Button btnFormSelectByID;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox functions;
    }
}