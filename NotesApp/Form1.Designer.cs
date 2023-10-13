using NotesApp.Models;

namespace NotesApp
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
            dgNoteList = new DataGridView();
            DataColum = new DataGridViewTextBoxColumn();
            IsDone = new DataGridViewCheckBoxColumn();
            TextColum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgNoteList).BeginInit();
            SuspendLayout();
            // 
            // dgNoteList
            // 
            dgNoteList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNoteList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNoteList.Columns.AddRange(new DataGridViewColumn[] { DataColum, IsDone, TextColum });
            dgNoteList.Dock = DockStyle.Fill;
            dgNoteList.Location = new Point(0, 0);
            dgNoteList.Name = "dgNoteList";
            dgNoteList.RowHeadersWidth = 30;
            dgNoteList.RowTemplate.Height = 29;
            dgNoteList.Size = new Size(800, 450);
            dgNoteList.TabIndex = 0;
            // 
            // DataColum
            // 
            DataColum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataColum.DataPropertyName = "CreationDate";
            DataColum.HeaderText = "Дата";
            DataColum.MinimumWidth = 6;
            DataColum.Name = "DataColum";
            DataColum.Width = 125;
            // 
            // IsDone
            // 
            IsDone.DataPropertyName = "IsDone";
            IsDone.HeaderText = "Выполнение";
            IsDone.MinimumWidth = 6;
            IsDone.Name = "IsDone";
            // 
            // TextColum
            // 
            TextColum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TextColum.DataPropertyName = "Text";
            TextColum.HeaderText = "Текст";
            TextColum.MinimumWidth = 6;
            TextColum.Name = "TextColum";
            TextColum.Resizable = DataGridViewTriState.True;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgNoteList);
            Name = "Form1";
            Text = "Заметки";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgNoteList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgNoteList;
        private DataGridViewTextBoxColumn DataColum;
        private DataGridViewCheckBoxColumn IsDone;
        private DataGridViewTextBoxColumn TextColum;
    }
}