﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceUp
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            LoadMaskImages();
            StartCaptureProcess();
        }

        //Обработчики кнопок сайдбара
        private void btnPlayPause_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        //Обработчики смены вкладок


        //Обработчики корректировки
        private void trackBarCorrectionSize_Scroll ( object sender, EventArgs e )
        {
            //MessageBox.Show( activeMaskType.ToString() );
            //mgr.ChangeSize( activeMaskType, trackBarCorrectionSize.Value );

        }

        private void trackBarCorrectionX_Scroll ( object sender, EventArgs e )
        {

        }

        private void trackBarCorrectionY_Scroll ( object sender, EventArgs e )
        {

        }

        //Обработчики меню
        private void openToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void playPauseToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ToggleCaptureProcess();
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }


    }
}
