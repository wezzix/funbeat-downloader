using System;
using System.Windows.Forms;
using MK.Funbeat.Utilities;

namespace FunbeatDownloader
{
    public partial class MainForm : Form
    {
        private readonly FunbeatController _controller;

        public MainForm()
        {
            InitializeComponent();

            _controller = new FunbeatController();
            grdDayNotes.DataSource = _controller.DayNotes;
            grdTrainings.DataSource = _controller.Trainings;
            grdTrainingRawDatas.DataSource = _controller.RawTrainings;
            txtUsername.Bind(o => o.Text, _controller, o => o.Username);
            txtPassword.Bind(o => o.Text, _controller, o => o.Password);
            btnFetchTrainings.Bind(o => o.Enabled, _controller, o => o.CanFetchTrainings);
        }

        private void btnProcessClipboard_Click(object sender, EventArgs e)
        {
            ProcessClipboard();
        }

        private void ProcessClipboard()
        {
            var source = Clipboard.GetText();

            _controller.ParseCalendarSource(source);

            tabControl1.SelectedTab = tabTrainingRaw;
            grdDayNotes.AutoResizeColumns();
            grdTrainings.AutoResizeColumns();
        }

        private void btnFetchTrainings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This operation will take some time to complete, about 1 second per row. Please click OK and let the program work uninterrupted.");
            _controller.FetchTrainings();
            tabControl1.SelectedTab = tabTraining;
        }
    }
}