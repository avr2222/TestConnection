namespace TestConnection
{
    partial class ConnectionTester
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
            this.txtConnection_string = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.connectionTesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionTesterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnection_string
            // 
            this.txtConnection_string.Location = new System.Drawing.Point(12, 101);
            this.txtConnection_string.Multiline = true;
            this.txtConnection_string.Name = "txtConnection_string";
            this.txtConnection_string.Size = new System.Drawing.Size(370, 104);
            this.txtConnection_string.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBase Connection Test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Connection String";
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(271, 211);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(111, 28);
            this.btntest.TabIndex = 3;
            this.btntest.Text = "Test Connection";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(413, 101);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(365, 104);
            this.txtQuery.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Your Sql Query";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 177);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(667, 211);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(111, 28);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute Query";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(384, 248);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 15);
            this.lblstatus.TabIndex = 9;
            // 
            // connectionTesterBindingSource
            // 
            this.connectionTesterBindingSource.DataSource = typeof(TestConnection.ConnectionTester);
            // 
            // ConnectionTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnection_string);
            this.Name = "ConnectionTester";
            this.Text = "DataBase Connection Test";
            this.Load += new System.EventHandler(this.ConnectionTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionTesterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnection_string;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource connectionTesterBindingSource;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblstatus;
    }
}

