using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChromeKioskModeDemo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Process _chromeProcess;
		private string _chromeUserDataDirectoryPath;

		private void HandleOpenChromeButton_Click(object sender, EventArgs e)
		{
			if (_chromeProcess != null)
				return;

			var outputScreen = Screen.AllScreens.FirstOrDefault(screen => !screen.Primary);
			if (outputScreen == null)
				return;
			var bounds = outputScreen.Bounds;

			_chromeUserDataDirectoryPath = GetOrCreateChromeUserDataDirectory();
			var processStartInfo = new ProcessStartInfo("chrome.exe")
			{
				Arguments = $"--cast-initial-screen-width={bounds.Width} --cast-initial-screen-height={bounds.Height}"
							+ $" --window-position={bounds.Left},{bounds.Top} --window-size={bounds.Width},{bounds.Height}"
							+ $" --new-window --user-data-dir={_chromeUserDataDirectoryPath} --kiosk http://www.example.com"
			};
			_chromeProcess = Process.Start(processStartInfo);

			_openChromeButton.Enabled = false;
			_closeChromeButton.Enabled = true;
		}

		private void HandleCloseChromeButton_Click(object sender, EventArgs e)
		{
			if (_chromeProcess == null)
				return;
			//
			// The following code for closing Chrome is super-paranoid, usually
			// Chrome closes without problems if you ask it to. But on the other
			// hand I have witnessed all kinds of situations - up to having to kill
			// the process the hard way.
			//
			if (!_chromeProcess.HasExited)
			{
				try
				{
					_chromeProcess.CloseMainWindow();
				}
				catch
				{
					// ignore
				}
			}

			for (var retry = 0; (retry < 5 && !_chromeProcess.HasExited); retry++)
			{
				_chromeProcess.WaitForExit(2000);
			}

			if (!_chromeProcess.HasExited)
			{
				_chromeProcess.Kill();
			}

			_chromeProcess.Dispose();
			_chromeProcess = null;

			_openChromeButton.Enabled = true;
			_closeChromeButton.Enabled = false;
		}

		private string GetOrCreateChromeUserDataDirectory()
		{
			var directoryPath = Path.Combine(Path.GetTempPath(), this.GetType().FullName);
			try
			{
				if (Directory.Exists(directoryPath))
				{
					// Why delete the directory here and now?
					// Reason #1: Let's start fresh.
					// Reason #2: Trying to the delete the directory *after* Chrome closes usually does not work (still locked).
					// Reason #3: Even if we can't clean up completely, we can at least keep the used disk space from growing over time.
					Directory.Delete(directoryPath, true);
				}
			}
			catch
			{
				// Ignore
			}
			Directory.CreateDirectory(directoryPath);
			return directoryPath;
		}
	}
}
