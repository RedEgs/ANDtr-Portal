using System.Text.RegularExpressions;
using ANDtr.Models;
using ClosedXML.Excel;

namespace ANDtr.Data;

public static class DbSeeder
{
    // Fills the Products table from the spreadsheet - but only if the table is empty,
    // so it runs once and doesn't add duplicates every time the app starts.
    public static void Seed(DatabaseContext db, string xlsxPath)
    {
        if (db.Products.Any())
        {
            return;
        }

        using var workbook = new XLWorkbook(xlsxPath);
        var sheet = workbook.Worksheet(1);

        foreach (var row in sheet.RowsUsed().Skip(1))   // Skip(1) = skip the header row
        {
            db.Products.Add(new Product
            {
                Name      = Clean(row.Cell("A")),   // PRODUCT CODE
                CodeName  = Clean(row.Cell("B")),   // Product Code Name
                RegNum    = Clean(row.Cell("C")),   // Regulation Number
                RecallNum = Clean(row.Cell("D")),   // RECALL_NUMBER
                TradeName = Clean(row.Cell("F")),   // TRADE_NAME (blank for some rows)
                RecallClass = Clean(row.Cell("G")), // RECALL_CLASS
                CenterClass = Clean(row.Cell("H")), // CENTER_CLASS
                PostedInternetDate = Clean(row.Cell("I")),
                TerminationDate = Clean(row.Cell("J")),
                FeiNum = Clean(row.Cell("K")),
                FirmName = Clean(row.Cell("L")),
                RecallReason = Clean(row.Cell("M")),
            });
        }

        db.SaveChanges();   // one INSERT per row, all sent together
    }

    // Some cells have trailing spaces or line breaks - squash them into single spaces
    private static string Clean(IXLCell cell)
    {
        return Regex.Replace(cell.GetString(), @"\s+", " ").Trim();
    }
}
