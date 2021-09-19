
namespace Model4BankProject
{
    partial class UserInterface
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
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.rdbSavings = new System.Windows.Forms.RadioButton();
            this.rdbPersonal = new System.Windows.Forms.RadioButton();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTransactions
            // 
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.Location = new System.Drawing.Point(12, 62);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(204, 121);
            this.lstTransactions.TabIndex = 0;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(181, 186);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(35, 13);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "label1";
            // 
            // rdbSavings
            // 
            this.rdbSavings.AutoSize = true;
            this.rdbSavings.Checked = true;
            this.rdbSavings.Location = new System.Drawing.Point(12, 28);
            this.rdbSavings.Name = "rdbSavings";
            this.rdbSavings.Size = new System.Drawing.Size(75, 17);
            this.rdbSavings.TabIndex = 3;
            this.rdbSavings.TabStop = true;
            this.rdbSavings.Text = "SparKonto";
            this.rdbSavings.UseVisualStyleBackColor = true;
            this.rdbSavings.CheckedChanged += new System.EventHandler(this.CheckChangedEvent);
            // 
            // rdbPersonal
            // 
            this.rdbPersonal.AutoSize = true;
            this.rdbPersonal.Location = new System.Drawing.Point(133, 28);
            this.rdbPersonal.Name = "rdbPersonal";
            this.rdbPersonal.Size = new System.Drawing.Size(86, 17);
            this.rdbPersonal.TabIndex = 4;
            this.rdbPersonal.Text = "PersonKonto";
            this.rdbPersonal.UseVisualStyleBackColor = true;
            this.rdbPersonal.CheckedChanged += new System.EventHandler(this.CheckChangedEvent);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(234, 62);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(115, 23);
            this.btnNewTransaction.TabIndex = 5;
            this.btnNewTransaction.Text = "Ny Transaktion";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(234, 91);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(115, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Uttag";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(234, 120);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(115, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Insättning";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(234, 149);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(115, 23);
            this.btnCalculateInterest.TabIndex = 8;
            this.btnCalculateInterest.Text = "Beräkna Ränta";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.rdbPersonal);
            this.Controls.Add(this.rdbSavings);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lstTransactions);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTransactions;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.RadioButton rdbSavings;
        private System.Windows.Forms.RadioButton rdbPersonal;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCalculateInterest;
    }
}