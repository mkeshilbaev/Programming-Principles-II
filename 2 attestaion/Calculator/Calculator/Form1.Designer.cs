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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.percent = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rational = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clearLastDigit = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.ForeColor = System.Drawing.Color.White;
            this.percent.Location = new System.Drawing.Point(1, 225);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(82, 48);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.root.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.ForeColor = System.Drawing.Color.White;
            this.root.Location = new System.Drawing.Point(76, 225);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(82, 48);
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
            this.square.Location = new System.Drawing.Point(154, 225);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(82, 48);
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
            this.rational.Location = new System.Drawing.Point(1, 269);
            this.rational.Name = "rational";
            this.rational.Size = new System.Drawing.Size(82, 48);
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
            this.division.Location = new System.Drawing.Point(231, 269);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(82, 48);
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
            this.clearLastDigit.Location = new System.Drawing.Point(154, 269);
            this.clearLastDigit.Name = "clearLastDigit";
            this.clearLastDigit.Size = new System.Drawing.Size(82, 48);
            this.clearLastDigit.TabIndex = 6;
            this.clearLastDigit.Text = "<=";
            this.clearLastDigit.UseVisualStyleBackColor = false;
            this.clearLastDigit.Click += new System.EventHandler(this.clearLastDigit_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(76, 269);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(82, 48);
            this.clearAll.TabIndex = 5;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEntry.ForeColor = System.Drawing.Color.White;
            this.clearEntry.Location = new System.Drawing.Point(231, 225);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(82, 48);
            this.clearEntry.TabIndex = 4;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(231, 307);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(82, 48);
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
            this.nine.Location = new System.Drawing.Point(154, 307);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(82, 48);
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
            this.eight.Location = new System.Drawing.Point(76, 307);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(82, 48);
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
            this.seven.Location = new System.Drawing.Point(1, 307);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(82, 48);
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
            this.minus.Location = new System.Drawing.Point(231, 350);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(82, 48);
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
            this.six.Location = new System.Drawing.Point(154, 350);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(82, 48);
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
            this.five.Location = new System.Drawing.Point(76, 350);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(82, 48);
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
            this.four.Location = new System.Drawing.Point(1, 350);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(82, 48);
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
            this.plus.Location = new System.Drawing.Point(231, 395);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(82, 48);
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
            this.three.Location = new System.Drawing.Point(154, 395);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(82, 48);
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
            this.two.Location = new System.Drawing.Point(76, 395);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(82, 48);
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
            this.one.Location = new System.Drawing.Point(1, 395);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(82, 48);
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
            this.equal.Location = new System.Drawing.Point(231, 436);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(82, 48);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma.ForeColor = System.Drawing.Color.White;
            this.comma.Location = new System.Drawing.Point(154, 436);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(82, 48);
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
            this.zero.Location = new System.Drawing.Point(76, 436);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(82, 48);
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
            this.plusminus.Location = new System.Drawing.Point(1, 436);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(82, 48);
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
            this.MemoryAdd.Location = new System.Drawing.Point(231, 180);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(82, 48);
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
            this.memoryStore.Location = new System.Drawing.Point(154, 180);
            this.memoryStore.Name = "memoryStore";
            this.memoryStore.Size = new System.Drawing.Size(82, 48);
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
            this.memoryRecall.Location = new System.Drawing.Point(76, 180);
            this.memoryRecall.Name = "memoryRecall";
            this.memoryRecall.Size = new System.Drawing.Size(82, 48);
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
            this.memoryClear.Location = new System.Drawing.Point(1, 180);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(82, 48);
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
            this.textBox1.Location = new System.Drawing.Point(17, 79);
            this.textBox1.MaxLength = 12;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 71);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memorySubtract
            // 
            this.memorySubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memorySubtract.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySubtract.ForeColor = System.Drawing.Color.White;
            this.memorySubtract.Location = new System.Drawing.Point(231, 225);
            this.memorySubtract.Name = "memorySubtract";
            this.memorySubtract.Size = new System.Drawing.Size(82, 48);
            this.memorySubtract.TabIndex = 31;
            this.memorySubtract.Text = "M-";
            this.memorySubtract.UseVisualStyleBackColor = false;
            this.memorySubtract.Click += new System.EventHandler(this.memorySubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(314, 484);
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
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.rational);
            this.Controls.Add(this.square);
            this.Controls.Add(this.root);
            this.Controls.Add(this.percent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
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
        private System.Windows.Forms.Button clearEntry;
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
    }
}

