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
            this.run = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.syntax = new System.Windows.Forms.Button();
            this.drawingcanvas = new System.Windows.Forms.PictureBox();
            this.singleline = new System.Windows.Forms.TextBox();
            this.multiline = new System.Windows.Forms.TextBox();
            this.fillvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(622, 509);
            this.run.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(81, 41);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(491, 509);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(81, 41);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // syntax
            // 
            this.syntax.Location = new System.Drawing.Point(360, 509);
            this.syntax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syntax.Name = "syntax";
            this.syntax.Size = new System.Drawing.Size(81, 41);
            this.syntax.TabIndex = 2;
            this.syntax.Text = "Syntax";
            this.syntax.UseVisualStyleBackColor = true;
            this.syntax.Click += new System.EventHandler(this.syntax_Click);
            // 
            // drawingcanvas
            // 
            this.drawingcanvas.Location = new System.Drawing.Point(360, 26);
            this.drawingcanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawingcanvas.Name = "drawingcanvas";
            this.drawingcanvas.Size = new System.Drawing.Size(343, 430);
            this.drawingcanvas.TabIndex = 3;
            this.drawingcanvas.TabStop = false;
            // 
            // singleline
            // 
            this.singleline.Location = new System.Drawing.Point(360, 472);
            this.singleline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.singleline.Name = "singleline";
            this.singleline.Size = new System.Drawing.Size(344, 20);
            this.singleline.TabIndex = 4;
            // 
            // multiline
            // 
            this.multiline.Location = new System.Drawing.Point(22, 26);
            this.multiline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiline.Multiline = true;
            this.multiline.Name = "multiline";
            this.multiline.Size = new System.Drawing.Size(318, 465);
            this.multiline.TabIndex = 5;
            // 
            // fillvalue
            // 
            this.fillvalue.Location = new System.Drawing.Point(360, 568);
            this.fillvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fillvalue.Name = "fillvalue";
            this.fillvalue.Size = new System.Drawing.Size(81, 20);
            this.fillvalue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FILL VALUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillvalue);
            this.Controls.Add(this.multiline);
            this.Controls.Add(this.singleline);
            this.Controls.Add(this.drawingcanvas);
            this.Controls.Add(this.syntax);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.run);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingcanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button syntax;
        private System.Windows.Forms.PictureBox drawingcanvas;
        private System.Windows.Forms.TextBox singleline;
        private System.Windows.Forms.TextBox multiline;
        private System.Windows.Forms.TextBox fillvalue;
        private System.Windows.Forms.Label label1;
    }
}

