/* Alarm.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Timers;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VelardeF_Proj1
{
    /// <summary>
    /// An instance of an Alarm Object
    /// </summary>
    public partial class Alarm : Form
    {
        /// <summary>
        /// Tells whether the Alarm is on
        /// </summary>
        public bool On = false;
        /// <summary>
        /// The Time the alarm will ring
        /// </summary>
        public DateTime TimeToRing;
        /// <summary>
        /// The Alarm clock
        /// </summary>
        public System.Timers.Timer clock = new System.Timers.Timer
        {
            Interval = 1000
        };
        /// <summary>
        /// Event Handler for alarm
        /// </summary>
        public EventHandler AlarmEventHandler;

        /// <summary>
        /// Alarm Constructor
        /// </summary>
        public Alarm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Alarm constructor overload that takes a string of the time
        /// </summary>
        /// <param name="s"></param>
        public Alarm(string s)
        {
            this.TimeToRing = Convert.ToDateTime(s);
        }

        void GoOff(object sender, ElapsedEventArgs e)
        {
            if (On && DateTime.Now >= TimeToRing)
            {
                On = false;
                OnRing();
                SystemSounds.Beep.Play();
                MessageBox.Show("ALARM!");
                clock.Stop();
            }
        }
        private void OnRing()
        {
            AlarmEventHandler?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// Event listener
        /// </summary>
        public event EventHandler Ring
        {
            add { AlarmEventHandler += value; }
            remove { AlarmEventHandler -= value; }
        }

        private void ux_Snooze_Click(object sender, EventArgs e)
        {
            //this.TimeToRing.AddSeconds(30);
            //ux_TimePicker.Value.AddMinutes(5);
        }

        private void ux_Set_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// sets the alarm time
        /// </summary>
        public void SetAlarmTime()
        {
            this.TimeToRing = ux_TimePicker.Value;
            if (ux_On.Checked == true)
            {
                StartAlarm();
            }
        }

        /// <summary>
        /// Starts the alarm clock
        /// </summary>
        public void StartAlarm()
        {
            this.clock.Elapsed += GoOff;
            this.clock.Start();
        }
        /// <summary>
        /// Stops the Alarm
        /// </summary>
        public void StopAlarm()
        {
            this.clock.Stop();
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>String with time of alarm</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.TimeToRing.ToString("hh:mm tt"));
            if (On)
            {
                sb.Append(" On");
            }
            else { sb.Append(" Off"); }

            return sb.ToString();
        }

        private void ux_On_CheckedChanged(object sender, EventArgs e)
        {
            ux_On.Checked = !ux_off.Checked;
        }

        private void ux_off_CheckedChanged(object sender, EventArgs e)
        {
            ux_off.Checked = !ux_On.Checked;
        }
    }
}
