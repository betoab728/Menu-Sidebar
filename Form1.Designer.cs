namespace MenuSidebar
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
            components = new System.ComponentModel.Container();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu = new Panel();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            timerSidebar = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            btnmimizar = new Button();
            btncerrar = new Button();
            btnmaxmimizar = new Button();
            panel3 = new Panel();
            lblfecha = new Label();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.DimGray;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panelMenu);
            Sidebar.Controls.Add(button6);
            Sidebar.Controls.Add(button2);
            Sidebar.Controls.Add(button1);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(180, 452);
            Sidebar.TabIndex = 0;
            Sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 43);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._352539_menu_icon__1_2;
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 11);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Location = new Point(3, 52);
            panelMenu.MaximumSize = new Size(180, 200);
            panelMenu.MinimumSize = new Size(180, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 64);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panel2_Paint_1;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources._9075817_shopping_bag_shop_sale_buy_icon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(24, 135);
            button3.Name = "button3";
            button3.Size = new Size(154, 60);
            button3.TabIndex = 7;
            button3.Text = "Sales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.home48;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 3);
            button5.Name = "button5";
            button5.Size = new Size(178, 60);
            button5.TabIndex = 6;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources._7295023_tag_label_price_sale_discount_icon__1_;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(23, 69);
            button4.Name = "button4";
            button4.Size = new Size(154, 60);
            button4.TabIndex = 7;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10F);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.setting48;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 122);
            button6.Name = "button6";
            button6.Size = new Size(177, 60);
            button6.TabIndex = 7;
            button6.Text = "Settings";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources._2639759_about_icon__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 188);
            button2.Name = "button2";
            button2.Size = new Size(177, 60);
            button2.TabIndex = 9;
            button2.Text = "About";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources._326654_help_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 254);
            button1.Name = "button1";
            button1.Size = new Size(177, 60);
            button1.TabIndex = 8;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(btnmimizar);
            panel2.Controls.Add(btncerrar);
            panel2.Controls.Add(btnmaxmimizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(180, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 46);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_2;
            // 
            // btnmimizar
            // 
            btnmimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmimizar.FlatAppearance.BorderSize = 0;
            btnmimizar.FlatStyle = FlatStyle.Flat;
            btnmimizar.Image = Properties.Resources._4115236_delete_min_minus_icon;
            btnmimizar.Location = new Point(454, 7);
            btnmimizar.Name = "btnmimizar";
            btnmimizar.Size = new Size(35, 30);
            btnmimizar.TabIndex = 6;
            btnmimizar.UseVisualStyleBackColor = true;
            btnmimizar.Click += button11_Click;
            // 
            // btncerrar
            // 
            btncerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Image = Properties.Resources._352270_close_icon;
            btncerrar.Location = new Point(536, 6);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(35, 30);
            btncerrar.TabIndex = 2;
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += button7_Click;
            // 
            // btnmaxmimizar
            // 
            btnmaxmimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmaxmimizar.FlatAppearance.BorderSize = 0;
            btnmaxmimizar.FlatStyle = FlatStyle.Flat;
            btnmaxmimizar.Image = Properties.Resources.maximize;
            btnmaxmimizar.Location = new Point(495, 6);
            btnmaxmimizar.Name = "btnmaxmimizar";
            btnmaxmimizar.Size = new Size(35, 30);
            btnmaxmimizar.TabIndex = 4;
            btnmaxmimizar.UseVisualStyleBackColor = true;
            btnmaxmimizar.Click += button9_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblfecha);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(180, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(583, 44);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 14F);
            lblfecha.ForeColor = Color.Black;
            lblfecha.Location = new Point(6, 13);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(63, 25);
            lblfecha.TabIndex = 0;
            lblfecha.Text = "label2";
            lblfecha.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 452);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Label label1;
        private Button button5;
        private Button button2;
        private System.Windows.Forms.Timer timerSidebar;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button6;
        private System.Windows.Forms.Timer timerMenu;
        private Panel panel2;
        private Button btncerrar;
        private Button btnmaxmimizar;
        private Button btnmimizar;
        private Panel panel3;
        private Label lblfecha;
    }
}
