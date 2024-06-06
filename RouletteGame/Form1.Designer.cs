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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spinBtn = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.rouletteResult = new System.Windows.Forms.RichTextBox();
            this.fishka10 = new System.Windows.Forms.PictureBox();
            this.btn1to18 = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btn19to36 = new System.Windows.Forms.Button();
            this.btn1st12 = new System.Windows.Forms.Button();
            this.btn2nd12 = new System.Windows.Forms.Button();
            this.btn3rd12 = new System.Windows.Forms.Button();
            this.btn3rdRow = new System.Windows.Forms.Button();
            this.btn2ndRow = new System.Windows.Forms.Button();
            this.btn1stRow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fishka50 = new System.Windows.Forms.PictureBox();
            this.fishka100 = new System.Windows.Forms.PictureBox();
            this.fishka500 = new System.Windows.Forms.PictureBox();
            this.fishka1000 = new System.Windows.Forms.PictureBox();
            this.allBetsDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fishka10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka1000)).BeginInit();
            this.SuspendLayout();
            // 
            // spinBtn
            // 
            this.spinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinBtn.Location = new System.Drawing.Point(281, 300);
            this.spinBtn.Name = "spinBtn";
            this.spinBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spinBtn.Size = new System.Drawing.Size(110, 47);
            this.spinBtn.TabIndex = 0;
            this.spinBtn.Text = "Крутить";
            this.spinBtn.UseVisualStyleBackColor = true;
            this.spinBtn.Click += new System.EventHandler(this.spinBtn_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cash.Location = new System.Drawing.Point(12, 24);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(134, 20);
            this.cash.TabIndex = 5;
            this.cash.Text = "Ваш счет: $1000";
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameBtn.Location = new System.Drawing.Point(519, 11);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(110, 47);
            this.newGameBtn.TabIndex = 8;
            this.newGameBtn.Text = "Новая игра";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // rouletteResult
            // 
            this.rouletteResult.Location = new System.Drawing.Point(12, 69);
            this.rouletteResult.Name = "rouletteResult";
            this.rouletteResult.ReadOnly = true;
            this.rouletteResult.Size = new System.Drawing.Size(44, 225);
            this.rouletteResult.TabIndex = 11;
            this.rouletteResult.Text = "";
            // 
            // fishka10
            // 
            this.fishka10.BackColor = System.Drawing.Color.Transparent;
            this.fishka10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fishka10.BackgroundImage")));
            this.fishka10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fishka10.Location = new System.Drawing.Point(32, 314);
            this.fishka10.Name = "fishka10";
            this.fishka10.Size = new System.Drawing.Size(33, 33);
            this.fishka10.TabIndex = 12;
            this.fishka10.TabStop = false;
            this.fishka10.Click += new System.EventHandler(this.fishka10_Click);
            // 
            // btn1to18
            // 
            this.btn1to18.Image = ((System.Drawing.Image)(resources.GetObject("btn1to18.Image")));
            this.btn1to18.Location = new System.Drawing.Point(115, 254);
            this.btn1to18.Name = "btn1to18";
            this.btn1to18.Size = new System.Drawing.Size(56, 40);
            this.btn1to18.TabIndex = 13;
            this.btn1to18.UseVisualStyleBackColor = true;
            this.btn1to18.Click += new System.EventHandler(this.btn1to18_Click);
            // 
            // btnEven
            // 
            this.btnEven.Image = ((System.Drawing.Image)(resources.GetObject("btnEven.Image")));
            this.btnEven.Location = new System.Drawing.Point(170, 254);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(56, 40);
            this.btnEven.TabIndex = 14;
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnRed
            // 
            this.btnRed.Image = ((System.Drawing.Image)(resources.GetObject("btnRed.Image")));
            this.btnRed.Location = new System.Drawing.Point(225, 254);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(56, 40);
            this.btnRed.TabIndex = 15;
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Image = ((System.Drawing.Image)(resources.GetObject("btnBlack.Image")));
            this.btnBlack.Location = new System.Drawing.Point(280, 254);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(56, 40);
            this.btnBlack.TabIndex = 16;
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Image = ((System.Drawing.Image)(resources.GetObject("btnOdd.Image")));
            this.btnOdd.Location = new System.Drawing.Point(335, 254);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(56, 40);
            this.btnOdd.TabIndex = 17;
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btn19to36
            // 
            this.btn19to36.Image = ((System.Drawing.Image)(resources.GetObject("btn19to36.Image")));
            this.btn19to36.Location = new System.Drawing.Point(390, 254);
            this.btn19to36.Name = "btn19to36";
            this.btn19to36.Size = new System.Drawing.Size(56, 40);
            this.btn19to36.TabIndex = 18;
            this.btn19to36.UseVisualStyleBackColor = true;
            this.btn19to36.Click += new System.EventHandler(this.btn19to36_Click);
            // 
            // btn1st12
            // 
            this.btn1st12.Image = ((System.Drawing.Image)(resources.GetObject("btn1st12.Image")));
            this.btn1st12.Location = new System.Drawing.Point(115, 215);
            this.btn1st12.Name = "btn1st12";
            this.btn1st12.Size = new System.Drawing.Size(109, 40);
            this.btn1st12.TabIndex = 19;
            this.btn1st12.UseVisualStyleBackColor = true;
            this.btn1st12.Click += new System.EventHandler(this.btn1st12_Click);
            // 
            // btn2nd12
            // 
            this.btn2nd12.Image = ((System.Drawing.Image)(resources.GetObject("btn2nd12.Image")));
            this.btn2nd12.Location = new System.Drawing.Point(226, 215);
            this.btn2nd12.Name = "btn2nd12";
            this.btn2nd12.Size = new System.Drawing.Size(109, 40);
            this.btn2nd12.TabIndex = 20;
            this.btn2nd12.UseVisualStyleBackColor = true;
            this.btn2nd12.Click += new System.EventHandler(this.btn2nd12_Click);
            // 
            // btn3rd12
            // 
            this.btn3rd12.Image = ((System.Drawing.Image)(resources.GetObject("btn3rd12.Image")));
            this.btn3rd12.Location = new System.Drawing.Point(337, 215);
            this.btn3rd12.Name = "btn3rd12";
            this.btn3rd12.Size = new System.Drawing.Size(109, 40);
            this.btn3rd12.TabIndex = 21;
            this.btn3rd12.UseVisualStyleBackColor = true;
            this.btn3rd12.Click += new System.EventHandler(this.btn3rd12_Click);
            // 
            // btn3rdRow
            // 
            this.btn3rdRow.Image = ((System.Drawing.Image)(resources.GetObject("btn3rdRow.Image")));
            this.btn3rdRow.Location = new System.Drawing.Point(115, 165);
            this.btn3rdRow.Name = "btn3rdRow";
            this.btn3rdRow.Size = new System.Drawing.Size(363, 49);
            this.btn3rdRow.TabIndex = 22;
            this.btn3rdRow.UseVisualStyleBackColor = true;
            this.btn3rdRow.Click += new System.EventHandler(this.btn3rdRow_Click);
            // 
            // btn2ndRow
            // 
            this.btn2ndRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2ndRow.Image = ((System.Drawing.Image)(resources.GetObject("btn2ndRow.Image")));
            this.btn2ndRow.Location = new System.Drawing.Point(115, 117);
            this.btn2ndRow.Name = "btn2ndRow";
            this.btn2ndRow.Size = new System.Drawing.Size(363, 49);
            this.btn2ndRow.TabIndex = 23;
            this.btn2ndRow.UseVisualStyleBackColor = true;
            this.btn2ndRow.Click += new System.EventHandler(this.btn2ndRow_Click);
            // 
            // btn1stRow
            // 
            this.btn1stRow.BackColor = System.Drawing.Color.Transparent;
            this.btn1stRow.Image = ((System.Drawing.Image)(resources.GetObject("btn1stRow.Image")));
            this.btn1stRow.Location = new System.Drawing.Point(115, 69);
            this.btn1stRow.Name = "btn1stRow";
            this.btn1stRow.Size = new System.Drawing.Size(363, 49);
            this.btn1stRow.TabIndex = 24;
            this.btn1stRow.UseVisualStyleBackColor = false;
            this.btn1stRow.Click += new System.EventHandler(this.btn1stRow_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(79, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 72);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 300);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Очистить ставки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fishka50
            // 
            this.fishka50.BackColor = System.Drawing.Color.Transparent;
            this.fishka50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fishka50.BackgroundImage")));
            this.fishka50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fishka50.Location = new System.Drawing.Point(71, 314);
            this.fishka50.Name = "fishka50";
            this.fishka50.Size = new System.Drawing.Size(33, 33);
            this.fishka50.TabIndex = 27;
            this.fishka50.TabStop = false;
            this.fishka50.Click += new System.EventHandler(this.fishka50_Click);
            // 
            // fishka100
            // 
            this.fishka100.BackColor = System.Drawing.Color.Transparent;
            this.fishka100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fishka100.BackgroundImage")));
            this.fishka100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fishka100.Location = new System.Drawing.Point(110, 314);
            this.fishka100.Name = "fishka100";
            this.fishka100.Size = new System.Drawing.Size(33, 33);
            this.fishka100.TabIndex = 28;
            this.fishka100.TabStop = false;
            this.fishka100.Click += new System.EventHandler(this.fishka100_Click);
            // 
            // fishka500
            // 
            this.fishka500.BackColor = System.Drawing.Color.Transparent;
            this.fishka500.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fishka500.BackgroundImage")));
            this.fishka500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fishka500.Location = new System.Drawing.Point(150, 314);
            this.fishka500.Name = "fishka500";
            this.fishka500.Size = new System.Drawing.Size(33, 33);
            this.fishka500.TabIndex = 29;
            this.fishka500.TabStop = false;
            this.fishka500.Click += new System.EventHandler(this.fishka500_Click);
            // 
            // fishka1000
            // 
            this.fishka1000.BackColor = System.Drawing.Color.Transparent;
            this.fishka1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fishka1000.BackgroundImage")));
            this.fishka1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fishka1000.Location = new System.Drawing.Point(191, 314);
            this.fishka1000.Name = "fishka1000";
            this.fishka1000.Size = new System.Drawing.Size(33, 33);
            this.fishka1000.TabIndex = 30;
            this.fishka1000.TabStop = false;
            this.fishka1000.Click += new System.EventHandler(this.fishka1000_Click);
            // 
            // allBetsDisplay
            // 
            this.allBetsDisplay.Location = new System.Drawing.Point(496, 69);
            this.allBetsDisplay.Name = "allBetsDisplay";
            this.allBetsDisplay.ReadOnly = true;
            this.allBetsDisplay.Size = new System.Drawing.Size(146, 225);
            this.allBetsDisplay.TabIndex = 31;
            this.allBetsDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(653, 369);
            this.Controls.Add(this.allBetsDisplay);
            this.Controls.Add(this.fishka1000);
            this.Controls.Add(this.fishka500);
            this.Controls.Add(this.fishka100);
            this.Controls.Add(this.fishka50);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1stRow);
            this.Controls.Add(this.btn2ndRow);
            this.Controls.Add(this.btn3rdRow);
            this.Controls.Add(this.btn3rd12);
            this.Controls.Add(this.btn2nd12);
            this.Controls.Add(this.btn1st12);
            this.Controls.Add(this.btn19to36);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btn1to18);
            this.Controls.Add(this.fishka10);
            this.Controls.Add(this.rouletteResult);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.spinBtn);
            this.Name = "Form1";
            this.Text = "Рулетка";
            ((System.ComponentModel.ISupportInitialize)(this.fishka10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishka1000)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spinBtn;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.RichTextBox rouletteResult;
        private System.Windows.Forms.PictureBox fishka10;
        private System.Windows.Forms.Button btn1to18;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btn19to36;
        private System.Windows.Forms.Button btn1st12;
        private System.Windows.Forms.Button btn2nd12;
        private System.Windows.Forms.Button btn3rd12;
        private System.Windows.Forms.Button btn3rdRow;
        private System.Windows.Forms.Button btn2ndRow;
        private System.Windows.Forms.Button btn1stRow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox fishka50;
        private System.Windows.Forms.PictureBox fishka100;
        private System.Windows.Forms.PictureBox fishka500;
        private System.Windows.Forms.PictureBox fishka1000;
        private System.Windows.Forms.RichTextBox allBetsDisplay;
    }
}

