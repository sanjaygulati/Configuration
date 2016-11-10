// <auto-generated />
namespace Microsoft.Extensions.Configuration.Ini
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.Configuration.Ini.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string Error_InvalidFilePath
        {
            get { return GetString("Error_InvalidFilePath"); }
        }

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string FormatError_InvalidFilePath()
        {
            return GetString("Error_InvalidFilePath");
        }

        /// <summary>
        /// A duplicate key '{0}' was found.
        /// </summary>
        internal static string Error_KeyIsDuplicated
        {
            get { return GetString("Error_KeyIsDuplicated"); }
        }

        /// <summary>
        /// A duplicate key '{0}' was found.
        /// </summary>
        internal static string FormatError_KeyIsDuplicated(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_KeyIsDuplicated"), p0);
        }

        /// <summary>
        /// Unrecognized line format: '{0}'.
        /// </summary>
        internal static string Error_UnrecognizedLineFormat
        {
            get { return GetString("Error_UnrecognizedLineFormat"); }
        }

        /// <summary>
        /// Unrecognized line format: '{0}'.
        /// </summary>
        internal static string FormatError_UnrecognizedLineFormat(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_UnrecognizedLineFormat"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
