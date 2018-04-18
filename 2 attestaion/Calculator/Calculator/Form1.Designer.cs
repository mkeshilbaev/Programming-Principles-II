namespace CALCULATOR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.percent = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rational = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clearLastDigit = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MemoryAdd = new System.Windows.Forms.Button();
            this.memoryStore = new System.Windows.Forms.Button();
            this.memoryRecall = new System.Windows.Forms.Button();
            this.memoryClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.memorySubtract = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Brecket1 = new System.Windows.Forms.Button();
            this.Fact = new System.Windows.Forms.Button();
            this.TenPower = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Brecket2 = new System.Windows.Forms.Button();
            this.PI = new System.Windows.Forms.Button();
            this.XandYpow = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEntry = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.ForeColor = System.Drawing.Color.White;
            this.percent.Location = new System.Drawing.Point(-1, 205);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(80, 50);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.operator_click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.root.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.ForeColor = System.Drawing.Color.White;
            this.root.Location = new System.Drawing.Point(74, 198);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(80, 50);
            this.root.TabIndex = 1;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.ForeColor = System.Drawing.Color.White;
            this.square.Location = new System.Drawing.Point(148, 198);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 50);
            this.square.TabIndex = 2;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rational
            // 
            this.rational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rational.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rational.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rational.ForeColor = System.Drawing.Color.White;
            this.rational.Location = new System.Drawing.Point(376, 423);
            this.rational.Name = "rational";
            this.rational.Size = new System.Drawing.Size(80, 50);
            this.rational.TabIndex = 3;
            this.rational.Text = "1/x";
            this.rational.UseVisualStyleBackColor = false;
            this.rational.Click += new System.EventHandler(this.rational_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.ForeColor = System.Drawing.Color.White;
            this.division.Location = new System.Drawing.Point(223, 243);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(80, 50);
            this.division.TabIndex = 7;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.operator_click);
            // 
            // clearLastDigit
            // 
            this.clearLastDigit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearLastDigit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearLastDigit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLastDigit.ForeColor = System.Drawing.Color.White;
            this.clearLastDigit.Location = new System.Drawing.Point(148, 243);
            this.clearLastDigit.Name = "clearLastDigit";
            this.clearLastDigit.Size = new System.Drawing.Size(80, 50);
            this.clearLastDigit.TabIndex = 6;
            this.clearLastDigit.Text = "←";
            this.clearLastDigit.UseVisualStyleBackColor = false;
            this.clearLastDigit.Click += new System.EventHandler(this.clearLastDigit_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(0, 243);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(80, 50);
            this.clearAll.TabIndex = 5;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(223, 288);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 50);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Gray;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.ForeColor = System.Drawing.Color.White;
            this.nine.Location = new System.Drawing.Point(148, 288);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 50);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_CLick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Gray;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.ForeColor = System.Drawing.Color.White;
            this.eight.Location = new System.Drawing.Point(74, 288);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 50);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_CLick);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Gray;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.ForeColor = System.Drawing.Color.White;
            this.seven.Location = new System.Drawing.Point(-1, 288);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 50);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_CLick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.Color.White;
            this.minus.Location = new System.Drawing.Point(223, 333);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 50);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operator_click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Gray;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.ForeColor = System.Drawing.Color.White;
            this.six.Location = new System.Drawing.Point(148, 333);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 50);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_CLick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Gray;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.ForeColor = System.Drawing.Color.White;
            this.five.Location = new System.Drawing.Point(74, 333);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 50);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_CLick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Gray;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.ForeColor = System.Drawing.Color.White;
            this.four.Location = new System.Drawing.Point(-1, 333);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 50);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_CLick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(223, 379);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 50);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operator_click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Gray;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.ForeColor = System.Drawing.Color.White;
            this.three.Location = new System.Drawing.Point(148, 379);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 50);
            this.three.TabIndex = 18;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_CLick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gray;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(74, 379);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 50);
            this.two.TabIndex = 17;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_CLick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gray;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(-1, 379);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 50);
            this.one.TabIndex = 16;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_CLick);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.SaddleBrown;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.ForeColor = System.Drawing.Color.White;
            this.equal.Location = new System.Drawing.Point(223, 423);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(157, 50);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma.ForeColor = System.Drawing.Color.White;
            this.comma.Location = new System.Drawing.Point(148, 423);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(80, 50);
            this.comma.TabIndex = 22;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.button_CLick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Gray;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(74, 423);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 50);
            this.zero.TabIndex = 21;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_CLick);
            // 
            // plusminus
            // 
            this.plusminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plusminus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusminus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusminus.ForeColor = System.Drawing.Color.White;
            this.plusminus.Location = new System.Drawing.Point(-1, 423);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(80, 50);
            this.plusminus.TabIndex = 20;
            this.plusminus.Text = "±";
            this.plusminus.UseVisualStyleBackColor = false;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 25;
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MemoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MemoryAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryAdd.ForeColor = System.Drawing.Color.White;
            this.MemoryAdd.Location = new System.Drawing.Point(223, 156);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(80, 50);
            this.MemoryAdd.TabIndex = 29;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = false;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAdd_Click);
            // 
            // memoryStore
            // 
            this.memoryStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memoryStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memoryStore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryStore.ForeColor = System.Drawing.Color.White;
            this.memoryStore.Location = new System.Drawing.Point(148, 156);
            this.memoryStore.Name = "memoryStore";
            this.memoryStore.Size = new System.Drawing.Size(80, 50);
            this.memoryStore.TabIndex = 28;
            this.memoryStore.Text = "MS";
            this.memoryStore.UseVisualStyleBackColor = false;
            this.memoryStore.Click += new System.EventHandler(this.memoryStore_Click);
            // 
            // memoryRecall
            // 
            this.memoryRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memoryRecall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryRecall.ForeColor = System.Drawing.Color.White;
            this.memoryRecall.Location = new System.Drawing.Point(74, 156);
            this.memoryRecall.Name = "memoryRecall";
            this.memoryRecall.Size = new System.Drawing.Size(80, 50);
            this.memoryRecall.TabIndex = 27;
            this.memoryRecall.Text = "MR";
            this.memoryRecall.UseVisualStyleBackColor = false;
            this.memoryRecall.Click += new System.EventHandler(this.memoryRecall_Click);
            // 
            // memoryClear
            // 
            this.memoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memoryClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryClear.ForeColor = System.Drawing.Color.White;
            this.memoryClear.Location = new System.Drawing.Point(-1, 156);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(80, 50);
            this.memoryClear.TabIndex = 26;
            this.memoryClear.Text = "MC";
            this.memoryClear.UseVisualStyleBackColor = false;
            this.memoryClear.Click += new System.EventHandler(this.memoryClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.MaxLength = 12;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 71);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memorySubtract
            // 
            this.memorySubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memorySubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memorySubtract.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySubtract.ForeColor = System.Drawing.Color.White;
            this.memorySubtract.Location = new System.Drawing.Point(223, 205);
            this.memorySubtract.Name = "memorySubtract";
            this.memorySubtract.Size = new System.Drawing.Size(80, 50);
            this.memorySubtract.TabIndex = 31;
            this.memorySubtract.Text = "M-";
            this.memorySubtract.UseVisualStyleBackColor = false;
            this.memorySubtract.Click += new System.EventHandler(this.memorySubtract_Click);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin.ForeColor = System.Drawing.Color.White;
            this.Sin.Location = new System.Drawing.Point(300, 198);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(80, 50);
            this.Sin.TabIndex = 39;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Brecket1
            // 
            this.Brecket1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Brecket1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brecket1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brecket1.ForeColor = System.Drawing.Color.White;
            this.Brecket1.Location = new System.Drawing.Point(300, 156);
            this.Brecket1.Name = "Brecket1";
            this.Brecket1.Size = new System.Drawing.Size(80, 50);
            this.Brecket1.TabIndex = 38;
            this.Brecket1.Text = "(";
            this.Brecket1.UseVisualStyleBackColor = false;
            this.Brecket1.Click += new System.EventHandler(this.operator_click);
            // 
            // Fact
            // 
            this.Fact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fact.ForeColor = System.Drawing.Color.White;
            this.Fact.Location = new System.Drawing.Point(376, 379);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(80, 50);
            this.Fact.TabIndex = 36;
            this.Fact.Text = "n!";
            this.Fact.UseVisualStyleBackColor = false;
            this.Fact.Click += new System.EventHandler(this.Fact_Click);
            // 
            // TenPower
            // 
            this.TenPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TenPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TenPower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TenPower.ForeColor = System.Drawing.Color.White;
            this.TenPower.Location = new System.Drawing.Point(300, 333);
            this.TenPower.Name = "TenPower";
            this.TenPower.Size = new System.Drawing.Size(80, 50);
            this.TenPower.TabIndex = 35;
            this.TenPower.Text = "10^x";
            this.TenPower.UseVisualStyleBackColor = false;
            this.TenPower.Click += new System.EventHandler(this.TenPower_Click);
            // 
            // Exp
            // 
            this.Exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exp.ForeColor = System.Drawing.Color.White;
            this.Exp.Location = new System.Drawing.Point(300, 288);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(80, 50);
            this.Exp.TabIndex = 34;
            this.Exp.Text = "Exp";
            this.Exp.UseVisualStyleBackColor = false;
            this.Exp.Click += new System.EventHandler(this.Exp_Click_1);
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tan.ForeColor = System.Drawing.Color.White;
            this.Tan.Location = new System.Drawing.Point(300, 243);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(80, 50);
            this.Tan.TabIndex = 33;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = false;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.ForeColor = System.Drawing.Color.White;
            this.Cos.Location = new System.Drawing.Point(376, 198);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(80, 50);
            this.Cos.TabIndex = 47;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Brecket2
            // 
            this.Brecket2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Brecket2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brecket2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brecket2.ForeColor = System.Drawing.Color.White;
            this.Brecket2.Location = new System.Drawing.Point(376, 156);
            this.Brecket2.Name = "Brecket2";
            this.Brecket2.Size = new System.Drawing.Size(80, 50);
            this.Brecket2.TabIndex = 46;
            this.Brecket2.Text = ")";
            this.Brecket2.UseVisualStyleBackColor = false;
            this.Brecket2.Click += new System.EventHandler(this.operator_click);
            // 
            // PI
            // 
            this.PI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PI.ForeColor = System.Drawing.Color.White;
            this.PI.Location = new System.Drawing.Point(300, 379);
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(80, 50);
            this.PI.TabIndex = 44;
            this.PI.Text = "PI";
            this.PI.UseVisualStyleBackColor = false;
            this.PI.Click += new System.EventHandler(this.PI_Click);
            // 
            // XandYpow
            // 
            this.XandYpow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XandYpow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XandYpow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XandYpow.ForeColor = System.Drawing.Color.White;
            this.XandYpow.Location = new System.Drawing.Point(376, 333);
            this.XandYpow.Name = "XandYpow";
            this.XandYpow.Size = new System.Drawing.Size(80, 50);
            this.XandYpow.TabIndex = 43;
            this.XandYpow.Text = "x^y";
            this.XandYpow.UseVisualStyleBackColor = false;
            this.XandYpow.Click += new System.EventHandler(this.operator_click);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mod.ForeColor = System.Drawing.Color.White;
            this.Mod.Location = new System.Drawing.Point(376, 288);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(80, 50);
            this.Mod.TabIndex = 42;
            this.Mod.Text = "Mod";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.operator_click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(376, 243);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(80, 50);
            this.log.TabIndex = 41;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.engineerToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sToolStripMenuItem.Text = "Mode";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // engineerToolStripMenuItem
            // 
            this.engineerToolStripMenuItem.Name = "engineerToolStripMenuItem";
            this.engineerToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.engineerToolStripMenuItem.Text = "Engineer";
            this.engineerToolStripMenuItem.Click += new System.EventHandler(this.engineerToolStripMenuItem_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEntry.ForeColor = System.Drawing.Color.White;
            this.clearEntry.Location = new System.Drawing.Point(74, 243);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(80, 50);
            this.clearEntry.TabIndex = 49;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(301, 473);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Brecket2);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.XandYpow);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Brecket1);
            this.Controls.Add(this.Fact);
            this.Controls.Add(this.TenPower);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.memorySubtract);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MemoryAdd);
            this.Controls.Add(this.memoryStore);
            this.Controls.Add(this.memoryRecall);
            this.Controls.Add(this.memoryClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.division);
            this.Controls.Add(this.clearLastDigit);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.rational);
            this.Controls.Add(this.square);
            this.Controls.Add(this.root);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rational;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clearLastDigit;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button MemoryAdd;
        private System.Windows.Forms.Button memoryStore;
        private System.Windows.Forms.Button memoryRecall;
        private System.Windows.Forms.Button memoryClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button memorySubtract;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Brecket1;
        private System.Windows.Forms.Button Fact;
        private System.Windows.Forms.Button TenPower;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Brecket2;
        private System.Windows.Forms.Button PI;
        private System.Windows.Forms.Button XandYpow;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engineerToolStripMenuItem;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

