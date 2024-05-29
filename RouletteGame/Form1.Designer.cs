using System;
using System.Collections.Generic;

namespace RouletteGame
{
    partial class Form1
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
            this.spinBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.redBet = new System.Windows.Forms.TextBox();
            this.blackBet = new System.Windows.Forms.TextBox();
            this.firstDozenBet = new System.Windows.Forms.TextBox();
            this.secondDozenBet = new System.Windows.Forms.TextBox();
            this.thirdDozenBet = new System.Windows.Forms.TextBox();
            this.firstHalfBet = new System.Windows.Forms.TextBox();
            this.secondHalfBet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oddBet = new System.Windows.Forms.TextBox();
            this.evenBet = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.columnBet = new System.Windows.Forms.TextBox();
            this.columnChoice = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.straightBet = new System.Windows.Forms.TextBox();
            this.straightChoice = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.splitBet = new System.Windows.Forms.TextBox();
            this.splitChoice = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.streetBet = new System.Windows.Forms.TextBox();
            this.streetChoice = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cornerBet = new System.Windows.Forms.TextBox();
            this.cornerChoice = new System.Windows.Forms.ComboBox();
            this.sixLineBet = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.sixLineChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinBtn
            // 
            this.spinBtn.Location = new System.Drawing.Point(178, 298);
            this.spinBtn.Name = "spinBtn";
            this.spinBtn.Size = new System.Drawing.Size(110, 47);
            this.spinBtn.TabIndex = 0;
            this.spinBtn.Text = "Spin";
            this.spinBtn.UseVisualStyleBackColor = true;
            this.spinBtn.Click += new System.EventHandler(this.spinBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.43842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.56158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.redBet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.blackBet, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.firstDozenBet, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.secondDozenBet, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.thirdDozenBet, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.firstHalfBet, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.secondHalfBet, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.oddBet, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.evenBet, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.columnBet, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.columnChoice, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.straightBet, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.straightChoice, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.splitBet, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.splitChoice, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.streetBet, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.streetChoice, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cornerBet, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.cornerChoice, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.sixLineBet, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.sixLineChoice, 2, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 208);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 1);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 1);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 1);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Black";
            // 
            // redBet
            // 
            this.redBet.Location = new System.Drawing.Point(57, 11);
            this.redBet.Name = "redBet";
            this.redBet.Size = new System.Drawing.Size(82, 20);
            this.redBet.TabIndex = 18;
            // 
            // blackBet
            // 
            this.blackBet.Location = new System.Drawing.Point(57, 31);
            this.blackBet.Name = "blackBet";
            this.blackBet.Size = new System.Drawing.Size(82, 20);
            this.blackBet.TabIndex = 19;
            // 
            // firstDozenBet
            // 
            this.firstDozenBet.Location = new System.Drawing.Point(353, 11);
            this.firstDozenBet.Name = "firstDozenBet";
            this.firstDozenBet.Size = new System.Drawing.Size(82, 20);
            this.firstDozenBet.TabIndex = 22;
            // 
            // secondDozenBet
            // 
            this.secondDozenBet.Location = new System.Drawing.Point(353, 31);
            this.secondDozenBet.Name = "secondDozenBet";
            this.secondDozenBet.Size = new System.Drawing.Size(82, 20);
            this.secondDozenBet.TabIndex = 23;
            // 
            // thirdDozenBet
            // 
            this.thirdDozenBet.Location = new System.Drawing.Point(353, 51);
            this.thirdDozenBet.Name = "thirdDozenBet";
            this.thirdDozenBet.Size = new System.Drawing.Size(82, 20);
            this.thirdDozenBet.TabIndex = 24;
            // 
            // firstHalfBet
            // 
            this.firstHalfBet.Location = new System.Drawing.Point(353, 91);
            this.firstHalfBet.Name = "firstHalfBet";
            this.firstHalfBet.Size = new System.Drawing.Size(82, 20);
            this.firstHalfBet.TabIndex = 25;
            // 
            // secondHalfBet
            // 
            this.secondHalfBet.Location = new System.Drawing.Point(353, 111);
            this.secondHalfBet.Name = "secondHalfBet";
            this.secondHalfBet.Size = new System.Drawing.Size(82, 20);
            this.secondHalfBet.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "19-36";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "1-18";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "25-36";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "13-24";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "1-12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Odd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Even";
            // 
            // oddBet
            // 
            this.oddBet.Location = new System.Drawing.Point(353, 151);
            this.oddBet.Name = "oddBet";
            this.oddBet.Size = new System.Drawing.Size(82, 20);
            this.oddBet.TabIndex = 20;
            // 
            // evenBet
            // 
            this.evenBet.Location = new System.Drawing.Point(353, 171);
            this.evenBet.Name = "evenBet";
            this.evenBet.Size = new System.Drawing.Size(82, 20);
            this.evenBet.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Column";
            this.label19.Visible = false;
            // 
            // columnBet
            // 
            this.columnBet.Location = new System.Drawing.Point(57, 71);
            this.columnBet.Name = "columnBet";
            this.columnBet.Size = new System.Drawing.Size(82, 20);
            this.columnBet.TabIndex = 32;
            this.columnBet.Visible = false;
            // 
            // columnChoice
            // 
            this.columnChoice.FormattingEnabled = true;
            this.columnChoice.Location = new System.Drawing.Point(148, 71);
            this.columnChoice.Name = "columnChoice";
            this.columnChoice.Size = new System.Drawing.Size(106, 21);
            this.columnChoice.TabIndex = 38;
            this.columnChoice.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Straight";
            // 
            // straightBet
            // 
            this.straightBet.Location = new System.Drawing.Point(57, 91);
            this.straightBet.Name = "straightBet";
            this.straightBet.Size = new System.Drawing.Size(82, 20);
            this.straightBet.TabIndex = 27;
            // 
            // straightChoice
            // 
            this.straightChoice.FormattingEnabled = true;
            this.straightChoice.Location = new System.Drawing.Point(148, 91);
            this.straightChoice.Name = "straightChoice";
            this.straightChoice.Size = new System.Drawing.Size(106, 21);
            this.straightChoice.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Split";
            this.label15.Visible = false;
            // 
            // splitBet
            // 
            this.splitBet.Location = new System.Drawing.Point(57, 111);
            this.splitBet.Name = "splitBet";
            this.splitBet.Size = new System.Drawing.Size(82, 20);
            this.splitBet.TabIndex = 28;
            this.splitBet.Visible = false;
            // 
            // splitChoice
            // 
            this.splitChoice.FormattingEnabled = true;
            this.splitChoice.Location = new System.Drawing.Point(148, 111);
            this.splitChoice.Name = "splitChoice";
            this.splitChoice.Size = new System.Drawing.Size(106, 21);
            this.splitChoice.TabIndex = 34;
            this.splitChoice.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Street";
            this.label16.Visible = false;
            // 
            // streetBet
            // 
            this.streetBet.Location = new System.Drawing.Point(57, 131);
            this.streetBet.Name = "streetBet";
            this.streetBet.Size = new System.Drawing.Size(82, 20);
            this.streetBet.TabIndex = 30;
            this.streetBet.Visible = false;
            // 
            // streetChoice
            // 
            this.streetChoice.FormattingEnabled = true;
            this.streetChoice.Location = new System.Drawing.Point(148, 131);
            this.streetChoice.Name = "streetChoice";
            this.streetChoice.Size = new System.Drawing.Size(106, 21);
            this.streetChoice.TabIndex = 35;
            this.streetChoice.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Corner";
            this.label17.Visible = false;
            // 
            // cornerBet
            // 
            this.cornerBet.Location = new System.Drawing.Point(57, 151);
            this.cornerBet.Name = "cornerBet";
            this.cornerBet.Size = new System.Drawing.Size(82, 20);
            this.cornerBet.TabIndex = 29;
            this.cornerBet.Visible = false;
            // 
            // cornerChoice
            // 
            this.cornerChoice.FormattingEnabled = true;
            this.cornerChoice.Location = new System.Drawing.Point(148, 151);
            this.cornerChoice.Name = "cornerChoice";
            this.cornerChoice.Size = new System.Drawing.Size(106, 21);
            this.cornerChoice.TabIndex = 36;
            this.cornerChoice.Visible = false;
            // 
            // sixLineBet
            // 
            this.sixLineBet.AutoSize = true;
            this.sixLineBet.Location = new System.Drawing.Point(3, 168);
            this.sixLineBet.Name = "sixLineBet";
            this.sixLineBet.Size = new System.Drawing.Size(40, 13);
            this.sixLineBet.TabIndex = 16;
            this.sixLineBet.Text = "Six line";
            this.sixLineBet.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(57, 171);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(82, 20);
            this.textBox14.TabIndex = 31;
            this.textBox14.Visible = false;
            // 
            // sixLineChoice
            // 
            this.sixLineChoice.FormattingEnabled = true;
            this.sixLineChoice.Location = new System.Drawing.Point(148, 171);
            this.sixLineChoice.Name = "sixLineChoice";
            this.sixLineChoice.Size = new System.Drawing.Size(106, 21);
            this.sixLineChoice.TabIndex = 37;
            this.sixLineChoice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Place your bets:";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(9, 33);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(67, 13);
            this.cash.TabIndex = 5;
            this.cash.Text = "Cash: $1000";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(9, 15);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(36, 13);
            this.playerName.TabIndex = 6;
            this.playerName.Text = "Player";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 354);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(445, 85);
            this.infoTextBox.TabIndex = 7;
            this.infoTextBox.Text = "";
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(344, 13);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(110, 47);
            this.newGameBtn.TabIndex = 8;
            this.newGameBtn.Text = "New game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 451);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.spinBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spinBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label sixLineBet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox redBet;
        private System.Windows.Forms.TextBox blackBet;
        private System.Windows.Forms.TextBox oddBet;
        private System.Windows.Forms.TextBox evenBet;
        private System.Windows.Forms.TextBox straightBet;
        private System.Windows.Forms.TextBox splitBet;
        private System.Windows.Forms.TextBox cornerBet;
        private System.Windows.Forms.TextBox streetBet;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox columnBet;
        private System.Windows.Forms.TextBox firstDozenBet;
        private System.Windows.Forms.TextBox secondDozenBet;
        private System.Windows.Forms.TextBox thirdDozenBet;
        private System.Windows.Forms.TextBox firstHalfBet;
        private System.Windows.Forms.TextBox secondHalfBet;
        private System.Windows.Forms.ComboBox straightChoice;
        private System.Windows.Forms.ComboBox splitChoice;
        private System.Windows.Forms.ComboBox streetChoice;
        private System.Windows.Forms.ComboBox cornerChoice;
        private System.Windows.Forms.ComboBox sixLineChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.ComboBox columnChoice;
    }
}

