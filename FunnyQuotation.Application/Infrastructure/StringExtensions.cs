using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace FunnyQuotation.Application.Infrastructure
{
    /// <summary>  
    /// Contains all custom written string related Extension Methods.  
    /// </summary>  
    public static class StringExtensions
    {
        /// <summary>  
        /// Removes all accents from the input string.  
        /// </summary>  
        /// <param name="text">The input string.</param>  
        /// <returns></returns>  
        public static string RemoveAccents(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Replace("đ", "d").Replace("Đ", "D");

            text = text.Normalize(NormalizationForm.FormD);
            char[] chars = text
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
                != UnicodeCategory.NonSpacingMark).ToArray();

            return new string(chars).Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Finds the first space starting at the desired length.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string TruncateAtWord(this string value, int length)
        {
            if (value == null || value.Length < length || value.IndexOf(" ", length) == -1)
                return value;

            return value.Substring(0, value.IndexOf(" ", length));
        }

        /// <summary>  
        /// Turn a string into a slug by removing all accents,   
        /// special characters, additional spaces, substituting   
        /// spaces with hyphens & making it lower-case.  
        /// </summary>  
        /// <param name="phrase">The string to turn into a slug.</param>  
        /// <returns></returns>  
        public static string Slugify(this string phrase)
        {

            // Remove all accents and make the string lower case.  
            string output = phrase.TruncateAtWord(100).RemoveAccents().ToLower();

            // Remove all special characters from the string.  
            output = Regex.Replace(output, @"[^A-Za-z0-9\s-]", "");

            // Remove all additional spaces in favour of just one.  
            output = Regex.Replace(output, @"\s+", " ").Trim();

            // Replace all spaces with the hyphen.  
            output = Regex.Replace(output, @"\s", "-");

            // Return the slug.  
            return output;
        }

        /// <summary>
        /// Remove all HTML tags from a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, "<.*?>", " ");
        }
    }
}
