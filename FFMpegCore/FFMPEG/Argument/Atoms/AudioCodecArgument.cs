﻿using FFMpegCore.FFMPEG.Enums;

namespace FFMpegCore.FFMPEG.Argument
{
    /// <summary>
    /// Represents parameter of audio codec and it's quality
    /// </summary>
    public class AudioCodecArgument : Argument<AudioCodec>
    {
        public AudioCodecArgument(AudioCodec value) : base(value) { }

        /// <inheritdoc/>
        public override string GetStringValue()
        {
            return $"-c:a {Value.ToString().ToLower()}";
        }
    }
}