using System.Drawing;

namespace KursovaWinForms_V._0._1
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.StartButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModesButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadYouFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeYouTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instruktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.ExersizeTextLabe = new System.Windows.Forms.Label();
            this.WritenTextLabe = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Location = new System.Drawing.Point(-1, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(114, 549);
            this.MenuPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 441);
            this.label2.TabIndex = 1;
            this.label2.Text = "S\ni\nM\nu\nL\na\nT\no\nR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 392);
            this.label1.TabIndex = 0;
            this.label1.Text = "K\ne\nY\nb\nO\na\nR\nd";
            // 
            // CloseButon
            // 
            this.CloseButon.BackColor = System.Drawing.Color.Gray;
            this.CloseButon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButon.Location = new System.Drawing.Point(856, 0);
            this.CloseButon.Name = "CloseButon";
            this.CloseButon.Size = new System.Drawing.Size(51, 26);
            this.CloseButon.TabIndex = 1;
            this.CloseButon.Text = "X";
            this.CloseButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButon.Click += new System.EventHandler(this.CloseButon_Click);
            this.CloseButon.MouseLeave += new System.EventHandler(this.CloseButon_MouseLeave);
            this.CloseButon.MouseHover += new System.EventHandler(this.CloseButon_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.MenuStrip);
            this.panel1.Controls.Add(this.CloseButon);
            this.panel1.Location = new System.Drawing.Point(112, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 31);
            this.panel1.TabIndex = 3;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Gray;
            this.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartButtonMenu,
            this.MenuButtonMenu,
            this.ModesButtonMenu,
            this.HelpButtonMenu});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.MdiWindowListItem = this.MenuButtonMenu;
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(339, 31);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // StartButtonMenu
            // 
            this.StartButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButtonMenu.CheckOnClick = true;
            this.StartButtonMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButtonMenu.Name = "StartButtonMenu";
            this.StartButtonMenu.Size = new System.Drawing.Size(62, 27);
            this.StartButtonMenu.Text = "START";
            this.StartButtonMenu.Click += new System.EventHandler(this.StartButtonMenu_Click);
            // 
            // MenuButtonMenu
            // 
            this.MenuButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticMenuItem,
            this.ExitMenuItem});
            this.MenuButtonMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuButtonMenu.Name = "MenuButtonMenu";
            this.MenuButtonMenu.Size = new System.Drawing.Size(50, 27);
            this.MenuButtonMenu.Text = "Menu";
            // 
            // StatisticMenuItem
            // 
            this.StatisticMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.StatisticMenuItem.Name = "StatisticMenuItem";
            this.StatisticMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StatisticMenuItem.Text = "Statistic";
            this.StatisticMenuItem.Click += new System.EventHandler(this.StatisticMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ModesButtonMenu
            // 
            this.ModesButtonMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ModesButtonMenu.BackColor = System.Drawing.Color.Gray;
            this.ModesButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentenceToolStripMenuItem,
            this.letersToolStripMenuItem,
            this.additionallyToolStripMenuItem});
            this.ModesButtonMenu.Name = "ModesButtonMenu";
            this.ModesButtonMenu.Size = new System.Drawing.Size(55, 27);
            this.ModesButtonMenu.Text = "Modes";
            // 
            // sentenceToolStripMenuItem
            // 
            this.sentenceToolStripMenuItem.CheckOnClick = true;
            this.sentenceToolStripMenuItem.Name = "sentenceToolStripMenuItem";
            this.sentenceToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sentenceToolStripMenuItem.Text = "Sentence";
            this.sentenceToolStripMenuItem.Click += new System.EventHandler(this.sentenceToolStripMenuItem_Click);
            // 
            // letersToolStripMenuItem
            // 
            this.letersToolStripMenuItem.CheckOnClick = true;
            this.letersToolStripMenuItem.Name = "letersToolStripMenuItem";
            this.letersToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.letersToolStripMenuItem.Text = "Leters";
            this.letersToolStripMenuItem.Click += new System.EventHandler(this.letersToolStripMenuItem_Click);
            // 
            // additionallyToolStripMenuItem
            // 
            this.additionallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadYouFileToolStripMenuItem,
            this.writeYouTextToolStripMenuItem});
            this.additionallyToolStripMenuItem.Name = "additionallyToolStripMenuItem";
            this.additionallyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.additionallyToolStripMenuItem.Text = "Additionally";
            // 
            // loadYouFileToolStripMenuItem
            // 
            this.loadYouFileToolStripMenuItem.Name = "loadYouFileToolStripMenuItem";
            this.loadYouFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadYouFileToolStripMenuItem.Text = "Load you file";
            this.loadYouFileToolStripMenuItem.Click += new System.EventHandler(this.loadYouFileToolStripMenuItem_Click);
            // 
            // writeYouTextToolStripMenuItem
            // 
            this.writeYouTextToolStripMenuItem.Name = "writeYouTextToolStripMenuItem";
            this.writeYouTextToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.writeYouTextToolStripMenuItem.Text = "Write you text";
            this.writeYouTextToolStripMenuItem.Click += new System.EventHandler(this.writeYouTextToolStripMenuItem_Click);
            // 
            // HelpButtonMenu
            // 
            this.HelpButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruktionToolStripMenuItem});
            this.HelpButtonMenu.Name = "HelpButtonMenu";
            this.HelpButtonMenu.Size = new System.Drawing.Size(44, 27);
            this.HelpButtonMenu.Text = "Help";
            // 
            // instruktionToolStripMenuItem
            // 
            this.instruktionToolStripMenuItem.Name = "instruktionToolStripMenuItem";
            this.instruktionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.instruktionToolStripMenuItem.Text = "Instruktion";
            this.instruktionToolStripMenuItem.Click += new System.EventHandler(this.instruktionToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(112, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 32);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(864, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author:     Malafei Max                                                          " +
    "                                      Release date:     06.03.2021              " +
    "        Version:      0.2";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(831, 392);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(0, 20);
            this.Count.TabIndex = 5;
            // 
            // ExersizeTextLabe
            // 
            this.ExersizeTextLabe.BackColor = System.Drawing.SystemColors.Control;
            this.ExersizeTextLabe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExersizeTextLabe.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExersizeTextLabe.Location = new System.Drawing.Point(482, 236);
            this.ExersizeTextLabe.Name = "ExersizeTextLabe";
            this.ExersizeTextLabe.Size = new System.Drawing.Size(482, 39);
            this.ExersizeTextLabe.TabIndex = 9;
            this.ExersizeTextLabe.Text = "Press ESCAPE to stop";
            // 
            // WritenTextLabe
            // 
            this.WritenTextLabe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WritenTextLabe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WritenTextLabe.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WritenTextLabe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WritenTextLabe.Location = new System.Drawing.Point(163, 236);
            this.WritenTextLabe.Name = "WritenTextLabe";
            this.WritenTextLabe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WritenTextLabe.Size = new System.Drawing.Size(321, 39);
            this.WritenTextLabe.TabIndex = 10;
            this.WritenTextLabe.Text = " Press ENTER to start";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 548);
            this.ControlBox = false;
            this.Controls.Add(this.WritenTextLabe);
            this.Controls.Add(this.ExersizeTextLabe);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartForm_KeyPress);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CloseButon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem StatisticMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModesButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem sentenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letersToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.ToolStripMenuItem StartButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem additionallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadYouFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem instruktionToolStripMenuItem;
        private System.Windows.Forms.Label ExersizeTextLabe;
        private System.Windows.Forms.Label WritenTextLabe;
        private System.Windows.Forms.ToolStripMenuItem writeYouTextToolStripMenuItem;
    }
}

