namespace VelardeF_Proj1
{
    partial class Alarm501
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
            this.ux_EditButton = new System.Windows.Forms.Button();
            this.ux_AddButton = new System.Windows.Forms.Button();
            this.ux_Snooze = new System.Windows.Forms.Button();
            this.ux_Stop = new System.Windows.Forms.Button();
            this.ux_AlarmList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ux_EditButton
            // 
            this.ux_EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_EditButton.Location = new System.Drawing.Point(12, 12);
            this.ux_EditButton.Name = "ux_EditButton";
            this.ux_EditButton.Size = new System.Drawing.Size(100, 50);
            this.ux_EditButton.TabIndex = 0;
            this.ux_EditButton.Text = "Edit";
            this.ux_EditButton.UseVisualStyleBackColor = true;
            // 
            // ux_AddButton
            // 
            this.ux_AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_AddButton.Location = new System.Drawing.Point(153, 12);
            this.ux_AddButton.Name = "ux_AddButton";
            this.ux_AddButton.Size = new System.Drawing.Size(100, 50);
            this.ux_AddButton.TabIndex = 1;
            this.ux_AddButton.Text = "+";
            this.ux_AddButton.UseVisualStyleBackColor = true;
            // 
            // ux_Snooze
            // 
            this.ux_Snooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Snooze.Location = new System.Drawing.Point(12, 361);
            this.ux_Snooze.Name = "ux_Snooze";
            this.ux_Snooze.Size = new System.Drawing.Size(100, 50);
            this.ux_Snooze.TabIndex = 2;
            this.ux_Snooze.Text = "Snooze";
            this.ux_Snooze.UseVisualStyleBackColor = true;
            // 
            // ux_Stop
            // 
            this.ux_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ux_Stop.Location = new System.Drawing.Point(153, 361);
            this.ux_Stop.Name = "ux_Stop";
            this.ux_Stop.Size = new System.Drawing.Size(100, 50);
            this.ux_Stop.TabIndex = 3;
            this.ux_Stop.Text = "Stop";
            this.ux_Stop.UseVisualStyleBackColor = true;
            // 
            // ux_AlarmList
            // 
            this.ux_AlarmList.FormattingEnabled = true;
            this.ux_AlarmList.Location = new System.Drawing.Point(12, 68);
            this.ux_AlarmList.Name = "ux_AlarmList";
            this.ux_AlarmList.Size = new System.Drawing.Size(241, 251);
            this.ux_AlarmList.TabIndex = 4;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 423);
            this.Controls.Add(this.ux_AlarmList);
            this.Controls.Add(this.ux_Stop);
            this.Controls.Add(this.ux_Snooze);
            this.Controls.Add(this.ux_AddButton);
            this.Controls.Add(this.ux_EditButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ux_EditButton;
        private System.Windows.Forms.Button ux_AddButton;
        private System.Windows.Forms.Button ux_Snooze;
        private System.Windows.Forms.Button ux_Stop;
        private System.Windows.Forms.ListBox ux_AlarmList;
    }
}

