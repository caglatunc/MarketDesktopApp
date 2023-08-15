namespace _02.MarketDesktopApp
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            lbTotal = new Label();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnKK = new Button();
            txtPayment = new TextBox();
            groupBox5 = new GroupBox();
            btnReset = new Button();
            btnComplete = new Button();
            lbRemaining = new Label();
            groupBox6 = new GroupBox();
            dgPayment = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox3.SuspendLayout();
            gbPayment.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(0, 14);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(632, 81);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(12, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(632, 508);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = SystemColors.ButtonFace;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Index, Name, Quantity, Price, TotalPrice });
            dgList.Location = new Point(9, 19);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(617, 483);
            dgList.TabIndex = 0;
            // 
            // Index
            // 
            Index.HeaderText = "#";
            Index.Name = "Index";
            Index.Width = 50;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 250;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.Name = "TotalPrice";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Location = new Point(650, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Chocolate;
            lbTotal.Location = new Point(69, 33);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(221, 35);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "0,00₺";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnKK);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.FlatStyle = FlatStyle.System;
            gbPayment.Location = new Point(650, 127);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(336, 189);
            gbPayment.TabIndex = 3;
            gbPayment.TabStop = false;
            // 
            // btnCash
            // 
            btnCash.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.Image = Properties.Resources.Money_icon;
            btnCash.Location = new Point(174, 64);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(130, 119);
            btnCash.TabIndex = 2;
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // btnKK
            // 
            btnKK.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKK.Image = Properties.Resources.FontAwesome_Credit_Card_icon;
            btnKK.Location = new Point(38, 64);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(130, 119);
            btnKK.TabIndex = 1;
            btnKK.UseVisualStyleBackColor = true;
            btnKK.Click += btnKK_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.Black;
            txtPayment.Location = new Point(6, 19);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(330, 44);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "0";
            txtPayment.TextAlign = HorizontalAlignment.Center;
           
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(lbRemaining);
            groupBox5.FlatStyle = FlatStyle.Popup;
            groupBox5.Location = new Point(650, 461);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(336, 174);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.SandyBrown;
            btnReset.Image = Properties.Resources.Places_trash_full_icon;
            btnReset.Location = new Point(6, 52);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 128);
            btnReset.TabIndex = 3;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.Image = Properties.Resources.Clear_Tick_icon;
            btnComplete.Location = new Point(174, 55);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(162, 119);
            btnComplete.TabIndex = 2;
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // lbRemaining
            // 
            lbRemaining.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbRemaining.ForeColor = Color.Chocolate;
            lbRemaining.Location = new Point(57, 17);
            lbRemaining.Name = "lbRemaining";
            lbRemaining.Size = new Size(221, 35);
            lbRemaining.TabIndex = 1;
            lbRemaining.Text = "0,00₺";
            lbRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(656, 322);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(337, 153);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ButtonFace;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgPayment.Location = new Point(0, 0);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(337, 153);
            dgPayment.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Type";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 637);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(gbPayment);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox3.ResumeLayout(false);
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox gbPayment;
        private TextBox txtBarcode;
        private GroupBox groupBox5;
        private DataGridView dgList;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private Button btnKK;
        private TextBox txtPayment;
        private Button btnCash;
        private Button btnReset;
        private Button btnComplete;
        private Label lbRemaining;
        private GroupBox groupBox6;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label lbTotal;
    }
}