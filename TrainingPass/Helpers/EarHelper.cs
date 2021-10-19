using CoreAudio;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingPass.Helpers
{
	public class EarHelper
	{
		private MMDevice _sndDevice;

		public async Task<int> Listen()
		{
			var sndDevEnum = new MMDeviceEnumerator();
			_sndDevice = Properties.Settings.Default.AudioDevice != ""
				? sndDevEnum.GetDevice(Properties.Settings.Default.AudioDevice)
				: sndDevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
			Func<int> courseFinished = ListenTimerTick;

			return courseFinished();
		}

		private int ListenTimerTick()
		{
			var currentVolumnLevel = (int)(_sndDevice.AudioMeterInformation.MasterPeakValue * 100);

			return currentVolumnLevel;
		}

		public List<Tuple<string, string>> GetAllAudioDevices()
		{
			List<Tuple<string, string>> audioDevices = new List<Tuple<string, string>>();
			audioDevices.Add(new Tuple<string, string>("Default", ""));

			try
			{
				MMDeviceEnumerator sndDevEnum = new MMDeviceEnumerator();
				MMDeviceCollection audioCollection = sndDevEnum.EnumerateAudioEndPoints(EDataFlow.eRender, CoreAudio.DEVICE_STATE.DEVICE_STATEMASK_ALL);

				for (int i = 0; i < audioCollection.Count; ++i)
				{
					MMDevice device = audioCollection[i];
					audioDevices.Add(new Tuple<string, string>(device.FriendlyName, device.ID));
				}
			}
			catch
			{
				throw;
			}

			return audioDevices;
		}
	}
}
