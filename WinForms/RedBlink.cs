using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace RedBlinkWinForms
{
    public partial class RedBlink : Form
    {
        private Task _TimeController;
        private CancellationTokenSource _CancellationTokenSource;

        private Timer _DoubleClickTimer = new Timer();
        private bool _IsFirstClick = true;
        private bool _IsDoubleClick = false;
        private int _Milliseconds = 0;

        public RedBlink()
        {
            InitializeComponent();
            InitControls();
            InitComponents();
        }

        private void InitComponents()
        {
            _CancellationTokenSource = new CancellationTokenSource();

            _TimeController = new Task(async (token) =>
            {
                try
                {
                    while (true)
                    {
                        await Task.Delay(1000);
                        this.Invoke((MethodInvoker)delegate { Visible = true; });
                    }
                }
                catch { }
            }, _CancellationTokenSource.Token);

            _TimeController.Start();


            _DoubleClickTimer.Interval = 100;
            _DoubleClickTimer.Tick +=
                new EventHandler(DoubleClickTimer_Tick);
        }

        private void InitControls()
        {
            this.Size = new Size(600, 400);
            this.FormBorderStyle = FormBorderStyle.None;

            this.lbl_RedLabel.BackColor = Color.Red;
            this.lbl_RedLabel.Text = "Red";
        }

        void DoubleClickTimer_Tick(object sender, EventArgs e)
        {
            _Milliseconds += 100;

            if (_Milliseconds >= SystemInformation.DoubleClickTime)
            {
                _DoubleClickTimer.Stop();

                if (_IsDoubleClick)
                {
                    _CancellationTokenSource.Cancel();
                    _TimeController.Wait();
                    Application.Exit();
                }
                else
                {
                    this.Visible = false;
                }

                _IsFirstClick = true;
                _IsDoubleClick = false;
                _Milliseconds = 0;
            }
        }

        private void Lbl_RedLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_IsFirstClick)
            {
                _IsFirstClick = false;
                _DoubleClickTimer.Start();
            }
            else
            {
                if (_Milliseconds < SystemInformation.DoubleClickTime)
                {
                    _IsDoubleClick = true;
                }
            }
        }
    }
}
