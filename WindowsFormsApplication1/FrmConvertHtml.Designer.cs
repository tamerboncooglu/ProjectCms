﻿namespace WindowsFormsApplication1
{
    partial class FrmConvertHtml
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
            this.btn2Html = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2Html
            // 
            this.btn2Html.Location = new System.Drawing.Point(22, 291);
            this.btn2Html.Name = "btn2Html";
            this.btn2Html.Size = new System.Drawing.Size(75, 23);
            this.btn2Html.TabIndex = 0;
            this.btn2Html.Text = "2 Html";
            this.btn2Html.UseVisualStyleBackColor = true;
            this.btn2Html.Click += new System.EventHandler(this.btn2Html_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Location = new System.Drawing.Point(22, 12);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(542, 264);
            this.grdList.TabIndex = 2;
            this.grdList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellClick);
            // 
            // FrmConvertHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 608);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn2Html);
            this.Name = "FrmConvertHtml";
            this.Text = "Dosya Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2Html;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView grdList;
    }
}

