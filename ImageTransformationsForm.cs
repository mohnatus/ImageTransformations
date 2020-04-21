using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTransformationsApp
{
    public partial class ImageTransformationsForm : Form
    {
        private string _file;
        private Stopwatch _stopwatch;

        public ImageTransformationsForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            string file = OpenFile();
            if (file != null)
            {
                this.FileTextBox.Text = file;

                _file = file;
            }
        }

        public static string OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;

            if (dlg.ShowDialog() == DialogResult.OK)
                return dlg.FileName;

            return null;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (_file == null)
                return;

            DisposePreviousImage();

            RotationImageTransformation rotation =
              new RotationImageTransformation((double)this.AngleNumericUpDown.Value);
            StretchImageTransformation stretch =
              new StretchImageTransformation(
                (double)this.HorizStretchNumericUpDown.Value / 100,
                (double)this.VertStretchNumericUpDown.Value / 100);
            FlipImageTransformation flip =
              new FlipImageTransformation(this.FlipHorizontalCheckBox.Checked, this.FlipVerticalCheckBox.Checked);

            DensityImageTransformation density =
              new DensityImageTransformation(
                (double)this.AlphaNumericUpDown.Value / 100,
                (double)this.RedNumericUpDown.Value / 100,
                (double)this.GreenNumericUpDown.Value / 100,
                (double)this.BlueNumericUpDown.Value / 100
              );

            StartStopwatch();
            var bmp = ImageTransformer.Apply(_file,
              new IImageTransformation[] { rotation, stretch, flip, density });
            StopStopwatch();

            this.ImagePictureBox.Image = bmp;
        }

        private void StartStopwatch()
        {
            if (_stopwatch == null)
                _stopwatch = new Stopwatch();
            else
                _stopwatch.Reset();

            _stopwatch.Start();
        }


        private void StopStopwatch()
        {
            _stopwatch.Stop();
            this.ExecutionTimeLabel.Text = $"Total execution time is {_stopwatch.ElapsedMilliseconds} milliseconds";
        }

        private void DisposePreviousImage()
        {
            if (this.ImagePictureBox.Image != null)
            {
                var tmpImg = this.ImagePictureBox.Image;
                this.ImagePictureBox.Image = null;
                tmpImg.Dispose();
            }
        }
    }
}
