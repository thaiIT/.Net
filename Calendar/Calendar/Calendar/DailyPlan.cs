﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }
        public DateTime Date { get => date; set => date = value; }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);
            dtpkDate.Value = Date;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }
        List<PlanItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleteed;

            fPanel.Controls.Add(aJob);
        }

        void aJob_Deleteed(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        void aJob_Edited(object sender, EventArgs e)
        {
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPrevioursDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsiToDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };
            Job.Job.Add(item);
            AddJob(item);
        }
    }
}
