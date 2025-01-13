namespace Projekt_AiSD___Minimalne_Drzewo_Rozpinające
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
            panel1 = new Panel();
            label2 = new Label();
            textBox_name = new TextBox();
            Adder = new Button();
            panel2 = new Panel();
            selector_remover = new ComboBox();
            Remover = new Button();
            textBox_list = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            confirm_distance = new Button();
            textBox_list_distance = new TextBox();
            label5 = new Label();
            textBox_distance = new TextBox();
            label4 = new Label();
            selector2 = new ComboBox();
            selector1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(Adder);
            panel1.Location = new Point(-1, 17);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 156);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 16);
            label2.Name = "label2";
            label2.Size = new Size(220, 39);
            label2.TabIndex = 2;
            label2.Text = "Wpisz nazwę uprawy:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(46, 58);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "......";
            textBox_name.Size = new Size(241, 27);
            textBox_name.TabIndex = 1;
            textBox_name.TextAlign = HorizontalAlignment.Center;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // Adder
            // 
            Adder.BackColor = Color.White;
            Adder.FlatStyle = FlatStyle.Flat;
            Adder.Location = new Point(58, 99);
            Adder.Margin = new Padding(0);
            Adder.Name = "Adder";
            Adder.Size = new Size(208, 30);
            Adder.TabIndex = 0;
            Adder.Text = "Dodaj uprawę";
            Adder.UseVisualStyleBackColor = false;
            Adder.Click += AdderClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(selector_remover);
            panel2.Controls.Add(Remover);
            panel2.Controls.Add(textBox_list);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 156);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 636);
            panel2.TabIndex = 3;
            // 
            // selector_remover
            // 
            selector_remover.FormattingEnabled = true;
            selector_remover.Location = new Point(45, 310);
            selector_remover.Name = "selector_remover";
            selector_remover.Size = new Size(241, 28);
            selector_remover.TabIndex = 3;
            // 
            // Remover
            // 
            Remover.Location = new Point(45, 344);
            Remover.Name = "Remover";
            Remover.Size = new Size(241, 29);
            Remover.TabIndex = 2;
            Remover.Text = "Usuń wybraną uprawę";
            Remover.UseVisualStyleBackColor = true;
            Remover.Click += Remover_Click;
            // 
            // textBox_list
            // 
            textBox_list.Location = new Point(45, 45);
            textBox_list.Multiline = true;
            textBox_list.Name = "textBox_list";
            textBox_list.Size = new Size(241, 259);
            textBox_list.TabIndex = 1;
            textBox_list.TextChanged += textBox_list_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 17);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista upraw:";
            // 
            // panel3
            // 
            panel3.Controls.Add(confirm_distance);
            panel3.Controls.Add(textBox_list_distance);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox_distance);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(selector2);
            panel3.Controls.Add(selector1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(327, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 792);
            panel3.TabIndex = 4;
            // 
            // confirm_distance
            // 
            confirm_distance.Location = new Point(190, 195);
            confirm_distance.Name = "confirm_distance";
            confirm_distance.Size = new Size(136, 29);
            confirm_distance.TabIndex = 7;
            confirm_distance.Text = "Zatwierdź";
            confirm_distance.UseVisualStyleBackColor = true;
            confirm_distance.Click += confirm_distance_Click;
            // 
            // textBox_list_distance
            // 
            textBox_list_distance.Location = new Point(48, 249);
            textBox_list_distance.Multiline = true;
            textBox_list_distance.Name = "textBox_list_distance";
            textBox_list_distance.Size = new Size(278, 529);
            textBox_list_distance.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 174);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "Odległość:";
            // 
            // textBox_distance
            // 
            textBox_distance.Location = new Point(48, 197);
            textBox_distance.Name = "textBox_distance";
            textBox_distance.Size = new Size(136, 27);
            textBox_distance.TabIndex = 4;
            textBox_distance.TextChanged += textBox_distance_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 52);
            label4.Name = "label4";
            label4.Size = new Size(368, 60);
            label4.TabIndex = 3;
            label4.Text = "Wybierz dwie uprawy i podaj odległość w metrach\r\nmiędzy zraszaczami na tych uprawach.\r\nUpewnij się, że prawidłowo dodałeś wszystkie uprawy!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selector2
            // 
            selector2.FormattingEnabled = true;
            selector2.Location = new Point(190, 128);
            selector2.Name = "selector2";
            selector2.Size = new Size(136, 28);
            selector2.TabIndex = 2;
            // 
            // selector1
            // 
            selector1.FormattingEnabled = true;
            selector1.Location = new Point(48, 128);
            selector1.Name = "selector1";
            selector1.Size = new Size(136, 28);
            selector1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 22);
            label3.Name = "label3";
            label3.Size = new Size(372, 25);
            label3.TabIndex = 0;
            label3.Text = "Pomiary odległości między uprawami:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(242, 280);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 69);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(242, 280);
            textBox2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(755, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(588, 461);
            panel4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1416, 790);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private TextBox textBox_name;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_list;
        private Panel panel3;
        private Label label3;
        private TextBox textBox_distance;
        private ComboBox selector2;
        private ComboBox selector1;
        private Label label4;
        private Label label5;
        private TextBox textBox_list_distance;
        private Button confirm_distance;
        private Button Adder;
        private ComboBox selector_remover;
        private Button Remover;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel4;
    }
}