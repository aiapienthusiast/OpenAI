
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format of the generated image.
    /// </summary>
    public enum ImagesResponseOutputFormat
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
    public static class ImagesResponseOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesResponseOutputFormat value)
        {
            return value switch
            {
                ImagesResponseOutputFormat.Gif => "gif",
                ImagesResponseOutputFormat.Jpeg => "jpeg",
                ImagesResponseOutputFormat.Png => "png",
                ImagesResponseOutputFormat.Svg => "svg",
                ImagesResponseOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesResponseOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => ImagesResponseOutputFormat.Gif,
                "jpeg" => ImagesResponseOutputFormat.Jpeg,
                "png" => ImagesResponseOutputFormat.Png,
                "svg" => ImagesResponseOutputFormat.Svg,
                "webp" => ImagesResponseOutputFormat.Webp,
                _ => null,
            };
        }
    }
}