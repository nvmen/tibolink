
namespace TiboLink
{
    partial class frmLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLink));
            this.cbSiteA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSiteB = new System.Windows.Forms.ComboBox();
            this.btRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSiteA
            // 
            this.cbSiteA.DropDownHeight = 200;
            this.cbSiteA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteA.FormattingEnabled = true;
            this.cbSiteA.IntegralHeight = false;
            this.cbSiteA.ItemHeight = 25;
            this.cbSiteA.Location = new System.Drawing.Point(36, 69);
            this.cbSiteA.Name = "cbSiteA";
            this.cbSiteA.Size = new System.Drawing.Size(295, 33);
            this.cbSiteA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Site B";
            // 
            // cbSiteB
            // 
            this.cbSiteB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSiteB.FormattingEnabled = true;
            this.cbSiteB.Location = new System.Drawing.Point(377, 69);
            this.cbSiteB.Name = "cbSiteB";
            this.cbSiteB.Size = new System.Drawing.Size(290, 33);
            this.cbSiteB.TabIndex = 2;
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(856, 66);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(131, 36);
            this.btRun.TabIndex = 4;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Ex: https://monita.vn)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Ex: https://monita.vn)";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(36, 143);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(952, 522);
            this.txtInput.TabIndex = 7;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Input main link with code(https://domain.com/product/abc|shortcode)";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Teal;
            this.lbResult.Location = new System.Drawing.Point(705, 71);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 31);
            this.lbResult.TabIndex = 10;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(826, 812);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(176, 53);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(36, 716);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(727, 149);
            this.txtLog.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 679);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Error Log";
            // 
            // frmLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 877);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSiteB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSiteA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Link Tibo";
            this.Load += new System.EventHandler(this.frmLink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSiteA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSiteB;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label6;
    }
}

