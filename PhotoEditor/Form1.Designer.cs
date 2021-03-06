﻿namespace PhotoEditor
{
    partial class PhotoEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SelectPenColor = new System.Windows.Forms.Button();
            this.cmb_SelectBrushSize = new System.Windows.Forms.ComboBox();
            this.btn_DrawSquare = new System.Windows.Forms.Button();
            this.btn_DrawRectangle = new System.Windows.Forms.Button();
            this.btn_DrawCircle = new System.Windows.Forms.Button();
            this.labelBrushSize = new System.Windows.Forms.Label();
            this.labelBrushColor = new System.Windows.Forms.Label();
            this.labelShapeSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_redo = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.changeLangToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // changeLangToolStripMenuItem
            // 
            this.changeLangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLToolStripMenuItem,
            this.eNToolStripMenuItem});
            this.changeLangToolStripMenuItem.Name = "changeLangToolStripMenuItem";
            this.changeLangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.changeLangToolStripMenuItem.Text = "Zmień język";
            // 
            // pLToolStripMenuItem
            // 
            this.pLToolStripMenuItem.Name = "pLToolStripMenuItem";
            this.pLToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.pLToolStripMenuItem.Text = "PL";
            this.pLToolStripMenuItem.Click += new System.EventHandler(this.pLToolStripMenuItem_Click);
            // 
            // eNToolStripMenuItem
            // 
            this.eNToolStripMenuItem.Name = "eNToolStripMenuItem";
            this.eNToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.eNToolStripMenuItem.Text = "EN";
            this.eNToolStripMenuItem.Click += new System.EventHandler(this.eNToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.closeToolStripMenuItem.Text = "Wyjdź";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btn_SelectPenColor
            // 
            this.btn_SelectPenColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_SelectPenColor.Location = new System.Drawing.Point(27, 72);
            this.btn_SelectPenColor.Name = "btn_SelectPenColor";
            this.btn_SelectPenColor.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectPenColor.TabIndex = 3;
            this.btn_SelectPenColor.UseVisualStyleBackColor = false;
            this.btn_SelectPenColor.Click += new System.EventHandler(this.btn_SelectPenColor_Click);
            // 
            // cmb_SelectBrushSize
            // 
            this.cmb_SelectBrushSize.FormattingEnabled = true;
            this.cmb_SelectBrushSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_SelectBrushSize.Location = new System.Drawing.Point(27, 32);
            this.cmb_SelectBrushSize.Name = "cmb_SelectBrushSize";
            this.cmb_SelectBrushSize.Size = new System.Drawing.Size(75, 21);
            this.cmb_SelectBrushSize.TabIndex = 4;
            this.cmb_SelectBrushSize.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectBrushSize_SelectedIndexChanged);
            // 
            // btn_DrawSquare
            // 
            this.btn_DrawSquare.Location = new System.Drawing.Point(25, 53);
            this.btn_DrawSquare.Name = "btn_DrawSquare";
            this.btn_DrawSquare.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawSquare.TabIndex = 5;
            this.btn_DrawSquare.Text = "Kwadrat";
            this.btn_DrawSquare.UseVisualStyleBackColor = true;
            this.btn_DrawSquare.Click += new System.EventHandler(this.btn_DrawSquare_Click);
            // 
            // btn_DrawRectangle
            // 
            this.btn_DrawRectangle.Location = new System.Drawing.Point(25, 82);
            this.btn_DrawRectangle.Name = "btn_DrawRectangle";
            this.btn_DrawRectangle.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawRectangle.TabIndex = 6;
            this.btn_DrawRectangle.Text = "Prostokąt";
            this.btn_DrawRectangle.UseVisualStyleBackColor = true;
            this.btn_DrawRectangle.Click += new System.EventHandler(this.btn_DrawRectangle_Click);
            // 
            // btn_DrawCircle
            // 
            this.btn_DrawCircle.Location = new System.Drawing.Point(25, 111);
            this.btn_DrawCircle.Name = "btn_DrawCircle";
            this.btn_DrawCircle.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawCircle.TabIndex = 7;
            this.btn_DrawCircle.Text = "Okrąg";
            this.btn_DrawCircle.UseVisualStyleBackColor = true;
            this.btn_DrawCircle.Click += new System.EventHandler(this.btn_DrawCircle_Click);
            // 
            // labelBrushSize
            // 
            this.labelBrushSize.AutoSize = true;
            this.labelBrushSize.Location = new System.Drawing.Point(24, 16);
            this.labelBrushSize.Name = "labelBrushSize";
            this.labelBrushSize.Size = new System.Drawing.Size(79, 13);
            this.labelBrushSize.TabIndex = 9;
            this.labelBrushSize.Text = "Rozmiar pędzla";
            // 
            // labelBrushColor
            // 
            this.labelBrushColor.AutoSize = true;
            this.labelBrushColor.Location = new System.Drawing.Point(30, 56);
            this.labelBrushColor.Name = "labelBrushColor";
            this.labelBrushColor.Size = new System.Drawing.Size(65, 13);
            this.labelBrushColor.TabIndex = 10;
            this.labelBrushColor.Text = "Kolor pędzla";
            // 
            // labelShapeSize
            // 
            this.labelShapeSize.AutoSize = true;
            this.labelShapeSize.Location = new System.Drawing.Point(20, 146);
            this.labelShapeSize.Name = "labelShapeSize";
            this.labelShapeSize.Size = new System.Drawing.Size(86, 13);
            this.labelShapeSize.TabIndex = 12;
            this.labelShapeSize.Text = "Rozmiar kształtu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBrushSize);
            this.groupBox1.Controls.Add(this.btn_SelectPenColor);
            this.groupBox1.Controls.Add(this.labelBrushColor);
            this.groupBox1.Controls.Add(this.cmb_SelectBrushSize);
            this.groupBox1.Location = new System.Drawing.Point(18, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pędzel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Line);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.labelShapeSize);
            this.groupBox2.Controls.Add(this.btn_DrawRectangle);
            this.groupBox2.Controls.Add(this.btn_DrawSquare);
            this.groupBox2.Controls.Add(this.btn_DrawCircle);
            this.groupBox2.Location = new System.Drawing.Point(18, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kształt";
            // 
            // btn_Line
            // 
            this.btn_Line.Location = new System.Drawing.Point(25, 24);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(75, 23);
            this.btn_Line.TabIndex = 3;
            this.btn_Line.Text = "Linia";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(6, 19);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(55, 23);
            this.btn_undo.TabIndex = 3;
            this.btn_undo.Text = "Cofnij";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_redo
            // 
            this.btn_redo.Location = new System.Drawing.Point(80, 19);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(55, 23);
            this.btn_redo.TabIndex = 4;
            this.btn_redo.Text = "Ponów";
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(39, 48);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(60, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Wyczyść";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Clear);
            this.groupBox3.Controls.Add(this.btn_undo);
            this.groupBox3.Controls.Add(this.btn_redo);
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Akcje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(168, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 504);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 549);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(980, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 162);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(115, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // PhotoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 574);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhotoEditor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btn_SelectPenColor;
        private System.Windows.Forms.ComboBox cmb_SelectBrushSize;
        private System.Windows.Forms.Button btn_DrawSquare;
        private System.Windows.Forms.Button btn_DrawRectangle;
        private System.Windows.Forms.Button btn_DrawCircle;
        private System.Windows.Forms.Label labelBrushSize;
        private System.Windows.Forms.Label labelBrushColor;
        private System.Windows.Forms.Label labelShapeSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

