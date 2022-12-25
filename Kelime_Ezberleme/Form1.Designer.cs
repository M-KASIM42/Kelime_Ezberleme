using System;
using System.Windows.Forms;

namespace Kelime_Ezberleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wordtext = new System.Windows.Forms.TextBox();
            this.sentence3text = new System.Windows.Forms.TextBox();
            this.sentence2text = new System.Windows.Forms.TextBox();
            this.sentence1text = new System.Windows.Forms.TextBox();
            this.meantext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.deletetext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "word";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "mean";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "sentence1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "sentence2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "sentence3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // wordtext
            // 
            this.wordtext.Location = new System.Drawing.Point(210, 48);
            this.wordtext.Name = "wordtext";
            this.wordtext.Size = new System.Drawing.Size(143, 22);
            this.wordtext.TabIndex = 5;
            // 
            // sentence3text
            // 
            this.sentence3text.Location = new System.Drawing.Point(210, 224);
            this.sentence3text.Name = "sentence3text";
            this.sentence3text.Size = new System.Drawing.Size(259, 22);
            this.sentence3text.TabIndex = 6;
            // 
            // sentence2text
            // 
            this.sentence2text.Location = new System.Drawing.Point(210, 173);
            this.sentence2text.Name = "sentence2text";
            this.sentence2text.Size = new System.Drawing.Size(259, 22);
            this.sentence2text.TabIndex = 7;
            // 
            // sentence1text
            // 
            this.sentence1text.Location = new System.Drawing.Point(210, 125);
            this.sentence1text.Name = "sentence1text";
            this.sentence1text.Size = new System.Drawing.Size(259, 22);
            this.sentence1text.TabIndex = 8;
            // 
            // meantext
            // 
            this.meantext.Location = new System.Drawing.Point(210, 82);
            this.meantext.Name = "meantext";
            this.meantext.Size = new System.Drawing.Size(143, 22);
            this.meantext.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 228);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Lime;
            this.addbutton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addbutton.Location = new System.Drawing.Point(636, 30);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(120, 50);
            this.addbutton.TabIndex = 11;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Lime;
            this.deletebutton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletebutton.Location = new System.Drawing.Point(636, 97);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(120, 50);
            this.deletebutton.TabIndex = 12;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.Lime;
            this.updatebutton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatebutton.Location = new System.Drawing.Point(636, 165);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(120, 50);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(124, 6);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(39, 30);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Id";
            // 
            // idtext
            // 
            this.idtext.HideSelection = false;
            this.idtext.Location = new System.Drawing.Point(210, 13);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(143, 22);
            this.idtext.TabIndex = 15;
            this.idtext.Tag = "";
            // 
            // deletetext
            // 
            this.deletetext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletetext.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletetext.Location = new System.Drawing.Point(421, 48);
            this.deletetext.Name = "deletetext";
            this.deletetext.Size = new System.Drawing.Size(120, 50);
            this.deletetext.TabIndex = 16;
            this.deletetext.Text = "text delete";
            this.deletetext.UseVisualStyleBackColor = false;
            this.deletetext.Click += new System.EventHandler(this.deletetext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Kelime_Ezberleme.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(917, 509);
            this.Controls.Add(this.deletetext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.meantext);
            this.Controls.Add(this.sentence1text);
            this.Controls.Add(this.sentence2text);
            this.Controls.Add(this.sentence3text);
            this.Controls.Add(this.wordtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wordtext;
        private System.Windows.Forms.TextBox sentence3text;
        private System.Windows.Forms.TextBox sentence2text;
        private System.Windows.Forms.TextBox sentence1text;
        private System.Windows.Forms.TextBox meantext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox idtext;
        private Button deletetext;
    }
}

