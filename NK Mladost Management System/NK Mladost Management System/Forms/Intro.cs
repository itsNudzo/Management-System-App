using NK_Mladost_Management_System.Forms;
using System.Windows.Forms;
namespace NK_Mladost_Management_System
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            MyProgress.Value = startPoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}