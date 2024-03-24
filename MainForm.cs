using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCefSharp
{
    public partial class mainForm : Form
    {
        public ChromiumWebBrowser _chrome = null;
        CefSettings settings = null;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            InitializeCefSharp();
        }

        void InitializeCefSharp()
        {
            try
            {
                settings = new CefSettings();
                settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
                //Cef.Initialize(settings);

                //웹 사이트 이동
                _chrome = new ChromiumWebBrowser("https://www.google.com.vn");
                //한국어 설정
                //_chrome.BrowserSettings.AcceptLanguageList = "en-us";
                //Main Form에 CefSharp컨트롤 추가
                this.Controls.Add(_chrome);
                //Main Form 전체 영역에 붙이기
                _chrome.Dock = DockStyle.Fill;
                //페이지 로딩 완료 이벤트
                //_chrome.LoadingStateChanged += OnLoadingStateChanged;
                //_chrome.DownloadHandler = VDIDownloadHandlerBUL.GetInstance(ShowMessageErrorDownload);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
