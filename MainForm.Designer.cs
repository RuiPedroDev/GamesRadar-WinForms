namespace GameApi
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            refreshButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MaxPriceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            MinPriceNumericUpDown = new NumericUpDown();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox1 = new TextBox();
            storeFilterButton = new Button();
            prevButtonPage = new Button();
            nextPageButton = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)MaxPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshButton.FlatAppearance.BorderColor = Color.White;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(860, 565);
            refreshButton.Margin = new Padding(4, 3, 4, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 39);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(955, 461);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // MaxPriceNumericUpDown
            // 
            MaxPriceNumericUpDown.BackColor = SystemColors.Control;
            MaxPriceNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxPriceNumericUpDown.Location = new Point(248, 15);
            MaxPriceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            MaxPriceNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            MaxPriceNumericUpDown.Name = "MaxPriceNumericUpDown";
            MaxPriceNumericUpDown.Size = new Size(61, 29);
            MaxPriceNumericUpDown.TabIndex = 2;
            MaxPriceNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            MaxPriceNumericUpDown.ValueChanged += MaxPriceNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(160, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 3;
            label1.Text = "Max Price:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Price", "Store", "Deal Rating", "Title", "Savings", "Reviews", "Metacritic" });
            comboBox1.Location = new Point(405, 15);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 29);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(335, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 5;
            label2.Text = "Sort by:";
            // 
            // MinPriceNumericUpDown
            // 
            MinPriceNumericUpDown.BackColor = SystemColors.Control;
            MinPriceNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinPriceNumericUpDown.Location = new Point(90, 15);
            MinPriceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            MinPriceNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            MinPriceNumericUpDown.Name = "MinPriceNumericUpDown";
            MinPriceNumericUpDown.Size = new Size(51, 29);
            MinPriceNumericUpDown.TabIndex = 6;
            MinPriceNumericUpDown.ValueChanged += MinPriceNumericUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 7;
            label3.Text = "Min Price:";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.FromArgb(70, 70, 70);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(14, 14);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(radioButton2);
            splitContainer1.Panel1.Controls.Add(radioButton1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(MinPriceNumericUpDown);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(MaxPriceNumericUpDown);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(956, 535);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 8;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(680, 16);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(114, 25);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Descending";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(560, 16);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 25);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ascending";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(805, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 9;
            label4.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(870, 15);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.MaxLength = 64;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 29);
            textBox1.TabIndex = 8;
            // 
            // storeFilterButton
            // 
            storeFilterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            storeFilterButton.FlatAppearance.BorderColor = Color.White;
            storeFilterButton.FlatStyle = FlatStyle.Flat;
            storeFilterButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            storeFilterButton.ForeColor = Color.White;
            storeFilterButton.Location = new Point(685, 565);
            storeFilterButton.Margin = new Padding(4, 3, 4, 3);
            storeFilterButton.Name = "storeFilterButton";
            storeFilterButton.Size = new Size(133, 39);
            storeFilterButton.TabIndex = 9;
            storeFilterButton.Text = "Filter by store";
            storeFilterButton.UseVisualStyleBackColor = true;
            storeFilterButton.Click += storeFilterButton_Click;
            // 
            // prevButtonPage
            // 
            prevButtonPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            prevButtonPage.FlatAppearance.BorderColor = Color.White;
            prevButtonPage.FlatStyle = FlatStyle.Flat;
            prevButtonPage.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            prevButtonPage.ForeColor = Color.White;
            prevButtonPage.Location = new Point(14, 565);
            prevButtonPage.Margin = new Padding(4, 3, 4, 3);
            prevButtonPage.Name = "prevButtonPage";
            prevButtonPage.Size = new Size(163, 39);
            prevButtonPage.TabIndex = 9;
            prevButtonPage.Text = "Previous page";
            prevButtonPage.UseVisualStyleBackColor = true;
            prevButtonPage.Click += prevPageButton_Click;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nextPageButton.FlatAppearance.BorderColor = Color.White;
            nextPageButton.FlatStyle = FlatStyle.Flat;
            nextPageButton.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            nextPageButton.ForeColor = Color.White;
            nextPageButton.Location = new Point(330, 565);
            nextPageButton.Margin = new Padding(4, 3, 4, 3);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(163, 39);
            nextPageButton.TabIndex = 10;
            nextPageButton.Text = "Next page";
            nextPageButton.UseVisualStyleBackColor = true;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 573);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 10;
            label5.Text = "Page number: 1";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(510, 573);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 11;
            label6.Text = "Made by: Rui Borges";
            // 
            // MainForm
            // 
            AcceptButton = refreshButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(984, 624);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(storeFilterButton);
            Controls.Add(nextPageButton);
            Controls.Add(prevButtonPage);
            Controls.Add(splitContainer1);
            Controls.Add(refreshButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1000, 663);
            Name = "MainForm";
            Text = "Games Radar";
            ((System.ComponentModel.ISupportInitialize)MaxPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinPriceNumericUpDown).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown MaxPriceNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinPriceNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button storeFilterButton;
        private System.Windows.Forms.Button prevButtonPage;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

