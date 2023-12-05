namespace GDI__Assignment_ASE
{
    partial class Form1
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
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.syntax = new System.Windows.Forms.Button();
            this.drawingcanvas = new System.Windows.Forms.PictureBox();
            this.singleline = new System.Windows.Forms.TextBox();
            this.multiline = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(829, 627);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(108, 51);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(655, 627);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 51);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // syntax
            // 
            this.syntax.Location = new System.Drawing.Point(480, 627);
            this.syntax.Name = "syntax";
            this.syntax.Size = new System.Drawing.Size(108, 51);
            this.syntax.TabIndex = 2;
            this.syntax.Text = "Syntax";
            this.syntax.UseVisualStyleBackColor = true;
            // 
            // drawingcanvas
            // 
            this.drawingcanvas.Location = new System.Drawing.Point(480, 32);
            this.drawingcanvas.Name = "drawingcanvas";
            this.drawingcanvas.Size = new System.Drawing.Size(457, 529);
            this.drawingcanvas.TabIndex = 3;
            this.drawingcanvas.TabStop = false;
            // 
            // singleline
            // 
            this.singleline.Location = new System.Drawing.Point(480, 581);
            this.singleline.Name = "singleline";
            this.singleline.Size = new System.Drawing.Size(457, 22);
            this.singleline.TabIndex = 4;
            // 
            // multiline
            // 
            this.multiline.Location = new System.Drawing.Point(29, 32);
            this.multiline.Multiline = true;
            this.multiline.Name = "multiline";
            this.multiline.Size = new System.Drawing.Size(423, 571);
            this.multiline.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 742);
            this.Controls.Add(this.multiline);
            this.Controls.Add(this.singleline);
            this.Controls.Add(this.drawingcanvas);
            this.Controls.Add(this.syntax);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingcanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button syntax;
        private System.Windows.Forms.PictureBox drawingcanvas;
        private System.Windows.Forms.TextBox singleline;
        private System.Windows.Forms.TextBox multiline;
    }
}

