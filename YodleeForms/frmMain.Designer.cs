
namespace YodleeForms
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdViewAccounts = new System.Windows.Forms.DataGridView();
            this.cboxUserList = new System.Windows.Forms.ComboBox();
            this.btnGetAccounts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewAccounts
            // 
            this.grdViewAccounts.AllowUserToAddRows = false;
            this.grdViewAccounts.AllowUserToDeleteRows = false;
            this.grdViewAccounts.AllowUserToResizeRows = false;
            this.grdViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViewAccounts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdViewAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdViewAccounts.Location = new System.Drawing.Point(171, 240);
            this.grdViewAccounts.MultiSelect = false;
            this.grdViewAccounts.Name = "grdViewAccounts";
            this.grdViewAccounts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdViewAccounts.RowHeadersWidth = 62;
            this.grdViewAccounts.RowTemplate.Height = 28;
            this.grdViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewAccounts.Size = new System.Drawing.Size(668, 600);
            this.grdViewAccounts.TabIndex = 0;
            // 
            // cboxUserList
            // 
            this.cboxUserList.FormattingEnabled = true;
            this.cboxUserList.Location = new System.Drawing.Point(171, 38);
            this.cboxUserList.Name = "cboxUserList";
            this.cboxUserList.Size = new System.Drawing.Size(242, 28);
            this.cboxUserList.TabIndex = 1;
            // 
            // btnGetAccounts
            // 
            this.btnGetAccounts.Location = new System.Drawing.Point(171, 109);
            this.btnGetAccounts.Name = "btnGetAccounts";
            this.btnGetAccounts.Size = new System.Drawing.Size(242, 82);
            this.btnGetAccounts.TabIndex = 2;
            this.btnGetAccounts.Text = "Get Accounts";
            this.btnGetAccounts.UseVisualStyleBackColor = true;
            this.btnGetAccounts.Click += new System.EventHandler(this.btnGetAccounts_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 1153);
            this.Controls.Add(this.btnGetAccounts);
            this.Controls.Add(this.cboxUserList);
            this.Controls.Add(this.grdViewAccounts);
            this.Name = "frmMain";
            this.Text = "Yodlee";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewAccounts;
        private System.Windows.Forms.ComboBox cboxUserList;
        private System.Windows.Forms.Button btnGetAccounts;
    }
}

