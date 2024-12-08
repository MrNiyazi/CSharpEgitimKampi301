namespace CSharpEgitimKampi301.PransentationLayer
{
	partial class FrmCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCategoryID = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbActive = new System.Windows.Forms.RadioButton();
			this.rdbPacive = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnGetById = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori ID:";
			// 
			// txtCategoryID
			// 
			this.txtCategoryID.Location = new System.Drawing.Point(138, 28);
			this.txtCategoryID.Name = "txtCategoryID";
			this.txtCategoryID.Size = new System.Drawing.Size(117, 22);
			this.txtCategoryID.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(29, 146);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(160, 34);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(269, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(774, 422);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(138, 66);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(117, 22);
			this.txtCategoryName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kategori Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kategori Durumu:";
			// 
			// rdbActive
			// 
			this.rdbActive.AutoSize = true;
			this.rdbActive.Location = new System.Drawing.Point(138, 109);
			this.rdbActive.Name = "rdbActive";
			this.rdbActive.Size = new System.Drawing.Size(53, 20);
			this.rdbActive.TabIndex = 8;
			this.rdbActive.TabStop = true;
			this.rdbActive.Text = "Aktif";
			this.rdbActive.UseVisualStyleBackColor = true;
			// 
			// rdbPacive
			// 
			this.rdbPacive.AutoSize = true;
			this.rdbPacive.Location = new System.Drawing.Point(197, 109);
			this.rdbPacive.Name = "rdbPacive";
			this.rdbPacive.Size = new System.Drawing.Size(58, 20);
			this.rdbPacive.TabIndex = 9;
			this.rdbPacive.TabStop = true;
			this.rdbPacive.Text = "Pasif";
			this.rdbPacive.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(29, 182);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(160, 34);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(29, 222);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(160, 34);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(29, 262);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(160, 34);
			this.btnUpdate.TabIndex = 12;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(31, 302);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(160, 34);
			this.btnGetById.TabIndex = 13;
			this.btnGetById.Text = "ID ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 450);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rdbPacive);
			this.Controls.Add(this.rdbActive);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCategoryID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmCategory";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategoryID;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdbActive;
		private System.Windows.Forms.RadioButton rdbPacive;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnGetById;
	}
}

