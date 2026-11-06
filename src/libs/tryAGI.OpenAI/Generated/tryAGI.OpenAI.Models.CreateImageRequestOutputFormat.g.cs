
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Svg,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestOutputFormat value)
        {
            return value switch
            {
                CreateImageRequestOutputFormat.Gif => "gif",
                CreateImageRequestOutputFormat.Jpeg => "jpeg",
                CreateImageRequestOutputFormat.Png => "png",
                CreateImageRequestOutputFormat.Svg => "svg",
                CreateImageRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => CreateImageRequestOutputFormat.Gif,
                "jpeg" => CreateImageRequestOutputFormat.Jpeg,
                "png" => CreateImageRequestOutputFormat.Png,
                "svg" => CreateImageRequestOutputFormat.Svg,
                "webp" => CreateImageRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}