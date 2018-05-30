namespace PhotoEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SelectPenColor = new System.Windows.Forms.Button();
            this.cmb_SelectBrushSize = new System.Windows.Forms.ComboBox();
            this.btn_DrawSquare = new System.Windows.Forms.Button();
            this.btn_DrawRectangle = new System.Windows.Forms.Button();
            this.btn_DrawCircle = new System.Windows.Forms.Button();
            this.txt_SelectShapeSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oAplikacjiToolStripMenuItem});
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // changeLangToolStripMenuItem
            // 
            this.changeLangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLToolStripMenuItem,
            this.eNToolStripMenuItem});
            this.changeLangToolStripMenuItem.Name = "changeLangToolStripMenuItem";
            this.changeLangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeLangToolStripMenuItem.Text = "Zmień język";
            // 
            // pLToolStripMenuItem
            // 
            this.pLToolStripMenuItem.Name = "pLToolStripMenuItem";
            this.pLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pLToolStripMenuItem.Text = "PL";
            // 
            // eNToolStripMenuItem
            // 
            this.eNToolStripMenuItem.Name = "eNToolStripMenuItem";
            this.eNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eNToolStripMenuItem.Text = "EN";
            // 
            // oAplikacjiToolStripMenuItem
            // 
            this.oAplikacjiToolStripMenuItem.Name = "oAplikacjiToolStripMenuItem";
            this.oAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.oAplikacjiToolStripMenuItem.Text = "O aplikacji";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Wyjdź";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(152, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 505);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_SelectPenColor
            // 
            this.btn_SelectPenColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_SelectPenColor.Location = new System.Drawing.Point(31, 60);
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
            this.cmb_SelectBrushSize.Location = new System.Drawing.Point(31, 20);
            this.cmb_SelectBrushSize.Name = "cmb_SelectBrushSize";
            this.cmb_SelectBrushSize.Size = new System.Drawing.Size(75, 21);
            this.cmb_SelectBrushSize.TabIndex = 4;
            // 
            // btn_DrawSquare
            // 
            this.btn_DrawSquare.Location = new System.Drawing.Point(33, 26);
            this.btn_DrawSquare.Name = "btn_DrawSquare";
            this.btn_DrawSquare.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawSquare.TabIndex = 5;
            this.btn_DrawSquare.Text = "Kwadrat";
            this.btn_DrawSquare.UseVisualStyleBackColor = true;
            this.btn_DrawSquare.Click += new System.EventHandler(this.btn_DrawSquare_Click);
            // 
            // btn_DrawRectangle
            // 
            this.btn_DrawRectangle.Location = new System.Drawing.Point(33, 55);
            this.btn_DrawRectangle.Name = "btn_DrawRectangle";
            this.btn_DrawRectangle.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawRectangle.TabIndex = 6;
            this.btn_DrawRectangle.Text = "Prostokąt";
            this.btn_DrawRectangle.UseVisualStyleBackColor = true;
            this.btn_DrawRectangle.Click += new System.EventHandler(this.btn_DrawRectangle_Click);
            // 
            // btn_DrawCircle
            // 
            this.btn_DrawCircle.Location = new System.Drawing.Point(33, 84);
            this.btn_DrawCircle.Name = "btn_DrawCircle";
            this.btn_DrawCircle.Size = new System.Drawing.Size(75, 23);
            this.btn_DrawCircle.TabIndex = 7;
            this.btn_DrawCircle.Text = "Okrąg";
            this.btn_DrawCircle.UseVisualStyleBackColor = true;
            this.btn_DrawCircle.Click += new System.EventHandler(this.btn_DrawCircle_Click);
            // 
            // txt_SelectShapeSize
            // 
            this.txt_SelectShapeSize.Location = new System.Drawing.Point(19, 130);
            this.txt_SelectShapeSize.Name = "txt_SelectShapeSize";
            this.txt_SelectShapeSize.Size = new System.Drawing.Size(100, 20);
            this.txt_SelectShapeSize.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rozmiar pędzla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kolor pędzla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kształt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rozmiar kształtu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_SelectPenColor);
            this.panel2.Controls.Add(this.cmb_SelectBrushSize);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 92);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_DrawSquare);
            this.panel3.Controls.Add(this.txt_SelectShapeSize);
            this.panel3.Controls.Add(this.btn_DrawCircle);
            this.panel3.Controls.Add(this.btn_DrawRectangle);
            this.panel3.Location = new System.Drawing.Point(9, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 155);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SelectPenColor;
        private System.Windows.Forms.ComboBox cmb_SelectBrushSize;
        private System.Windows.Forms.Button btn_DrawSquare;
        private System.Windows.Forms.Button btn_DrawRectangle;
        private System.Windows.Forms.Button btn_DrawCircle;
        private System.Windows.Forms.TextBox txt_SelectShapeSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

