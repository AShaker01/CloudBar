1- Project Structure
the project consists of four layers
a) "BarCloudTask":- Windows Forms Project and it uses Telerik UI, this project injects another Layer called "Business" for handling Business Scenarios
b) "BarCloudTask.Business":- All business Services will be created into this layer and will be used by "BarCloudTask" project
c) "BarCloudTask.Database":- This is our database layer and this layer is responsible for handling all required transactions needed by the database, this layer will be used by
BarCloudTask.Business project
d) "BarCloudTask.Infrastructure": This layer represents the integration layer, which will handle the integration with Google Sheets API.

2) Technologies 
I used latest technlogies [.net core 7, WebForms, Telerik UI , DI , EF Core Code First]

3) When running the project it will connect to Google Sheets and read data then insert it into a table called Vendors

4) To change the Sheet go to "CloudBarTask.Infrastructure.Services" GoogleSpreedSheetsReader class and change SPREADSHEET_ID & SHEET_NAME

5) Google Sheet URL :- https://docs.google.com/spreadsheets/d/194QvVv5Xb-PWuv_5ZGg7lC3nixvg-QiTSKrnntArl4A/edit#gid=0