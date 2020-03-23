using MPP_lab_first_C.Repo;
using MPP_lab_first_C.Service;

namespace MPP_lab_first_C
{
    partial class Vanzare
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.TableRezervare = new System.Windows.Forms.DataGridView();
            this.TableSearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ObiectivField = new System.Windows.Forms.TextBox();
            this.OraInceput = new System.Windows.Forms.TextBox();
            this.NumeField = new System.Windows.Forms.TextBox();
            this.TelefonField = new System.Windows.Forms.TextBox();
            this.BileteField = new System.Windows.Forms.TextBox();
            this.MinutInceput = new System.Windows.Forms.TextBox();
            this.OraSfarsit = new System.Windows.Forms.TextBox();
            this.MinutSfarsit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RezervaButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRezervare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(28, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(269, 150);
            this.Table.TabIndex = 0;
            // 
            // TableRezervare
            // 
            this.TableRezervare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableRezervare.Location = new System.Drawing.Point(532, 187);
            this.TableRezervare.Name = "TableRezervare";
            this.TableRezervare.Size = new System.Drawing.Size(240, 150);
            this.TableRezervare.TabIndex = 1;
            // 
            // TableSearch
            // 
            this.TableSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSearch.Location = new System.Drawing.Point(28, 187);
            this.TableSearch.Name = "TableSearch";
            this.TableSearch.Size = new System.Drawing.Size(269, 150);
            this.TableSearch.TabIndex = 2;
            this.TableSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSearch_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Obiectiv Turistic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interval Orar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numar Bilete";
            // 
            // ObiectivField
            // 
            this.ObiectivField.Location = new System.Drawing.Point(473, 41);
            this.ObiectivField.Name = "ObiectivField";
            this.ObiectivField.Size = new System.Drawing.Size(124, 20);
            this.ObiectivField.TabIndex = 8;
            // 
            // OraInceput
            // 
            this.OraInceput.Location = new System.Drawing.Point(473, 75);
            this.OraInceput.Name = "OraInceput";
            this.OraInceput.Size = new System.Drawing.Size(27, 20);
            this.OraInceput.TabIndex = 9;
            // 
            // NumeField
            // 
            this.NumeField.Location = new System.Drawing.Point(400, 199);
            this.NumeField.Name = "NumeField";
            this.NumeField.Size = new System.Drawing.Size(100, 20);
            this.NumeField.TabIndex = 10;
            // 
            // TelefonField
            // 
            this.TelefonField.Location = new System.Drawing.Point(400, 237);
            this.TelefonField.Name = "TelefonField";
            this.TelefonField.Size = new System.Drawing.Size(100, 20);
            this.TelefonField.TabIndex = 11;
            // 
            // BileteField
            // 
            this.BileteField.Location = new System.Drawing.Point(400, 278);
            this.BileteField.Name = "BileteField";
            this.BileteField.Size = new System.Drawing.Size(100, 20);
            this.BileteField.TabIndex = 12;
            // 
            // MinutInceput
            // 
            this.MinutInceput.Location = new System.Drawing.Point(499, 75);
            this.MinutInceput.Name = "MinutInceput";
            this.MinutInceput.Size = new System.Drawing.Size(26, 20);
            this.MinutInceput.TabIndex = 13;
            // 
            // OraSfarsit
            // 
            this.OraSfarsit.Location = new System.Drawing.Point(546, 75);
            this.OraSfarsit.Name = "OraSfarsit";
            this.OraSfarsit.Size = new System.Drawing.Size(27, 20);
            this.OraSfarsit.TabIndex = 14;
            // 
            // MinutSfarsit
            // 
            this.MinutSfarsit.Location = new System.Drawing.Point(570, 75);
            this.MinutSfarsit.Name = "MinutSfarsit";
            this.MinutSfarsit.Size = new System.Drawing.Size(27, 20);
            this.MinutSfarsit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "-";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(532, 139);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RezervaButton
            // 
            this.RezervaButton.Location = new System.Drawing.Point(425, 343);
            this.RezervaButton.Name = "RezervaButton";
            this.RezervaButton.Size = new System.Drawing.Size(75, 23);
            this.RezervaButton.TabIndex = 18;
            this.RezervaButton.Text = "Rezerva";
            this.RezervaButton.UseVisualStyleBackColor = true;
            this.RezervaButton.Click += new System.EventHandler(this.RezervaButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RezervaButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinutSfarsit);
            this.Controls.Add(this.OraSfarsit);
            this.Controls.Add(this.MinutInceput);
            this.Controls.Add(this.BileteField);
            this.Controls.Add(this.TelefonField);
            this.Controls.Add(this.NumeField);
            this.Controls.Add(this.OraInceput);
            this.Controls.Add(this.ObiectivField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableSearch);
            this.Controls.Add(this.TableRezervare);
            this.Controls.Add(this.Table);
            this.Name = "Vanzare";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableRezervare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridView TableRezervare;
        private System.Windows.Forms.DataGridView TableSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ObiectivField;
        private System.Windows.Forms.TextBox OraInceput;
        private System.Windows.Forms.TextBox NumeField;
        private System.Windows.Forms.TextBox TelefonField;
        private System.Windows.Forms.TextBox BileteField;
        private System.Windows.Forms.TextBox MinutInceput;
        private System.Windows.Forms.TextBox OraSfarsit;
        private System.Windows.Forms.TextBox MinutSfarsit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RezervaButton;
        private System.Windows.Forms.Button button3;
 
    }
}

