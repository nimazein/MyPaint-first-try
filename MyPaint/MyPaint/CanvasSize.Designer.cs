namespace MyPaint
{
    partial class CanvasSize
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBHeight = new System.Windows.Forms.TextBox();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTCancel = new System.Windows.Forms.Button();
            this.BTOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота:";
            // 
            // TBHeight
            // 
            this.TBHeight.Location = new System.Drawing.Point(252, 43);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(73, 20);
            this.TBHeight.TabIndex = 3;
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(64, 43);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(73, 20);
            this.TBWidth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 2);
            this.label3.TabIndex = 5;
            // 
            // BTCancel
            // 
            this.BTCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancel.Location = new System.Drawing.Point(250, 117);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 7;
            this.BTCancel.Text = "Отмена";
            this.BTCancel.UseVisualStyleBackColor = true;
            // 
            // BTOk
            // 
            this.BTOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOk.Location = new System.Drawing.Point(154, 117);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(75, 23);
            this.BTOk.TabIndex = 8;
            this.BTOk.Text = "OK";
            this.BTOk.UseVisualStyleBackColor = true;
            // 
            // CanvasSize
            // 
            this.AcceptButton = this.BTOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTCancel;
            this.ClientSize = new System.Drawing.Size(363, 150);
            this.Controls.Add(this.BTOk);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.TBHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CanvasSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBHeight;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTOk;
    }
}