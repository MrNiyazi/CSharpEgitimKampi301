namespace CSharpEgitimKampi301.PransentationLayer
{
	partial class FrmProduct
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductDescription = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnList2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(46, 449);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(231, 30);
			this.btnGetById.TabIndex = 26;
			this.btnGetById.Text = "ID ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(46, 409);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(231, 30);
			this.btnUpdate.TabIndex = 25;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(44, 369);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(233, 30);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(44, 329);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(233, 30);
			this.btnAdd.TabIndex = 23;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(130, 64);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(147, 22);
			this.txtProductName.TabIndex = 19;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(297, 29);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(883, 453);
			this.dataGridView1.TabIndex = 17;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(44, 257);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(108, 66);
			this.btnList.TabIndex = 16;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(130, 29);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(147, 22);
			this.txtProductID.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Ürün Adı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Ürün ID:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(130, 133);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(147, 22);
			this.txtProductPrice.TabIndex = 30;
			this.txtProductPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(130, 95);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(147, 22);
			this.txtProductStock.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "Ürün Fiyat:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Ürün Stok:";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(130, 199);
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(147, 22);
			this.txtProductDescription.TabIndex = 34;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(41, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 33;
			this.label6.Text = "Açıklama:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(41, 161);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 16);
			this.label7.TabIndex = 31;
			this.label7.Text = "Kategori:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(130, 161);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(147, 24);
			this.comboBox1.TabIndex = 35;
			// 
			// btnList2
			// 
			this.btnList2.Location = new System.Drawing.Point(158, 257);
			this.btnList2.Name = "btnList2";
			this.btnList2.Size = new System.Drawing.Size(121, 66);
			this.btnList2.TabIndex = 36;
			this.btnList2.Text = "Listele 2";
			this.btnList2.UseVisualStyleBackColor = true;
			this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1198, 494);
			this.Controls.Add(this.btnList2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtProductDescription);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmProduct";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProductDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnList2;
	}
}