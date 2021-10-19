using System;
using System.Windows.Forms;
using TrainingPass.Helpers;

namespace TrainingPass
{
	public partial class Form1 : Form
	{
		private Logger logger;
		private EarHelper earHelper;
		private int currentVolume;
		private int clickPointX;
		private int clickPointY;
		public int quiteCycle = 0;

		public Form1()
		{
			InitializeComponent();

			earHelper = new EarHelper();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			logger = new Logger(this);

			FillUIElementsWithStoredSettings();
			FillAudioDevicestoComboBox();

			label5.Text = "";

			timer1.Start();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Properties.Settings.Default.ClickSoundTreshold = trackBar1.Value;
				Properties.Settings.Default.AudioDevice = (string)comboBox1.SelectedValue;
				Properties.Settings.Default.ClickPointX = clickPointX;
				Properties.Settings.Default.ClickPointY = clickPointY;

				Properties.Settings.Default.Save();

				MessageBox.Show("Ayarlar kaydedildi", "TrainingPass", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void FillUIElementsWithStoredSettings()
		{
			try
			{
				logger.Log("Kaydedilmiş ayarlar getiriliyor");
				trackBar1.Value = Properties.Settings.Default.ClickSoundTreshold;
				clickPointX = Properties.Settings.Default.ClickPointX;
				clickPointY = Properties.Settings.Default.ClickPointY;
				textBox1.Text = clickPointX + "," + clickPointY;
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void FillAudioDevicestoComboBox()
		{
			try
			{
				logger.Log("Ses cihazları listeleniyor");
				var audioDevices = earHelper.GetAllAudioDevices();

				comboBox1.Items.Clear();
				comboBox1.DisplayMember = "Item1";
				comboBox1.ValueMember = "Item2";
				comboBox1.DataSource = audioDevices;
				comboBox1.SelectedValue = Properties.Settings.Default.AudioDevice;
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer2.Start();
			groupBox3.Text = "Clicker Aktif";
			logger.Log("Clicker başlatıldı");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer2.Stop();
			groupBox3.Text = "Clicker Beklemede";
			logger.Log("Clicker durduruldu");
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				currentVolume = earHelper.Listen().Result;
				progressBar1.Value = currentVolume;
				label3.Text = "Anlık Ses Seviyesi: " + currentVolume;
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				if (currentVolume <= trackBar1.Value)
					quiteCycle++;
				else
					quiteCycle = 0;

				if(quiteCycle >= 5)
				{
					logger.Log("5 saniyedir ses algılanmadı, tıklama yapılıyor");

					MouseHelper.MoveCursorToPoint(clickPointX, clickPointY);
					MouseHelper.DoMouseClick();

					logger.Log("Tıklama yapıldı");

					quiteCycle = 0;
				}
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			timer3.Start();
			label5.Text = "Koordinat bekleniyor";
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			textBox1.Text = MousePosition.X + "," + MousePosition.Y;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (timer3.Enabled)
				{
					if (e.KeyCode == Keys.ControlKey)
					{
						timer3.Stop();
						timer3.Enabled = false;
						label5.Text = "Koordinat alındı ✅";
						var coordsArray = textBox1.Text.Split(',');
						clickPointX = int.Parse(coordsArray[0]);
						clickPointY = int.Parse(coordsArray[1]);
						logger.Log("Koordinatlar alındı: (" + clickPointX + "," + clickPointY + ")");
					}
				}
			}
			catch (Exception ex)
			{
				logger.ExceptionLog(ex.ToString());
			}
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			label6.Text = trackBar1.Value.ToString();
		}
	}
}
