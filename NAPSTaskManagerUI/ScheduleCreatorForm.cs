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
    using NAPSTaskManager;
    public partial class ScheduleCreatorForm : Form
    {
        public List<TimeSpan> CreatedList { get; internal set; }
        public ScheduleType CreatedScheduleType { get; internal set; }

        private List<TimeSpan> dailyTs,
                               weeklyTs,
                               biweeklyTs,
                               monthlyTs;
        public ScheduleCreatorForm()
        {
            InitializeComponent();
            cmbWeeklyScheduleDay.SelectedItem = cmbWeeklyScheduleDay.Items[0];
            cmbBiweeklyDay.SelectedItem = cmbBiweeklyDay.Items[0];
            cmbBiweeklyWeek.SelectedItem = cmbBiweeklyWeek.Items[0];

            CreatedList = new List<TimeSpan>();
            CreatedScheduleType = ScheduleType.Daily;

            dailyTs = new List<TimeSpan>();
            weeklyTs = new List<TimeSpan>();
            biweeklyTs = new List<TimeSpan>();
            monthlyTs = new List<TimeSpan>();
        }

        private string[] Days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private void UpdateView(ScheduleType? st = null)
        {
            listDailySchedule.Items.Clear();
            listWeeklySchedule.Items.Clear();
            listBiweeklySchedule.Items.Clear();
            listMonthlySchedule.Items.Clear();

            if (st == null || st.GetValueOrDefault() == ScheduleType.Daily)
            {
                for (int i = 0; i < dailyTs.Count; i++)
                {
                    listDailySchedule.Items.Add(new ListViewItem(
                        new[] 
                        {
                            dailyTs[i].Hours.ToString("00"),
                            dailyTs[i].Minutes.ToString("00")
                        })
                        {
                            Tag = dailyTs[i]
                        });
                }
            }

            if (st == null || st.GetValueOrDefault() == ScheduleType.Weekly)
            {
                for (int i = 0; i < weeklyTs.Count; i++)
                {
                    listWeeklySchedule.Items.Add(new ListViewItem(
                        new[]
                        {
                            Days[weeklyTs[i].Days],
                            weeklyTs[i].Hours.ToString("00"),
                            weeklyTs[i].Minutes.ToString("00")
                        })
                        {
                            Tag = weeklyTs[i]
                        });
                }
            }

            if (st == null || st.GetValueOrDefault() == ScheduleType.Biweekly)
            {
                for (int i = 0; i < biweeklyTs.Count; i++)
                {
                    string spanWeek = "First ";
                    int spanDays = biweeklyTs[i].Days;
                    if (spanDays >= 7)
                    {
                        spanWeek = "Second ";
                        spanDays -= 7;
                    }
                    listBiweeklySchedule.Items.Add(new ListViewItem(
                        new[]
                        {
                            spanWeek,
                            Days[spanDays],
                            biweeklyTs[i].Hours.ToString("00"),
                            biweeklyTs[i].Minutes.ToString("00")
                        })
                        {
                            Tag = biweeklyTs[i]
                        });
                }
            }

            if (st == null || st.GetValueOrDefault() == ScheduleType.Monthly)
            {
                for (int i = 0; i < monthlyTs.Count; i++)
                {
                    listMonthlySchedule.Items.Add(new ListViewItem(
                        new[]
                        {
                            "Day " + (monthlyTs[i].Days + 1).ToString(),
                            monthlyTs[i].Hours.ToString("00"),
                            monthlyTs[i].Minutes.ToString("00")
                        })
                        {
                            Tag = monthlyTs[i]
                        });
                }
            }
        }

        internal void SetSchedule(ScheduleType type, List<TimeSpan> times)
        {
            switch (type)
            {
                case ScheduleType.Daily:
                    foreach (TimeSpan t in times)
                        dailyTs.Add(t);
                    tbcSchedule.SelectedTab = tabDailySchedule;
                    break;
                case ScheduleType.Weekly:
                    foreach (TimeSpan t in times)
                        weeklyTs.Add(t);
                    tbcSchedule.SelectedTab = tabWeeklySchedule;
                    break;
                case ScheduleType.Biweekly:
                    foreach (TimeSpan t in times)
                        biweeklyTs.Add(t);
                    tbcSchedule.SelectedTab = tabBiweeklySchedule;
                    break;
                case ScheduleType.Monthly:
                    foreach (TimeSpan t in times)
                        monthlyTs.Add(t);
                    tbcSchedule.SelectedTab = tabMonthlySchedule;
                    break;
                default:
                    return;
            }
            CreatedList = new List<TimeSpan>(times);
            CreatedScheduleType = type;
            UpdateView();
        }

        private void btnDailyScheduleAdd_Click(object sender, EventArgs e)
        {
            TimeSpan newTS = new TimeSpan((int)numDailyHour.Value, (int)numDailyMinute.Value, 0);
            int insertIndex = 0;
            while (insertIndex < dailyTs.Count && dailyTs[insertIndex] <= newTS)
            {
                if (dailyTs[insertIndex] == newTS)
                    return;
                else
                    insertIndex++;
            }
            dailyTs.Insert(insertIndex, newTS);
            UpdateView();
        }
        private void btnDailyScheduleRemove_Click(object sender, EventArgs e)
        {
            if (dailyTs.Count == 0)
                return;
            dailyTs.Remove((TimeSpan)listDailySchedule.SelectedItems[0].Tag);
            UpdateView(ScheduleType.Daily);
        }

        private void btnWeeklyScheduleAdd_Click(object sender, EventArgs e)
        {
            if (cmbWeeklyScheduleDay.SelectedItem == null)
            {
                MessageBox.Show(this, "Day must be filled before adding a time.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimeSpan newTS = new TimeSpan(Array.IndexOf(Days, (string)cmbWeeklyScheduleDay.SelectedItem),
                (int)numWeeklyScheduleHour.Value, (int)numWeeklyScheduleMinute.Value, 0);
            int insertIndex = 0;
            while (insertIndex < weeklyTs.Count && weeklyTs[insertIndex] <= newTS)
            {
                if (weeklyTs[insertIndex] == newTS)
                    return;
                else
                    insertIndex++;
            }
            weeklyTs.Insert(insertIndex, newTS);
            UpdateView(ScheduleType.Weekly);
        }
        private void btnWeeklyScheduleRemove_Click(object sender, EventArgs e)
        {
            if (weeklyTs.Count == 0)
                return;
            weeklyTs.Remove((TimeSpan)listWeeklySchedule.SelectedItems[0].Tag);
            UpdateView(ScheduleType.Weekly);
        }

        private void btnBiweeklyAdd_Click(object sender, EventArgs e)
        {
            if (cmbBiweeklyDay.SelectedItem == null || cmbBiweeklyWeek.SelectedItem == null)
            {
                MessageBox.Show(this, "Week and day must be filled before adding a time.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int numDays = Array.IndexOf(Days, cmbBiweeklyDay.SelectedItem);
            if ((string)cmbBiweeklyWeek.SelectedItem == "2")
                numDays += 7;
            TimeSpan newTS = new TimeSpan(numDays,
                (int)numBiweeklyHour.Value, (int)numBiweeklyMinute.Value, 0);
            int insertIndex = 0;
            while (insertIndex < biweeklyTs.Count && biweeklyTs[insertIndex] <= newTS)
            {
                if (biweeklyTs[insertIndex] == newTS)
                    return;
                else
                    insertIndex++;
            }
            biweeklyTs.Insert(insertIndex, newTS);
            UpdateView(ScheduleType.Biweekly);
        }
        private void btnBiweeklyRemove_Click(object sender, EventArgs e)
        {
            if (biweeklyTs.Count == 0)
                return;
            biweeklyTs.Remove((TimeSpan)listBiweeklySchedule.SelectedItems[0].Tag);
            UpdateView(ScheduleType.Biweekly);
        }

        private void btnMonthlyAdd_Click(object sender, EventArgs e)
        {
            TimeSpan newTS = new TimeSpan(((int)numMonthlyDay.Value) - 1,
                (int)numMonthlyHour.Value, (int)numMonthlyMinute.Value, 0);
            int insertIndex = 0;
            while (insertIndex < monthlyTs.Count && monthlyTs[insertIndex] <= newTS)
            {
                if (monthlyTs[insertIndex] == newTS)
                    return;
                else
                    insertIndex++;
            }
            monthlyTs.Insert(insertIndex, newTS);
            UpdateView(ScheduleType.Monthly);
        }
        private void btnMonthlyRemove_Click(object sender, EventArgs e)
        {
            if (monthlyTs.Count == 0)
                return;
            monthlyTs.Remove((TimeSpan)listMonthlySchedule.SelectedItems[0].Tag);
            UpdateView(ScheduleType.Monthly);
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            CreatedList.Clear();
            switch (tbcSchedule.SelectedTab.Name)
            {
                case "tabDailySchedule":
                    foreach (TimeSpan ts in dailyTs)
                        CreatedList.Add(ts);
                    CreatedScheduleType = ScheduleType.Daily;
                    break;
                case "tabWeeklySchedule":
                    foreach (TimeSpan ts in weeklyTs)
                        CreatedList.Add(ts);
                    CreatedScheduleType = ScheduleType.Weekly;
                    break;
                case "tabBiweeklySchedule":
                    foreach (TimeSpan ts in biweeklyTs)
                        CreatedList.Add(ts);
                    CreatedScheduleType = ScheduleType.Biweekly;
                    break;
                case "tabMonthlySchedule":
                    foreach (TimeSpan ts in monthlyTs)
                        CreatedList.Add(ts);
                    CreatedScheduleType = ScheduleType.Monthly;
                    break;
                default:
                    MessageBox.Show("Error saving schedule: Schedule type could not be determined.");
                    break;
            }
            this.Close();
        }

        private void btnCancelSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
