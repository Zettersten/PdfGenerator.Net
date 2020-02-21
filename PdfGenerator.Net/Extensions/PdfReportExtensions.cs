using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Extensions
{
    public static class PdfReportExtensions
    {
        public static string ToFileName(this PdfReportModel report)
        {
            return $"{report.Name} {report.Author} {DateTime.Now.ToShortDateString()}".GenerateSlug() + ".pdf";
        }

        public static int ToMaxColumnCount(this PdfTableModel table)
        {
            var headerCount = 0;
            var footerCount = 0;
            var bodyCount = 0;

            if (table.Header != null && table.Header.Count > 0)
            {
                headerCount = table.Header.Count();
            }

            if (table.Footer != null && table.Footer.Count > 0)
            {
                footerCount = table.Footer.Count();
            }

            if (table.Body != null && table.Body.Count > 0)
            {
                bodyCount = table.Body.Select(x => x.Count).Max();
            }

            return new int[] { headerCount, footerCount, bodyCount }.Max();
        }

        private static string GenerateSlug(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            // invalid chars
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens
            return str;
        }

        private static string RemoveAccent(this string txt)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(txt);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
