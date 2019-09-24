﻿namespace Cresij_Control_Manager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectorStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurtainStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentralLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodiumLock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ip,
            this.Location,
            this.Status,
            this.WorkStat,
            this.PCStat,
            this.Media,
            this.ProjectorStat,
            this.ProjHour,
            this.ScreenStat,
            this.CurtainStat,
            this.LightStat,
            this.CentralLock,
            this.ClassLock,
            this.PodiumLock,
            this.Timer});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 562);
            this.dataGridView1.TabIndex = 0;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 70;
            // 
            // Status
            // 
            this.Status.HeaderText = "MachineStat";
            this.Status.Name = "Status";
            this.Status.Width = 70;
            // 
            // WorkStat
            // 
            this.WorkStat.HeaderText = "WorkStat";
            this.WorkStat.Name = "WorkStat";
            this.WorkStat.Width = 70;
            // 
            // PCStat
            // 
            this.PCStat.HeaderText = "PcStat";
            this.PCStat.Name = "PCStat";
            this.PCStat.Width = 60;
            // 
            // Media
            // 
            this.Media.HeaderText = "MediaSignal";
            this.Media.Name = "Media";
            this.Media.Width = 80;
            // 
            // ProjectorStat
            // 
            this.ProjectorStat.HeaderText = "ProjectorStat";
            this.ProjectorStat.Name = "ProjectorStat";
            this.ProjectorStat.Width = 70;
            // 
            // ProjHour
            // 
            this.ProjHour.HeaderText = "ProjectorHours";
            this.ProjHour.Name = "ProjHour";
            this.ProjHour.Width = 80;
            // 
            // ScreenStat
            // 
            this.ScreenStat.HeaderText = "ScreenStat";
            this.ScreenStat.Name = "ScreenStat";
            this.ScreenStat.Width = 60;
            // 
            // CurtainStat
            // 
            this.CurtainStat.HeaderText = "CurtainStat";
            this.CurtainStat.Name = "CurtainStat";
            this.CurtainStat.Width = 60;
            // 
            // LightStat
            // 
            this.LightStat.HeaderText = "LightStat";
            this.LightStat.Name = "LightStat";
            this.LightStat.Width = 50;
            // 
            // CentralLock
            // 
            this.CentralLock.HeaderText = "CentralLock";
            this.CentralLock.Name = "CentralLock";
            this.CentralLock.Width = 70;
            // 
            // ClassLock
            // 
            this.ClassLock.HeaderText = "ClassLock";
            this.ClassLock.Name = "ClassLock";
            this.ClassLock.Width = 70;
            // 
            // PodiumLock
            // 
            this.PodiumLock.HeaderText = "PodiumLock";
            this.PodiumLock.Name = "PodiumLock";
            this.PodiumLock.Width = 70;
            // 
            // Timer
            // 
            this.Timer.HeaderText = "TimerService";
            this.Timer.Name = "Timer";
            this.Timer.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Media;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectorStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurtainStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodiumLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
    }
}
