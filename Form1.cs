using System.Diagnostics.Eventing.Reader;

namespace MenuSidebar
{
    public partial class Form1 : Form
    {
        bool isSidebarExpand;
        bool menuExpanded;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isSidebarExpand = true;
            menuExpanded = false;
            lblfecha.Text = DateTime.Now.ToLongDateString();
          
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpand)
            {

                Sidebar.Width -= 10;

                if (Sidebar.Width <= 53)
                {
                    timerSidebar.Stop();
                    isSidebarExpand = false;
                    this.Refresh();
                }



            }
            else
            {


                Sidebar.Width += 10;

                if (Sidebar.Width >= 180)
                {
                    timerSidebar.Stop();
                    isSidebarExpand = true;
                    this.Refresh();
                }
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {

            if (menuExpanded)
            {
                panelMenu.Height -= 10;
                if (panelMenu.Height <= panelMenu.MinimumSize.Height)
                {
                    timerMenu.Stop();
                    menuExpanded = false;
                    this.Refresh();
                }
            }
            else
            {
                panelMenu.Height += 10;
                if (panelMenu.Height >= panelMenu.MaximumSize.Height)
                {
                    timerMenu.Stop();
                    menuExpanded = true;
                    this.Refresh();
                }
            }


        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                //intercambiamos el icono del boton a restaurar 
                btnmaxmimizar.Image = Properties.Resources.restore;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;

                //intercambiamos el icono del boton a restaurar
                btnmaxmimizar.Image = Properties.Resources.maximize;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
