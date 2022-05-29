
namespace BestOil
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lable_full_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_in_AZN = new System.Windows.Forms.TextBox();
            this.textBox_oil_price = new System.Windows.Forms.TextBox();
            this.textBox_in_L = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton_in_money = new System.Windows.Forms.RadioButton();
            this.radioButton_in_L = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Oil_full_price = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_burgercount = new System.Windows.Forms.TextBox();
            this.textBox_burgerprice = new System.Windows.Forms.TextBox();
            this.textBox_fricecount = new System.Windows.Forms.TextBox();
            this.textBox_friceprice = new System.Windows.Forms.TextBox();
            this.textBox_colacount = new System.Windows.Forms.TextBox();
            this.textBox_colaprice = new System.Windows.Forms.TextBox();
            this.textBox_dogcount = new System.Windows.Forms.TextBox();
            this.textBox_dogprice = new System.Windows.Forms.TextBox();
            this.checkBox_cola = new System.Windows.Forms.CheckBox();
            this.checkBox_frice = new System.Windows.Forms.CheckBox();
            this.checkBox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_hotdog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Cofe_full_price = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lable_full_price);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Итоговая плата";
            // 
            // lable_full_price
            // 
            this.lable_full_price.AutoSize = true;
            this.lable_full_price.Location = new System.Drawing.Point(395, 43);
            this.lable_full_price.Name = "lable_full_price";
            this.lable_full_price.Size = new System.Drawing.Size(13, 15);
            this.lable_full_price.TabIndex = 1;
            this.lable_full_price.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_in_AZN);
            this.groupBox1.Controls.Add(this.textBox_oil_price);
            this.groupBox1.Controls.Add(this.textBox_in_L);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // textBox_in_AZN
            // 
            this.textBox_in_AZN.Location = new System.Drawing.Point(131, 135);
            this.textBox_in_AZN.Name = "textBox_in_AZN";
            this.textBox_in_AZN.Size = new System.Drawing.Size(83, 23);
            this.textBox_in_AZN.TabIndex = 8;
            this.textBox_in_AZN.Text = "0";
            this.textBox_in_AZN.TextChanged += new System.EventHandler(this.textBox_in_AZN_TextChanged);
            // 
            // textBox_oil_price
            // 
            this.textBox_oil_price.Location = new System.Drawing.Point(72, 64);
            this.textBox_oil_price.Name = "textBox_oil_price";
            this.textBox_oil_price.ReadOnly = true;
            this.textBox_oil_price.Size = new System.Drawing.Size(121, 23);
            this.textBox_oil_price.TabIndex = 7;
            // 
            // textBox_in_L
            // 
            this.textBox_in_L.Location = new System.Drawing.Point(131, 105);
            this.textBox_in_L.Name = "textBox_in_L";
            this.textBox_in_L.Size = new System.Drawing.Size(83, 23);
            this.textBox_in_L.TabIndex = 6;
            this.textBox_in_L.Text = "0";
            this.textBox_in_L.TextChanged += new System.EventHandler(this.textBox_in_L_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Бензин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цена";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "oil 1",
            "oil 2"});
            this.comboBox1.Location = new System.Drawing.Point(72, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton_in_money);
            this.groupBox6.Controls.Add(this.radioButton_in_L);
            this.groupBox6.Location = new System.Drawing.Point(7, 93);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(117, 75);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // radioButton_in_money
            // 
            this.radioButton_in_money.AutoSize = true;
            this.radioButton_in_money.Location = new System.Drawing.Point(6, 42);
            this.radioButton_in_money.Name = "radioButton_in_money";
            this.radioButton_in_money.Size = new System.Drawing.Size(71, 19);
            this.radioButton_in_money.TabIndex = 1;
            this.radioButton_in_money.TabStop = true;
            this.radioButton_in_money.Text = "В сумме";
            this.radioButton_in_money.UseVisualStyleBackColor = true;
            this.radioButton_in_money.CheckedChanged += new System.EventHandler(this.radioButton_in_money_CheckedChanged);
            // 
            // radioButton_in_L
            // 
            this.radioButton_in_L.AutoSize = true;
            this.radioButton_in_L.Location = new System.Drawing.Point(6, 17);
            this.radioButton_in_L.Name = "radioButton_in_L";
            this.radioButton_in_L.Size = new System.Drawing.Size(73, 19);
            this.radioButton_in_L.TabIndex = 0;
            this.radioButton_in_L.TabStop = true;
            this.radioButton_in_L.Text = "В литрах";
            this.radioButton_in_L.UseVisualStyleBackColor = true;
            this.radioButton_in_L.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Oil_full_price);
            this.groupBox4.Location = new System.Drawing.Point(6, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Цена:";
            // 
            // Oil_full_price
            // 
            this.Oil_full_price.AutoSize = true;
            this.Oil_full_price.Location = new System.Drawing.Point(124, 48);
            this.Oil_full_price.Name = "Oil_full_price";
            this.Oil_full_price.Size = new System.Drawing.Size(13, 15);
            this.Oil_full_price.TabIndex = 1;
            this.Oil_full_price.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_burgercount);
            this.groupBox2.Controls.Add(this.textBox_burgerprice);
            this.groupBox2.Controls.Add(this.textBox_fricecount);
            this.groupBox2.Controls.Add(this.textBox_friceprice);
            this.groupBox2.Controls.Add(this.textBox_colacount);
            this.groupBox2.Controls.Add(this.textBox_colaprice);
            this.groupBox2.Controls.Add(this.textBox_dogcount);
            this.groupBox2.Controls.Add(this.textBox_dogprice);
            this.groupBox2.Controls.Add(this.checkBox_cola);
            this.groupBox2.Controls.Add(this.checkBox_frice);
            this.groupBox2.Controls.Add(this.checkBox_hamburger);
            this.groupBox2.Controls.Add(this.checkBox_hotdog);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 280);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "МиниКофе";
            // 
            // textBox_burgercount
            // 
            this.textBox_burgercount.Enabled = false;
            this.textBox_burgercount.Location = new System.Drawing.Point(193, 60);
            this.textBox_burgercount.Name = "textBox_burgercount";
            this.textBox_burgercount.Size = new System.Drawing.Size(60, 23);
            this.textBox_burgercount.TabIndex = 21;
            this.textBox_burgercount.Text = "0";
            this.textBox_burgercount.TextChanged += new System.EventHandler(this.textBox_burgercount_TextChanged);
            // 
            // textBox_burgerprice
            // 
            this.textBox_burgerprice.Enabled = false;
            this.textBox_burgerprice.Location = new System.Drawing.Point(115, 60);
            this.textBox_burgerprice.Name = "textBox_burgerprice";
            this.textBox_burgerprice.ReadOnly = true;
            this.textBox_burgerprice.Size = new System.Drawing.Size(60, 23);
            this.textBox_burgerprice.TabIndex = 17;
            this.textBox_burgerprice.Text = "0";
            // 
            // textBox_fricecount
            // 
            this.textBox_fricecount.Enabled = false;
            this.textBox_fricecount.Location = new System.Drawing.Point(193, 93);
            this.textBox_fricecount.Name = "textBox_fricecount";
            this.textBox_fricecount.Size = new System.Drawing.Size(60, 23);
            this.textBox_fricecount.TabIndex = 20;
            this.textBox_fricecount.Text = "0";
            this.textBox_fricecount.TextChanged += new System.EventHandler(this.textBox_fricecount_TextChanged);
            // 
            // textBox_friceprice
            // 
            this.textBox_friceprice.Enabled = false;
            this.textBox_friceprice.Location = new System.Drawing.Point(115, 93);
            this.textBox_friceprice.Name = "textBox_friceprice";
            this.textBox_friceprice.ReadOnly = true;
            this.textBox_friceprice.Size = new System.Drawing.Size(60, 23);
            this.textBox_friceprice.TabIndex = 16;
            this.textBox_friceprice.Text = "0";
            // 
            // textBox_colacount
            // 
            this.textBox_colacount.Enabled = false;
            this.textBox_colacount.Location = new System.Drawing.Point(193, 126);
            this.textBox_colacount.Name = "textBox_colacount";
            this.textBox_colacount.Size = new System.Drawing.Size(60, 23);
            this.textBox_colacount.TabIndex = 19;
            this.textBox_colacount.Text = "0";
            this.textBox_colacount.TextChanged += new System.EventHandler(this.textBox_colacount_TextChanged);
            // 
            // textBox_colaprice
            // 
            this.textBox_colaprice.Enabled = false;
            this.textBox_colaprice.Location = new System.Drawing.Point(115, 126);
            this.textBox_colaprice.Name = "textBox_colaprice";
            this.textBox_colaprice.ReadOnly = true;
            this.textBox_colaprice.Size = new System.Drawing.Size(60, 23);
            this.textBox_colaprice.TabIndex = 15;
            this.textBox_colaprice.Text = "0";
            // 
            // textBox_dogcount
            // 
            this.textBox_dogcount.Enabled = false;
            this.textBox_dogcount.Location = new System.Drawing.Point(193, 22);
            this.textBox_dogcount.Name = "textBox_dogcount";
            this.textBox_dogcount.Size = new System.Drawing.Size(60, 23);
            this.textBox_dogcount.TabIndex = 18;
            this.textBox_dogcount.Text = "0";
            this.textBox_dogcount.TextChanged += new System.EventHandler(this.textBox_dogcount_TextChanged);
            // 
            // textBox_dogprice
            // 
            this.textBox_dogprice.Enabled = false;
            this.textBox_dogprice.Location = new System.Drawing.Point(115, 22);
            this.textBox_dogprice.Name = "textBox_dogprice";
            this.textBox_dogprice.ReadOnly = true;
            this.textBox_dogprice.Size = new System.Drawing.Size(60, 23);
            this.textBox_dogprice.TabIndex = 14;
            this.textBox_dogprice.Text = "0";
            // 
            // checkBox_cola
            // 
            this.checkBox_cola.AutoSize = true;
            this.checkBox_cola.Location = new System.Drawing.Point(7, 126);
            this.checkBox_cola.Name = "checkBox_cola";
            this.checkBox_cola.Size = new System.Drawing.Size(83, 19);
            this.checkBox_cola.TabIndex = 5;
            this.checkBox_cola.Text = "Кока-кола";
            this.checkBox_cola.UseVisualStyleBackColor = true;
            this.checkBox_cola.CheckedChanged += new System.EventHandler(this.checkBox_cola_CheckedChanged);
            // 
            // checkBox_frice
            // 
            this.checkBox_frice.AutoSize = true;
            this.checkBox_frice.Location = new System.Drawing.Point(7, 93);
            this.checkBox_frice.Name = "checkBox_frice";
            this.checkBox_frice.Size = new System.Drawing.Size(109, 19);
            this.checkBox_frice.TabIndex = 4;
            this.checkBox_frice.Text = "Картошка-фри";
            this.checkBox_frice.UseVisualStyleBackColor = true;
            this.checkBox_frice.CheckedChanged += new System.EventHandler(this.checkBox_frice_CheckedChanged);
            // 
            // checkBox_hamburger
            // 
            this.checkBox_hamburger.AutoSize = true;
            this.checkBox_hamburger.Location = new System.Drawing.Point(7, 60);
            this.checkBox_hamburger.Name = "checkBox_hamburger";
            this.checkBox_hamburger.Size = new System.Drawing.Size(85, 19);
            this.checkBox_hamburger.TabIndex = 3;
            this.checkBox_hamburger.Text = "Гамбургер";
            this.checkBox_hamburger.UseVisualStyleBackColor = true;
            this.checkBox_hamburger.CheckedChanged += new System.EventHandler(this.checkBox_hamburger_CheckedChanged);
            // 
            // checkBox_hotdog
            // 
            this.checkBox_hotdog.AutoSize = true;
            this.checkBox_hotdog.Location = new System.Drawing.Point(7, 22);
            this.checkBox_hotdog.Name = "checkBox_hotdog";
            this.checkBox_hotdog.Size = new System.Drawing.Size(68, 19);
            this.checkBox_hotdog.TabIndex = 2;
            this.checkBox_hotdog.Text = "Хот-дог";
            this.checkBox_hotdog.UseVisualStyleBackColor = true;
            this.checkBox_hotdog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Cofe_full_price);
            this.groupBox5.Location = new System.Drawing.Point(6, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Цена:";
            // 
            // Cofe_full_price
            // 
            this.Cofe_full_price.AutoSize = true;
            this.Cofe_full_price.Location = new System.Drawing.Point(114, 48);
            this.Cofe_full_price.Name = "Cofe_full_price";
            this.Cofe_full_price.Size = new System.Drawing.Size(13, 15);
            this.Cofe_full_price.TabIndex = 0;
            this.Cofe_full_price.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton_in_money;
        private System.Windows.Forms.RadioButton radioButton_in_L;
        private System.Windows.Forms.CheckBox checkBox_cola;
        private System.Windows.Forms.CheckBox checkBox_frice;
        private System.Windows.Forms.CheckBox checkBox_hamburger;
        private System.Windows.Forms.CheckBox checkBox_hotdog;
        private System.Windows.Forms.Label lable_full_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Oil_full_price;
        private System.Windows.Forms.Label Cofe_full_price;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_burgerprice;
        private System.Windows.Forms.TextBox textBox_friceprice;
        private System.Windows.Forms.TextBox textBox_colaprice;
        private System.Windows.Forms.TextBox textBox_dogprice;
        private System.Windows.Forms.TextBox textBox_burgercount;
        private System.Windows.Forms.TextBox textBox_fricecount;
        private System.Windows.Forms.TextBox textBox_colacount;
        private System.Windows.Forms.TextBox textBox_dogcount;
        private System.Windows.Forms.TextBox textBox_in_L;
        private System.Windows.Forms.TextBox textBox_oil_price;
        private System.Windows.Forms.TextBox textBox_in_AZN;
    }
}

