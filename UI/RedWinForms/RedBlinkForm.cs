using JanHoffmann.Red.UI.RedWinForms.Contract;

using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace JanHoffmann.Red.UI.RedWinForms
{
    public partial class RedBlinkForm : Form, IRedBlinkForm
    {
        private Task _timeController;
        private CancellationTokenSource _cancellationTokenSource;

        private readonly Timer _doubleClickTimer = new Timer();
        private readonly Random _random = new Random();
        private bool _isFirstClick = true;
        private bool _isDoubleClick = false;
        private int _milliseconds = 0;

        public RedBlinkForm()
        {
            InitializeComponent();
            InitControls();
            InitComponents();
        }

        private void InitComponents()
        {
            _cancellationTokenSource = new CancellationTokenSource();

            _timeController = new Task(async (token) =>
            {
                while (true)
                {
                    await Task.Delay(1000 * 60 * 20);
                    this.Invoke((MethodInvoker) delegate
                    {
                        Visible = true;
                        var index = _random.Next(Messages.MessageCount);
                        lbl_RedLabel.Text = Messages.Excercises[index];
                    });
                }
            }, _cancellationTokenSource.Token);

            _timeController.Start();

            _doubleClickTimer.Interval = 100;
            _doubleClickTimer.Tick += new EventHandler(DoubleClickTimer_Tick);
        }

        private void InitControls()
        {
            this.Size = new Size(600, 400);
            this.FormBorderStyle = FormBorderStyle.None;

            this.lbl_RedLabel.BackColor = Color.Red;
            this.lbl_RedLabel.Text = "Red";
            this.lbl_RedLabel.Font = new Font(
                FontFamily.GenericSansSerif,
                48f,
                FontStyle.Regular);
        }

        void DoubleClickTimer_Tick(object sender, EventArgs e)
        {
            _milliseconds += 100;

            if (_milliseconds >= SystemInformation.DoubleClickTime)
            {
                _doubleClickTimer.Stop();

                if (_isDoubleClick)
                {
                    _cancellationTokenSource.Cancel();
                    _timeController.Wait();
                    Application.Exit();
                }
                else
                {
                    this.Visible = false;
                }

                _isFirstClick = true;
                _isDoubleClick = false;
                _milliseconds = 0;
            }
        }

        private void Lbl_RedLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isFirstClick)
            {
                _isFirstClick = false;
                _doubleClickTimer.Start();
            }
            else
            {
                if (_milliseconds < SystemInformation.DoubleClickTime)
                {
                    _isDoubleClick = true;
                }
            }
        }
    }
}
