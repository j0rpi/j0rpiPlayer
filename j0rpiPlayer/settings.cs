using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INI;

namespace j0rpiPlayer
{
    public partial class settings : Form
    {
        private bool _loadingSettings;
        IniFile config = new IniFile("config.ini");
        public settings()
        {
            _loadingSettings = true;   
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            config.Flush();
            base.OnFormClosing(e);
        }

        private void useDiscordRPC_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingSettings) return;
            config.IniWriteValue("settings", "useDiscordRPC", useDiscordRPC.Checked ? "true" : "false");
            config.Flush();
        }

        private void useFractions_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingSettings) return;
            config.IniWriteValue("settings", "useFractions", useFractions.Checked ? "true" : "false");
            config.Flush();
        }

        private void shuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingSettings) return;
            config.IniWriteValue("settings", "useShuffle", shuffle.Checked ? "true" : "false");
            config.Flush();
        }

        private void autoCheckUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingSettings) return;
            config.IniWriteValue("settings", "autoCheckUpdates", autoCheckUpdates.Checked ? "true" : "false");
            config.Flush();
        }



        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            useFractions.Checked = config.IniReadValue("settings", "useFractions").Equals("true", StringComparison.OrdinalIgnoreCase);
            useDiscordRPC.Checked = config.IniReadValue("settings", "useDiscordRPC").Equals("true", StringComparison.OrdinalIgnoreCase);
            shuffle.Checked = config.IniReadValue("settings", "useShuffle").Equals("true", StringComparison.OrdinalIgnoreCase);
            autoCheckUpdates.Checked = config.IniReadValue("settings", "autoCheckUpdates").Equals("true", StringComparison.OrdinalIgnoreCase);
            _loadingSettings = false;
        }

    }
}
