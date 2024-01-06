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
            this.label1 = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savebutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fill_on = new System.Windows.Forms.RadioButton();
            this.fill_off = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.drawingcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(829, 626);
            this.run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(108, 50);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(655, 626);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 50);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // syntax
            // 
            this.syntax.Location = new System.Drawing.Point(480, 626);
            this.syntax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.syntax.Name = "syntax";
            this.syntax.Size = new System.Drawing.Size(108, 50);
            this.syntax.TabIndex = 2;
            this.syntax.Text = "Syntax";
            this.syntax.UseVisualStyleBackColor = true;
            this.syntax.Click += new System.EventHandler(this.syntax_Click);
            // 
            // drawingcanvas
            // 
            this.drawingcanvas.Location = new System.Drawing.Point(480, 32);
            this.drawingcanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawingcanvas.Name = "drawingcanvas";
            this.drawingcanvas.Size = new System.Drawing.Size(457, 529);
            this.drawingcanvas.TabIndex = 3;
            this.drawingcanvas.TabStop = false;
            // 
            // singleline
            // 
            this.singleline.Location = new System.Drawing.Point(480, 581);
            this.singleline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleline.Name = "singleline";
            this.singleline.Size = new System.Drawing.Size(457, 22);
            this.singleline.TabIndex = 4;
            // 
            // multiline
            // 
            this.multiline.Location = new System.Drawing.Point(29, 32);
            this.multiline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiline.Multiline = true;
            this.multiline.Name = "multiline";
            this.multiline.Size = new System.Drawing.Size(423, 571);
            this.multiline.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 703);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "FILL VALUE :";
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(29, 626);
            this.openfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(108, 50);
            this.openfile.TabIndex = 8;
            this.openfile.Text = "Open File";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(163, 626);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(108, 50);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save File";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // fill_on
            // 
            this.fill_on.AutoSize = true;
            this.fill_on.Location = new System.Drawing.Point(573, 701);
            this.fill_on.Name = "fill_on";
            this.fill_on.Size = new System.Drawing.Size(48, 20);
            this.fill_on.TabIndex = 10;
            this.fill_on.TabStop = true;
            this.fill_on.Text = "ON";
            this.fill_on.UseVisualStyleBackColor = true;
            this.fill_on.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fill_off
            // 
            this.fill_off.AutoSize = true;
            this.fill_off.Location = new System.Drawing.Point(640, 701);
            this.fill_off.Name = "fill_off";
            this.fill_off.Size = new System.Drawing.Size(54, 20);
            this.fill_off.TabIndex = 11;
            this.fill_off.TabStop = true;
            this.fill_off.Text = "OFF";
            this.fill_off.UseVisualStyleBackColor = true;
            this.fill_off.CheckedChanged += new System.EventHandler(this.fill_off_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 742);
            this.Controls.Add(this.fill_off);
            this.Controls.Add(this.fill_on);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiline);
            this.Controls.Add(this.singleline);
            this.Controls.Add(this.drawingcanvas);
            this.Controls.Add(this.syntax);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.run);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton fill_on;
        private System.Windows.Forms.RadioButton fill_off;
    }
}

