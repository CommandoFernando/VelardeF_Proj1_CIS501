/* Alarm501.cs
 * Author: Fernando Velarde
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Text;

namespace VelardeF_Proj1
{
    /// <summary>
    /// Alarm UI
    /// </summary>
    public partial class Alarm501 : Form
    {
        //public Alarm alarm;
        /// <summary>
        /// The number of alarms in the list of alarms not sure if it will be used.
        /// </summary>
        public int AlarmCount = 0;
        /// <summary>
        /// The Binding list of alarms
        /// </summary>
        public BindingList<Alarm> ListOfAlarms = new BindingList<Alarm>();

        public object SaveFile { get; private set; }

        /// <summary>
        /// Alarm project constuctor
        /// </summary>
        public Alarm501()
        {
            InitializeComponent();
            ux_AlarmList.DataSource = ListOfAlarms;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read in savefile
        }

        private void ux_AddButton_Click(object sender, EventArgs e)
        {
            ux_EditButton.Enabled = true;
            if (ux_AlarmList.Items.Count < 11)
            {
                ListOfAlarms.AllowNew = true;
                Alarm alarm = new Alarm();
                if (alarm.ShowDialog() == DialogResult.OK)
                {
                    alarm.SetAlarmTime();
                    ListOfAlarms.Add(alarm);
                    ux_Status.Text = "Running";
                }
                else
                {
                    alarm.Close();
                }

            }
            else
            {
                ListOfAlarms.AllowNew = false;
                ux_AddButton.Enabled = false;
            }
        }

        private void ux_Snooze_Click(object sender, EventArgs e)
        {
            foreach (Alarm a in ListOfAlarms)
            {
                if (ux_AlarmList.SelectedItem.Equals(a))
                {
                    a.TimeToRing.AddSeconds(30);
                    ux_Status.Text = "Running";
                }
            }
        }
        /// <summary>
        /// This is where the code for saving the alarms goes.
        /// </summary>
        public void Onclose()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Alarm a in ListOfAlarms)
            {
                sb.Append(a.TimeToRing + "/n");
            }
            File.WriteAllText("SaveFile", sb.ToString());
            //"C:/Users/fvela/source/repos/VelardeF_Proj1/VelardeF_Proj1/SaveFile.txt"
        }
        /// <summary>
        /// Edit button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_EditButton_Click(object sender, EventArgs e)
        {
            ListOfAlarms.Remove((Alarm)ux_AlarmList.SelectedItem);
            Alarm alarmToEdit = new Alarm();
            ListOfAlarms.AllowNew = true;
            //Alarm alarm = new Alarm();
            if (alarmToEdit.ShowDialog() == DialogResult.OK)
            {
                alarmToEdit.SetAlarmTime();
                ListOfAlarms.Add(alarmToEdit);
                ux_Status.Text = "Running";
            }
            else
            {
                alarmToEdit.Close();
            }
        }

        private void ux_Stop_Click(object sender, EventArgs e)
        {
            ux_Status.Text = "Stopped";
            Alarm AlarmToStop = (Alarm)ux_AlarmList.SelectedItem;
            AlarmToStop.StopAlarm();
        }

    }
}
