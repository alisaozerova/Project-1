using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsControlLibrary1
{
    public partial class LockButton : Button
    {
        private System.Windows.Forms.Timer timer;
        private int delay;

        private String caption;
        private int time;

        public int Delay
        {
            get { return delay; }
            set
            {
                delay = value;
            }
        }

        private void LockButtonClick()
        {
            caption = Text;
            time = delay;
            Enabled = false;
            Text = "Wait " + time + " sec";
            timer.Start();
        }

        private void LockButtonTick()
        {
            time--;
            if (time == 0)
            {
                Enabled = true;
                Text = caption;
                timer.Stop();
            }
            else {
                Text = "Wait " + time + " sec";
            }
        }

        public LockButton()
        {
            InitializeComponent();
        }
    }
}
