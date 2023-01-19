using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;

namespace CloudBarTask.Infrastructure.Services
{
    public class GoogleSpreedSheetsReader
    {
        public SheetsService Service { get; set; }
        const string APPLICATION_NAME = "CloudBarTask";
        const string SPREADSHEET_ID = "194QvVv5Xb-PWuv_5ZGg7lC3nixvg-QiTSKrnntArl4A";
        const string SHEET_NAME = "CloubBarData";
        SpreadsheetsResource.ValuesResource _googleSheetValues;
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        public GoogleSpreedSheetsReader()
        {
            InitializeService();
            _googleSheetValues = Service.Spreadsheets.Values;
        }
        public IList<IList<object>> ReadSheetData()
        {
            var range = $"{SHEET_NAME}!A:E";
            var request = _googleSheetValues.Get(SPREADSHEET_ID, range);
            var response = request.Execute();
            return response.Values;
        }
        private void InitializeService()
        {
            var credential = GetCredentialsFromFile();
            Service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = APPLICATION_NAME
            });
        }

        private GoogleCredential GetCredentialsFromFile()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            return credential;
        }
    }
}