using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        #region properties
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }
        private string filePath = "data.xml";
        public string FilePath { get => filePath; set => filePath = value; }
        private List<string> dateOfWeekCalender = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
            try
            {
                Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch
            {
                Job = new PlanData();
                Job.Job = new List<PlanItem>();
                //SetDefaultJob();
            }
        }
        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thu nghiem thoi 1",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thu nghiem thoi 2",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayofColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.dataButtonWidth;
                    btn.Height = Cons.dateButtonHeight;
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += btn_Click;
                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;

            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                string dayString = useDate.DayOfWeek.ToString();
                int column = dateOfWeekCalender.IndexOf(dayString);
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);

            }
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            object test = data;
            sr.Serialize(fs, data);
            fs.Close();
        }
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch
            {
                fs.Close();
                throw new NotImplementedException();
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, FilePath);
        }
    }
}