﻿namespace GeometriaRestAPIWeb
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
            btnConsulta = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(268, 187);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(112, 62);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "Actualizar Lista";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 379);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(listBox1);
            Controls.Add(btnConsulta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsulta;
        private ListBox listBox1;
    }
}
