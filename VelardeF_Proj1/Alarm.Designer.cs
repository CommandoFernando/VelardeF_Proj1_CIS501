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
            this.ux_Snooze = new System.Windows.Forms.Button();
            this.ux_Set = new System.Windows.Forms.Button();
            this.ux_On = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ux_TimePicker
            // 
            this.ux_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ux_TimePicker.Location = new System.Drawing.Point(12, 37);
            this.ux_TimePicker.Name = "ux_TimePicker";
            this.ux_TimePicker.Size = new System.Drawing.Size(286, 26);
            this.ux_TimePicker.TabIndex = 0;
            // 
            // ux_Snooze
            // 
            this.ux_Snooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Snooze.Location = new System.Drawing.Point(12, 69);
            this.ux_Snooze.Name = "ux_Snooze";
            this.ux_Snooze.Size = new System.Drawing.Size(100, 50);
            this.ux_Snooze.TabIndex = 1;
            this.ux_Snooze.Text = "Snooze";
            this.ux_Snooze.UseVisualStyleBackColor = true;
            // 
            // ux_Set
            // 
            this.ux_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Set.Location = new System.Drawing.Point(252, 69);
            this.ux_Set.Name = "ux_Set";
            this.ux_Set.Size = new System.Drawing.Size(100, 50);
            this.ux_Set.TabIndex = 2;
            this.ux_Set.Text = "Set";
            this.ux_Set.UseVisualStyleBackColor = true;
            // 
            // ux_On
            // 
            this.ux_On.AutoSize = true;
            this.ux_On.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_On.Location = new System.Drawing.Point(304, 37);
            this.ux_On.Name = "ux_On";
            this.ux_On.Size = new System.Drawing.Size(48, 24);
            this.ux_On.TabIndex = 3;
            this.ux_On.TabStop = true;
            this.ux_On.Text = "On";
            this.ux_On.UseVisualStyleBackColor = true;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 128);
            this.Controls.Add(this.ux_On);
            this.Controls.Add(this.ux_Set);
            this.Controls.Add(this.ux_Snooze);
            this.Controls.Add(this.ux_TimePicker);
            this.Name = "Alarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ux_TimePicker;
        private System.Windows.Forms.Button ux_Snooze;
        private System.Windows.Forms.Button ux_Set;
        private System.Windows.Forms.RadioButton ux_On;
    }
}