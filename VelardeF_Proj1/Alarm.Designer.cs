namespace VelardeF_Proj1
{
    partial class Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ux_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ux_Cancel = new System.Windows.Forms.Button();
            this.ux_Set = new System.Windows.Forms.Button();
            this.ux_On = new System.Windows.Forms.RadioButton();
            this.ux_off = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ux_TimePicker
            // 
            this.ux_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ux_TimePicker.Location = new System.Drawing.Point(18, 57);
            this.ux_TimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ux_TimePicker.Name = "ux_TimePicker";
            this.ux_TimePicker.Size = new System.Drawing.Size(427, 35);
            this.ux_TimePicker.TabIndex = 0;
            // 
            // ux_Cancel
            // 
            this.ux_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Cancel.Location = new System.Drawing.Point(18, 152);
            this.ux_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ux_Cancel.Name = "ux_Cancel";
            this.ux_Cancel.Size = new System.Drawing.Size(150, 77);
            this.ux_Cancel.TabIndex = 1;
            this.ux_Cancel.Text = "Cancel";
            this.ux_Cancel.UseVisualStyleBackColor = true;
            this.ux_Cancel.Click += new System.EventHandler(this.ux_Snooze_Click);
            // 
            // ux_Set
            // 
            this.ux_Set.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ux_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Set.Location = new System.Drawing.Point(444, 152);
            this.ux_Set.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ux_Set.Name = "ux_Set";
            this.ux_Set.Size = new System.Drawing.Size(150, 77);
            this.ux_Set.TabIndex = 2;
            this.ux_Set.Text = "Set";
            this.ux_Set.UseVisualStyleBackColor = true;
            this.ux_Set.Click += new System.EventHandler(this.ux_Set_Click);
            // 
            // ux_On
            // 
            this.ux_On.AutoSize = true;
            this.ux_On.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_On.Location = new System.Drawing.Point(463, 30);
            this.ux_On.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ux_On.Name = "ux_On";
            this.ux_On.Size = new System.Drawing.Size(70, 33);
            this.ux_On.TabIndex = 3;
            this.ux_On.TabStop = true;
            this.ux_On.Text = "On";
            this.ux_On.UseVisualStyleBackColor = true;
            this.ux_On.CheckedChanged += new System.EventHandler(this.ux_On_CheckedChanged);
            // 
            // ux_off
            // 
            this.ux_off.AutoSize = true;
            this.ux_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_off.Location = new System.Drawing.Point(463, 71);
            this.ux_off.Name = "ux_off";
            this.ux_off.Size = new System.Drawing.Size(69, 33);
            this.ux_off.TabIndex = 4;
            this.ux_off.TabStop = true;
            this.ux_off.Text = "Off";
            this.ux_off.UseVisualStyleBackColor = true;
            this.ux_off.CheckedChanged += new System.EventHandler(this.ux_off_CheckedChanged);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 243);
            this.Controls.Add(this.ux_off);
            this.Controls.Add(this.ux_On);
            this.Controls.Add(this.ux_Set);
            this.Controls.Add(this.ux_Cancel);
            this.Controls.Add(this.ux_TimePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ux_TimePicker;
        private System.Windows.Forms.Button ux_Cancel;
        private System.Windows.Forms.Button ux_Set;
        private System.Windows.Forms.RadioButton ux_On;
        private System.Windows.Forms.RadioButton ux_off;
    }
}