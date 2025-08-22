using System.Text;

namespace PointsBetStringFormatterProject.Extensions
{
    public static class StringFormatter
    {
        /// <summary>
        /// Formats string list into CSV format (with spaces and optional quotes) around items.
        /// </summary>
        /// <param name="items">list of string items that will be concatenated by comma.</param>
        /// <param name="addQuotes">optional bool to surround each item with quotes.</param>
        /// <returns></returns>
        public static string ToCommaSeparatedList(this List<string> items, bool addQuotes = false)
        {
            // If there are no items return an empty string.
            if (items.Count == 0)
            {
                return string.Empty;
            }

            var query = new StringBuilder();
            for (var i = 0; i < items.Count; i++)
            {
                // For next item in list prepend comma. Also avoid adding comma on first item.
                if (i > 0)
                {
                    // unsure of requirements with the space, will need to confirm
                    query.Append(", ");
                }

                // handle quotes and append to string builder
                query.Append(addQuotes ? $"\"{items[i]}\"" : items[i]);
            }

            return query.ToString();
        }
    }
}
