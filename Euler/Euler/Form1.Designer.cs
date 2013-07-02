﻿namespace Euler
{
    partial class FormMy
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задатьПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.WordSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьПараметрыToolStripMenuItem,
            this.сохранитьРезультатыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задатьПараметрыToolStripMenuItem
            // 
            this.задатьПараметрыToolStripMenuItem.Name = "задатьПараметрыToolStripMenuItem";
            this.задатьПараметрыToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.задатьПараметрыToolStripMenuItem.Text = "Задать параметры";
            // 
            // сохранитьРезультатыToolStripMenuItem
            // 
            this.сохранитьРезультатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextSaveToolStripMenuItem,
            this.WordSaveToolStripMenuItem});
            this.сохранитьРезультатыToolStripMenuItem.Name = "сохранитьРезультатыToolStripMenuItem";
            this.сохранитьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.сохранитьРезультатыToolStripMenuItem.Text = "Сохранить результаты";
            // 
            // TextSaveToolStripMenuItem
            // 
            this.TextSaveToolStripMenuItem.Name = "TextSaveToolStripMenuItem";
            this.TextSaveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.TextSaveToolStripMenuItem.Text = "Текстовый файл";
            this.TextSaveToolStripMenuItem.Click += new System.EventHandler(this.TextSaveToolStripMenuItem_Click);
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(53, 19);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(31, 20);
            this.textBox_a.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_a, "Введите нижний предел диапазона области определений функции");
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(92, 19);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(36, 20);
            this.textBox_b.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox_b, "Введите верхний предел диапазона значений");
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(40, 45);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(34, 20);
            this.textBox_x0.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox_x0, "Введите значение x0");
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(140, 45);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(34, 20);
            this.textBox_y0.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox_y0, "Введите значение y0");
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(308, 19);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 20);
            this.textBox_h.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox_h, "Шаг приращения аргумента");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox1, "Точность значений");
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(677, 9);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(156, 67);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Решить";
            this.toolTip1.SetToolTip(this.button_solve, "Нажмите, чтобы вывести график");
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_solve);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_h);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_y0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_x0);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Точность  = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шаг (h) = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "y_0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "x_0=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "b]=";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(6, 22);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(22, 13);
            this.label_a.TabIndex = 6;
            this.label_a.Text = "[a ;";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zedGraph);
            this.groupBox2.Location = new System.Drawing.Point(2, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(5, 19);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(828, 390);
            this.zedGraph.TabIndex = 41;
            // 
            // WordSaveToolStripMenuItem
            // 
            this.WordSaveToolStripMenuItem.Name = "WordSaveToolStripMenuItem";
            this.WordSaveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.WordSaveToolStripMenuItem.Text = "Файл Word";
            this.WordSaveToolStripMenuItem.Click += new System.EventHandler(this.WordSaveToolStripMenuItem_Click);
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(845, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(861, 586);
            this.MinimumSize = new System.Drawing.Size(861, 586);
            this.Name = "FormMy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение ДУ методом Эйлера";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.ToolStripMenuItem задатьПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordSaveToolStripMenuItem;
    }
}

