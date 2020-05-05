namespace ArrayGUI
{
    partial class FormCh8Arrays
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
            this.buttonNewNumbers = new System.Windows.Forms.Button();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.buttonClearLlistBox = new System.Windows.Forms.Button();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.buttonSortAscending = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonLowest = new System.Windows.Forms.Button();
            this.buttonHighest = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewNumbers
            // 
            this.buttonNewNumbers.Location = new System.Drawing.Point(228, 36);
            this.buttonNewNumbers.Name = "buttonNewNumbers";
            this.buttonNewNumbers.Size = new System.Drawing.Size(210, 44);
            this.buttonNewNumbers.TabIndex = 0;
            this.buttonNewNumbers.Text = "New Numbers";
            this.buttonNewNumbers.UseVisualStyleBackColor = true;
            this.buttonNewNumbers.Click += new System.EventHandler(this.buttonNewNumbers_Click);
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.ItemHeight = 19;
            this.listBoxArray.Location = new System.Drawing.Point(48, 36);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(120, 593);
            this.listBoxArray.TabIndex = 12;
            // 
            // buttonClearLlistBox
            // 
            this.buttonClearLlistBox.Location = new System.Drawing.Point(228, 144);
            this.buttonClearLlistBox.Name = "buttonClearLlistBox";
            this.buttonClearLlistBox.Size = new System.Drawing.Size(210, 44);
            this.buttonClearLlistBox.TabIndex = 1;
            this.buttonClearLlistBox.Text = "Clear ListBox";
            this.buttonClearLlistBox.UseVisualStyleBackColor = true;
            this.buttonClearLlistBox.Click += new System.EventHandler(this.buttonClearLlistBox_Click);
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(526, 144);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(210, 44);
            this.buttonAvg.TabIndex = 6;
            this.buttonAvg.Text = "Average";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(228, 585);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(210, 44);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(228, 471);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(210, 44);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Location = new System.Drawing.Point(228, 364);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(210, 44);
            this.buttonSortDescending.TabIndex = 3;
            this.buttonSortDescending.Text = "Sort Descending";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Location = new System.Drawing.Point(228, 256);
            this.buttonSortAscending.Name = "buttonSortAscending";
            this.buttonSortAscending.Size = new System.Drawing.Size(210, 44);
            this.buttonSortAscending.TabIndex = 2;
            this.buttonSortAscending.Text = "Sort Ascending";
            this.buttonSortAscending.UseVisualStyleBackColor = true;
            this.buttonSortAscending.Click += new System.EventHandler(this.buttonSortAscending_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(526, 36);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(210, 44);
            this.buttonSum.TabIndex = 5;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonLowest
            // 
            this.buttonLowest.Location = new System.Drawing.Point(526, 256);
            this.buttonLowest.Name = "buttonLowest";
            this.buttonLowest.Size = new System.Drawing.Size(210, 44);
            this.buttonLowest.TabIndex = 7;
            this.buttonLowest.Text = "Lowest";
            this.buttonLowest.UseVisualStyleBackColor = true;
            this.buttonLowest.Click += new System.EventHandler(this.buttonLowest_Click);
            // 
            // buttonHighest
            // 
            this.buttonHighest.Location = new System.Drawing.Point(526, 364);
            this.buttonHighest.Name = "buttonHighest";
            this.buttonHighest.Size = new System.Drawing.Size(210, 44);
            this.buttonHighest.TabIndex = 8;
            this.buttonHighest.Text = "Highest";
            this.buttonHighest.UseVisualStyleBackColor = true;
            this.buttonHighest.Click += new System.EventHandler(this.buttonHighest_Click);
            // 
            // buttonMedian
            // 
            this.buttonMedian.Location = new System.Drawing.Point(526, 471);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(210, 44);
            this.buttonMedian.TabIndex = 9;
            this.buttonMedian.Text = "Median";
            this.buttonMedian.UseVisualStyleBackColor = true;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(526, 585);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(210, 44);
            this.buttonRange.TabIndex = 10;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click_1);
            // 
            // FormCh8Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(795, 643);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonMedian);
            this.Controls.Add(this.buttonHighest);
            this.Controls.Add(this.buttonLowest);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonSortAscending);
            this.Controls.Add(this.buttonSortDescending);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.buttonClearLlistBox);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.buttonNewNumbers);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCh8Arrays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ch8Arrays";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewNumbers;
        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.Button buttonClearLlistBox;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSortDescending;
        private System.Windows.Forms.Button buttonSortAscending;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonLowest;
        private System.Windows.Forms.Button buttonHighest;
        private System.Windows.Forms.Button buttonMedian;
        private System.Windows.Forms.Button buttonRange;
    }
}

