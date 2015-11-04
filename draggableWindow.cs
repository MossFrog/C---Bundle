public partial class Form1 : Form
    {
        //-- Define the initial positions of the window and mouse , these variables will be captured upon the MouseDown event --//
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


        //-- MouseMove event that will comve the window if the Left mouse button is pressed --//
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //-- Calculate the delta (Change) in the mouse Position and update the location of the form A.K.A "this" --//
                int deltaX = MousePosition.X - mouseX;
                int deltaY = MousePosition.Y - mouseY;

                this.Location = new Point( windowX + deltaX , windowY + deltaY );
            }
        }

        //-- MouseDown event is only called once and captures the initial conditions --//
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;

            windowX = this.Location.X;
            windowY = this.Location.Y;
        }
    }