namespace lab8
{
    partial class Lab8MainWindow
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
            this.orators = new System.Windows.Forms.ListBox();
            this.standartorators = new System.Windows.Forms.Button();
            this.sortByCountry = new System.Windows.Forms.Button();
            this.sectionField = new System.Windows.Forms.TextBox();
            this.getBySection = new System.Windows.Forms.Button();
            this.writeToFile = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.Button();
            this.lowerForUkraine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orators
            // 
            this.orators.FormattingEnabled = true;
            this.orators.Location = new System.Drawing.Point(49, 62);
            this.orators.Name = "orators";
            this.orators.Size = new System.Drawing.Size(608, 433);
            this.orators.TabIndex = 1;
            this.orators.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.orators_Format);
            // 
            // standartorators
            // 
            this.standartorators.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standartorators.Location = new System.Drawing.Point(691, 62);
            this.standartorators.Name = "standartorators";
            this.standartorators.Size = new System.Drawing.Size(216, 59);
            this.standartorators.TabIndex = 2;
            this.standartorators.Text = "Fill standart orators";
            this.standartorators.UseVisualStyleBackColor = true;
            this.standartorators.Click += new System.EventHandler(this.standartorators_Click);
            // 
            // sortByCountry
            // 
            this.sortByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByCountry.Location = new System.Drawing.Point(691, 127);
            this.sortByCountry.Name = "sortByCountry";
            this.sortByCountry.Size = new System.Drawing.Size(216, 59);
            this.sortByCountry.TabIndex = 3;
            this.sortByCountry.Text = "Sort by country";
            this.sortByCountry.UseVisualStyleBackColor = true;
            this.sortByCountry.Click += new System.EventHandler(this.sortByCountry_Click);
            // 
            // sectionField
            // 
            this.sectionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sectionField.Location = new System.Drawing.Point(691, 404);
            this.sectionField.Name = "sectionField";
            this.sectionField.Size = new System.Drawing.Size(216, 27);
            this.sectionField.TabIndex = 4;
            // 
            // getBySection
            // 
            this.getBySection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getBySection.Location = new System.Drawing.Point(691, 437);
            this.getBySection.Name = "getBySection";
            this.getBySection.Size = new System.Drawing.Size(216, 59);
            this.getBySection.TabIndex = 5;
            this.getBySection.Text = "Get by section";
            this.getBySection.UseVisualStyleBackColor = true;
            this.getBySection.Click += new System.EventHandler(this.getBySection_Click);
            // 
            // writeToFile
            // 
            this.writeToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeToFile.Location = new System.Drawing.Point(691, 257);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(216, 59);
            this.writeToFile.TabIndex = 6;
            this.writeToFile.Text = "Write current collection to file";
            this.writeToFile.UseVisualStyleBackColor = true;
            this.writeToFile.Click += new System.EventHandler(this.writeToFile_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readFromFile.Location = new System.Drawing.Point(691, 322);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(216, 59);
            this.readFromFile.TabIndex = 7;
            this.readFromFile.Text = "Read collection from file";
            this.readFromFile.UseVisualStyleBackColor = true;
            this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
            // 
            // lowerForUkraine
            // 
            this.lowerForUkraine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowerForUkraine.Location = new System.Drawing.Point(691, 192);
            this.lowerForUkraine.Name = "lowerForUkraine";
            this.lowerForUkraine.Size = new System.Drawing.Size(216, 59);
            this.lowerForUkraine.TabIndex = 8;
            this.lowerForUkraine.Text = "Lower membership fee for Ukrainians";
            this.lowerForUkraine.UseVisualStyleBackColor = true;
            this.lowerForUkraine.Click += new System.EventHandler(this.lowerForUkraine_Click);
            // 
            // Lab8MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 530);
            this.Controls.Add(this.lowerForUkraine);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.writeToFile);
            this.Controls.Add(this.getBySection);
            this.Controls.Add(this.sectionField);
            this.Controls.Add(this.sortByCountry);
            this.Controls.Add(this.standartorators);
            this.Controls.Add(this.orators);
            this.Name = "Lab8MainWindow";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orators;
        private System.Windows.Forms.Button standartorators;
        private System.Windows.Forms.Button sortByCountry;
        private System.Windows.Forms.TextBox sectionField;
        private System.Windows.Forms.Button getBySection;
        private System.Windows.Forms.Button writeToFile;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Button lowerForUkraine;
    }
}

