using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAPSTaskManagerUI
{
    using NAPSTaskExecutor;
    using NAPSTaskManager;

    public partial class Form1 : Form
    {
        private ScheduleCreatorForm scf;
        private TaskManager tm;
        private Timer t;
        private List<Panel> currentTaskList;
        public Form1()
        {
            scf = new ScheduleCreatorForm();
            scf.FormClosed += scf_FormClosed;

            tm = new TaskManager();
            t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Start();
            currentTaskList = new List<Panel>();

            InitializeComponent();
            cmbFileExtension.SelectedItem = cmbFileExtension.Items[0];
        }

        void scf_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (scf.CreatedList.Count == 0)
                lblScheduleType2.Text = "None";
            else
            switch (scf.CreatedScheduleType)
            {
                case ScheduleType.Monthly:
                    lblScheduleType2.Text = "Monthly";
                    break;
                case ScheduleType.Biweekly:
                    lblScheduleType2.Text = "Biweekly";
                    break;
                case ScheduleType.Weekly:
                    lblScheduleType2.Text = "Weekly";
                    break;
                case ScheduleType.Daily:
                default:
                    lblScheduleType2.Text = "Daily";
                    break;
            }
        }

        private Panel CreateNewRow(TaskSchedule sched)
        {
            int newY;
            if (pnlTaskList.Controls.Count > 0)
                newY = pnlTaskList.Controls[pnlTaskList.Controls.Count - 1].Location.Y + pnlTaskList.Height / 10;
            else
                newY = 0;
            Panel newRow = new Panel()
            {
                Location = new Point(0, newY),
                Width = pnlTaskList.Width * 9 / 10,
                Height = pnlTaskList.Height / 10
            };

            Image newImage;
            switch (sched.SStatus)
            {
                case ScheduleStatus.Error:
                    newImage = Properties.Resources.Error.ToBitmap();
                    break;
                case ScheduleStatus.Running:
                    newImage = Properties.Resources.Waiting.ToBitmap();
                    break;
                case ScheduleStatus.Waiting:
                default:
                    newImage = Properties.Resources.Okay.ToBitmap();
                    break;
            }
            newRow.Controls.Add(new Label()
            {
                Image = newImage,
                Size = new Size(newRow.Height, newRow.Height)
            });
            ttpTaskListHint.SetToolTip(newRow.Controls[0], sched.StatusMessage);

            Label newLabelName = new Label()
            {
                Text = sched.Task.TaskPath,
                Location = new Point(newRow.Height, 0),
                Width = newRow.Width / 3 - newRow.Height
            };
            ttpTaskListHint.SetToolTip(newLabelName, sched.Task.TaskPath);
            newRow.Controls.Add(newLabelName);

            Label newLabelLog = new Label()
            {
                Text = sched.LogPath,
                Location = new Point(newRow.Width / 3, 0),
                Width = newRow.Width / 3
            };
            ttpTaskListHint.SetToolTip(newLabelLog, sched.LogPath);
            newRow.Controls.Add(newLabelLog);

            Button newUpdateButton = new Button()
            {
                Text = "Update Schedule",
                Location = new Point(newRow.Width * 2 / 3, 0),
                Width = newRow.Width / 7,
                Height = newRow.Height,
                Tag = sched
            };
            newUpdateButton.Click += (sender2, e2) =>
            {
                TaskSchedule thisSched = newUpdateButton.Tag as TaskSchedule;
                ScheduleCreatorForm newScf = new ScheduleCreatorForm();
                newScf.Text = thisSched.Task.TaskPath + " Schedule Editor";
                newScf.SetSchedule(thisSched.SType, thisSched.Times);
                newScf.FormClosing += (sender3, e3) =>
                {
                    if (e3.CloseReason == CloseReason.None || e3.CloseReason == CloseReason.UserClosing)
                    {
                        if (newScf.CreatedScheduleType != thisSched.SType)
                        {
                            MessageBox.Show(newScf, "Schedule type can't change.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e3.Cancel = true;
                        }
                    }
                };
                newScf.FormClosed += (sender3, e3) =>
                {
                    thisSched.SType = newScf.CreatedScheduleType;
                    thisSched.ClearTimes();
                    foreach (TimeSpan ts2 in newScf.CreatedList)
                        thisSched.AddTime(ts2);
                    newUpdateButton.Tag = thisSched;
                };

                newScf.Show();
            };
            newRow.Controls.Add(newUpdateButton);

            Button newDeleteButton = new Button()
            {
                Text = "Delete",
                Location = new Point(newRow.Width * 5 / 6, 0),
                Width = newUpdateButton.Width,
                Height = newRow.Height
            };
            newDeleteButton.Click += (sender2, e2) =>
            {
                if (newRow.Tag != null)
                {
                    int delIndex = tm.CurrentSchedules.IndexOf(newRow.Tag as TaskSchedule);
                    pnlTaskList.Controls.RemoveAt(delIndex);
                    tm.CurrentSchedules.Remove(newRow.Tag as TaskSchedule);
                }
                ReplaceTaskPanels();
            };
            newRow.Controls.Add(newDeleteButton);
            newRow.BackColor = pnlTaskList.Controls.Count % 2 == 0 ? pnlTaskList.BackColor : Color.White;
            newRow.Tag = sched;

            pnlTaskList.Controls.Add(newRow);

            return newRow;
        }

        void t_Tick(object sender, EventArgs e)
        {
            // update all schedule icons
            foreach (Panel r in pnlTaskList.Controls)
            {
                TaskSchedule ts = r.Tag as TaskSchedule;
                switch (ts.SStatus)
                {
                    case ScheduleStatus.Error:
                        (r.Controls[0] as Label).Image = Properties.Resources.Error.ToBitmap();
                        break;
                    case ScheduleStatus.Running:
                        (r.Controls[0] as Label).Image = Properties.Resources.Waiting.ToBitmap();
                        break;
                    case ScheduleStatus.Waiting:
                    default:
                        (r.Controls[0] as Label).Image = Properties.Resources.Okay.ToBitmap();
                        break;
                }
                ttpTaskListHint.SetToolTip(r.Controls[0] as Control, ts.StatusMessage);
            }
        }

        private void ReplaceTaskPanels()
        {
            int expectedY = 0;
            for (int i = 0; i < pnlTaskList.Controls.Count; i++)
            {
                TaskSchedule ts = pnlTaskList.Controls[i].Controls[3].Tag as TaskSchedule;
                Image newImage;
                switch (ts.SStatus)
                {
                    case ScheduleStatus.Error:
                        newImage = Properties.Resources.Error.ToBitmap();
                        break;
                    case ScheduleStatus.Running:
                        newImage = Properties.Resources.Waiting.ToBitmap();
                        break;
                    case ScheduleStatus.Waiting:
                    default:
                        newImage = Properties.Resources.Okay.ToBitmap();
                        break;
                }
                (pnlTaskList.Controls[i].Controls[0] as Label).Image = newImage;
                ttpTaskListHint.SetToolTip(pnlTaskList.Controls[i].Controls[0], ts.StatusMessage);
                pnlTaskList.Controls[i].BackColor = i % 2 == 0 ? pnlTaskList.BackColor : Color.White;
                pnlTaskList.Controls[i].Tag = i;
                pnlTaskList.Controls[i].Location = new Point(0, expectedY);
                expectedY += pnlTaskList.Height / 10;
            }
        }

        void btnCreateNewTask_Click(object sender, EventArgs e)
        {
            if (scf.CreatedList.Count > 0)
            {
                TaskExecutor newExe = null;
                switch ((string)cmbFileExtension.SelectedItem)
                {
                    case ".ps1":
                        newExe = PowershellTaskExecutor.NewTask(txtFilePath.Text, txtParameters.Text.Split(' '));
                        break;
                    case ".bat":
                        newExe = TaskExecutor.NewTask(txtFilePath.Text, txtParameters.Text.Split(' '));
                        break;
                }
                if (newExe == null)
                    MessageBox.Show(this, "Could not interpret file extension " + (string)cmbFileExtension.SelectedItem + ".");
                else
                {
                    tm.AddSchedule(newExe, txtLogPath.Text + ".log", scf.CreatedScheduleType, scf.CreatedList.ToArray());
                    CreateNewRow(tm.CurrentSchedules.Last());
                }
            }
            else
                tm.AddTask(txtFilePath.Text, (string)cmbFileExtension.SelectedItem, txtLogPath.Text + ".log", txtParameters.Text.Split(' '));
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            tm.KillAll();
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            if (scf.IsDisposed)
            {
                var tmpTimes = scf.CreatedList;
                var tmpType = scf.CreatedScheduleType;

                scf = new ScheduleCreatorForm();
                scf.SetSchedule(tmpType, tmpTimes);
                scf.FormClosed += scf_FormClosed;
            }
            scf.Show(this);
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            scf.CreatedList.Clear();
            scf_FormClosed(sender, null);
        }

        private void pnlTaskList_Resize(object sender, EventArgs e)
        {
            int expectedY = 0;
            foreach (Control pnl in pnlTaskList.Controls)
            {
                pnl.Width = pnlTaskList.Width;
                pnl.Height = pnlTaskList.Height / 10;
                pnl.Location = new Point(pnl.Location.X, expectedY);
                expectedY += pnlTaskList.Height / 10;

                pnl.Controls[1].Location = new Point(pnl.Controls[0].Size.Width, 0);
                pnl.Controls[2].Location = new Point(pnl.Width / 3, 0);     // log label
                pnl.Controls[3].Location = new Point(pnl.Width * 2 / 3, 0); // update schedule button
                pnl.Controls[4].Location = new Point(pnl.Width * 5 / 6, 0); // delete button

                pnl.Controls[1].Width = pnl.Width / 3 - pnl.Controls[0].Width;
                pnl.Controls[2].Width = pnl.Width / 3;
                pnl.Controls[3].Width = pnl.Controls[4].Width = pnl.Width / 7;
                pnl.Controls[3].Height = pnl.Controls[4].Height = pnl.Height;
            }
        }
    }
}
