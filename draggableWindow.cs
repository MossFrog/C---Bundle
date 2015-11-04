public partial class Form1 : Form
    {
        int mouseX;
        int mouseY;
        int windowX;
        int windowY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = MousePosition.X - mouseX;
                int deltaY = MousePosition.Y - mouseY;

                this.Location = new Point( windowX + deltaX , windowY + deltaY );
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;

            windowX = this.Location.X;
            windowY = this.Location.Y;
        }
    }