namespace Calulator
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
            this.memo_text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exp_button = new System.Windows.Forms.Button();
            this.expo3_button = new System.Windows.Forms.Button();
            this.expo10_x_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.expo_y_button = new System.Windows.Forms.Button();
            this.mod_button = new System.Windows.Forms.Button();
            this.dot_button = new System.Windows.Forms.Button();
            this.m_minus_buttom = new System.Windows.Forms.Button();
            this.m_plus_buttom = new System.Windows.Forms.Button();
            this.mc_button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.listBoxCurrency = new System.Windows.Forms.ListBox();
            this.buttonConv = new System.Windows.Forms.Button();
            this.maintextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memo_text
            // 
            this.memo_text.Location = new System.Drawing.Point(537, 344);
            this.memo_text.Name = "memo_text";
            this.memo_text.Size = new System.Drawing.Size(118, 71);
            this.memo_text.TabIndex = 70;
            this.memo_text.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 69;
            this.label2.Text = "Memory";
            // 
            // exp_button
            // 
            this.exp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_button.Location = new System.Drawing.Point(405, 77);
            this.exp_button.Name = "exp_button";
            this.exp_button.Size = new System.Drawing.Size(102, 69);
            this.exp_button.TabIndex = 66;
            this.exp_button.Text = "Exp";
            this.exp_button.UseVisualStyleBackColor = true;
            this.exp_button.Click += new System.EventHandler(this.onetimeoperation);
            // 
            // expo3_button
            // 
            this.expo3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expo3_button.Location = new System.Drawing.Point(410, 218);
            this.expo3_button.Name = "expo3_button";
            this.expo3_button.Size = new System.Drawing.Size(97, 69);
            this.expo3_button.TabIndex = 65;
            this.expo3_button.Text = "^3";
            this.expo3_button.UseVisualStyleBackColor = true;
            this.expo3_button.Click += new System.EventHandler(this.onetimeoperation);
            // 
            // expo10_x_button
            // 
            this.expo10_x_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expo10_x_button.Location = new System.Drawing.Point(410, 356);
            this.expo10_x_button.Name = "expo10_x_button";
            this.expo10_x_button.Size = new System.Drawing.Size(97, 69);
            this.expo10_x_button.TabIndex = 64;
            this.expo10_x_button.Text = "10^x";
            this.expo10_x_button.UseVisualStyleBackColor = true;
            this.expo10_x_button.Click += new System.EventHandler(this.onetimeoperation);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(410, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 69);
            this.button4.TabIndex = 63;
            this.button4.Text = "^2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onetimeoperation);
            // 
            // expo_y_button
            // 
            this.expo_y_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expo_y_button.Location = new System.Drawing.Point(410, 149);
            this.expo_y_button.Name = "expo_y_button";
            this.expo_y_button.Size = new System.Drawing.Size(97, 69);
            this.expo_y_button.TabIndex = 62;
            this.expo_y_button.Text = "^";
            this.expo_y_button.UseVisualStyleBackColor = true;
            this.expo_y_button.Click += new System.EventHandler(this.operationclick);
            // 
            // mod_button
            // 
            this.mod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_button.Location = new System.Drawing.Point(509, 77);
            this.mod_button.Name = "mod_button";
            this.mod_button.Size = new System.Drawing.Size(102, 69);
            this.mod_button.TabIndex = 61;
            this.mod_button.Text = "Mod";
            this.mod_button.UseVisualStyleBackColor = true;
            this.mod_button.Click += new System.EventHandler(this.operationclick);
            // 
            // dot_button
            // 
            this.dot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_button.Location = new System.Drawing.Point(139, 356);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(88, 69);
            this.dot_button.TabIndex = 59;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = true;
            this.dot_button.Click += new System.EventHandler(this.num_click);
            // 
            // m_minus_buttom
            // 
            this.m_minus_buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_minus_buttom.Location = new System.Drawing.Point(227, 77);
            this.m_minus_buttom.Name = "m_minus_buttom";
            this.m_minus_buttom.Size = new System.Drawing.Size(88, 69);
            this.m_minus_buttom.TabIndex = 57;
            this.m_minus_buttom.Text = "M-";
            this.m_minus_buttom.UseVisualStyleBackColor = true;
            this.m_minus_buttom.Click += new System.EventHandler(this.Memory);
            // 
            // m_plus_buttom
            // 
            this.m_plus_buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_plus_buttom.Location = new System.Drawing.Point(139, 77);
            this.m_plus_buttom.Name = "m_plus_buttom";
            this.m_plus_buttom.Size = new System.Drawing.Size(88, 69);
            this.m_plus_buttom.TabIndex = 56;
            this.m_plus_buttom.Text = "M+";
            this.m_plus_buttom.UseVisualStyleBackColor = true;
            this.m_plus_buttom.Click += new System.EventHandler(this.Memory);
            // 
            // mc_button
            // 
            this.mc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_button.Location = new System.Drawing.Point(51, 77);
            this.mc_button.Name = "mc_button";
            this.mc_button.Size = new System.Drawing.Size(88, 69);
            this.mc_button.TabIndex = 55;
            this.mc_button.Text = "MC";
            this.mc_button.UseVisualStyleBackColor = true;
            this.mc_button.Click += new System.EventHandler(this.Memory);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(316, 77);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 69);
            this.Clear.TabIndex = 53;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(51, 425);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(353, 69);
            this.equals.TabIndex = 52;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.operationclick);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(52, 356);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 69);
            this.zero.TabIndex = 51;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.num_click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(316, 287);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(88, 69);
            this.minus.TabIndex = 50;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operationclick);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(227, 287);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(88, 69);
            this.three.TabIndex = 49;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.num_click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(139, 287);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(88, 69);
            this.two.TabIndex = 48;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.num_click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(51, 287);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(88, 69);
            this.one.TabIndex = 47;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.num_click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(316, 218);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(88, 69);
            this.multiply.TabIndex = 46;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operationclick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(227, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 69);
            this.button6.TabIndex = 45;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(139, 218);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(88, 69);
            this.five.TabIndex = 44;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.num_click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(51, 218);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(88, 69);
            this.four.TabIndex = 43;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.num_click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(316, 149);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(88, 69);
            this.divide.TabIndex = 42;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operationclick);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(227, 149);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(88, 69);
            this.nine.TabIndex = 41;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.num_click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(139, 149);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(88, 69);
            this.eight.TabIndex = 40;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.num_click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(51, 149);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(88, 69);
            this.seven.TabIndex = 38;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.num_click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(316, 356);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(88, 69);
            this.plus.TabIndex = 54;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operationclick);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPercent.Location = new System.Drawing.Point(227, 356);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(88, 69);
            this.buttonPercent.TabIndex = 71;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // listBoxCurrency
            // 
            this.listBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxCurrency.FormattingEnabled = true;
            this.listBoxCurrency.ItemHeight = 20;
            this.listBoxCurrency.Items.AddRange(new object[] {
            "THB -> USD",
            "USD -> THB"});
            this.listBoxCurrency.Location = new System.Drawing.Point(537, 174);
            this.listBoxCurrency.Name = "listBoxCurrency";
            this.listBoxCurrency.Size = new System.Drawing.Size(103, 44);
            this.listBoxCurrency.TabIndex = 73;
            // 
            // buttonConv
            // 
            this.buttonConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonConv.Location = new System.Drawing.Point(522, 230);
            this.buttonConv.Name = "buttonConv";
            this.buttonConv.Size = new System.Drawing.Size(136, 51);
            this.buttonConv.TabIndex = 72;
            this.buttonConv.Text = "Convert";
            this.buttonConv.UseVisualStyleBackColor = true;
            this.buttonConv.Click += new System.EventHandler(this.buttonConv_Click_1);
            // 
            // maintextbox
            // 
            this.maintextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintextbox.Location = new System.Drawing.Point(51, 9);
            this.maintextbox.Name = "maintextbox";
            this.maintextbox.Size = new System.Drawing.Size(556, 62);
            this.maintextbox.TabIndex = 74;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertBinaryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // convertBinaryToolStripMenuItem
            // 
            this.convertBinaryToolStripMenuItem.Name = "convertBinaryToolStripMenuItem";
            this.convertBinaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.convertBinaryToolStripMenuItem.Text = "ConvertBinary";
            this.convertBinaryToolStripMenuItem.Click += new System.EventHandler(this.convertBinaryToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 509);
            this.Controls.Add(this.maintextbox);
            this.Controls.Add(this.listBoxCurrency);
            this.Controls.Add(this.buttonConv);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.memo_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exp_button);
            this.Controls.Add(this.expo3_button);
            this.Controls.Add(this.expo10_x_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.expo_y_button);
            this.Controls.Add(this.mod_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.m_minus_buttom);
            this.Controls.Add(this.m_plus_buttom);
            this.Controls.Add(this.mc_button);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox memo_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exp_button;
        private System.Windows.Forms.Button expo3_button;
        private System.Windows.Forms.Button expo10_x_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button expo_y_button;
        private System.Windows.Forms.Button mod_button;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button m_minus_buttom;
        private System.Windows.Forms.Button m_plus_buttom;
        private System.Windows.Forms.Button mc_button;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.ListBox listBoxCurrency;
        private System.Windows.Forms.Button buttonConv;
        private System.Windows.Forms.TextBox maintextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertBinaryToolStripMenuItem;
    }
}

