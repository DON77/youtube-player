using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using NYoutubeDL;

namespace YoutubePlayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer;

        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();
            DownloadURLAudioFile("https://www.youtube.com/watch?v=M7lc1UVf-VE");
            
            ////////string curDir = System.IO.Directory.GetCurrentDirectory();
            //////////this.webBrowser1.Url = new Uri(String.Format("file:///{0}/YoutubePage.html", curDir));
            ////////GenerateYoutubeAudiURL("");
            ////////InitializeChromium();

        }

        private void DownloadURLAudioFile(string s)
        {
            var youtubeDl = new YoutubeDL();
            youtubeDl.Options.FilesystemOptions.Output = s + ".m4a";
            youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.webm;
            youtubeDl.Options.PostProcessingOptions.ExtractAudio = true;
            youtubeDl.VideoUrl = s;
            //youtubeDl.Options.VerbositySimulationOptions.GetUrl = true;
            //System.Diagnostics.Debug.WriteLine(((NYoutubeDL.Models.VideoDownloadInfo)youtubeDl.GetDownloadInfo()).Url);
            youtubeDl.Download();
            
            //((NYoutubeDL.Models.VideoDownloadInfo)youtubeDl.GetDownloadInfo()).Url
            
            //System.Diagnostics.Debug.WriteLine("test");
            //////youtubeDl.GetDownloadInfo().
            //SoundPlayer simpleSound = new SoundPlayer(s + ".m4a");
            //simpleSound.
            //simpleSound.Play();
            
        }

        //public void InitializeChromium()
        //{
        //    CefSettings settings = new CefSettings();
        //    // Initialize cef with the provided settings
        //    Cef.Initialize(settings);
        //    // Create a browser component
        //    string curDir = System.IO.Directory.GetCurrentDirectory();
        //    chromeBrowser = new ChromiumWebBrowser("https://r5---sn-cxxapox-x8os.googlevideo.com/videoplayback?ei=LOT8W6_EE5Oc7QTB3qhw&keepalive=yes&gir=yes&sparams=clen%2Cdur%2Cei%2Cgcr%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Ckeepalive%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cnh%2Cpl%2Crequiressl%2Csource%2Cexpire&lmt=1541858333698695&nh=%2CIgpwcjA0LnN2bzAzKgkxMjcuMC4wLjE&initcwndbps=330000&dur=1343.661&fvip=5&signature=DA5A6269304B5442D2D71BDB0CC20B6D3DF3DF86.9DFC36ABD92D13D4800E873BD025B98E0DA48E2F&clen=19462048&itag=251&c=WEB&key=yt6&ipbits=0&mt=1543300047&txp=5511222&id=o-AAKUAV8VsGAQltJOBboyE8i8ji-EDPpzcaj5nSJvljtc&ms=au%2Crdu&gcr=am&mv=m&expire=1543321740&requiressl=yes&ip=46.70.244.216&mime=audio%2Fwebm&source=youtube&mm=31%2C29&mn=sn-cxxapox-x8os%2Csn-n8v7kn76&pl=21&alr=yes&cpn=PPHMxiVV5TIo9XsR&cver=2.20181117&range=1424322-1862863&rn=12&rbuf=91097");
        //    // Add it to the form and fill it to the form window.
            
        //    chromeBrowser.Dock = DockStyle.Fill;
        //    panel2.Controls.Add(chromeBrowser);
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"https#\www.youtube.com\watch#v=M7lc1UVf-VE.m4a";

            wplayer.controls.play();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"https#\www.youtube.com\watch#v=M7lc1UVf-VE.m4a");

            //player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////// Create the ElementHost control for hosting the
            ////// WPF UserControl.
            ////ElementHost host = new ElementHost();
            ////host.Dock = DockStyle.Fill;

            ////// Create the WPF UserControl.
            ////HostingWpfUserControlInWf.UserControl1 uc =
            ////    new HostingWpfUserControlInWf.UserControl1();

            ////// Assign the WPF UserControl to the ElementHost control's
            ////// Child property.
            ////host.Child = uc;

            ////// Add the ElementHost control to the form's
            ////// collection of child controls.
            ////this.Controls.Add(host);
        }
    }
}
