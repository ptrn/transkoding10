//  MiroVideoConverter -- a super simple way to convert almost any video to MP4, 
//  Ogg Theora, or a specific phone or iPod.
//
//  Copyright 2010 Participatory Culture Foundation
//
//  This file is part of MiroVideoConverter.
//
//  MiroVideoConverter is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  MiroVideoConverter is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with MiroVideoConverter.  If not, see http://www.gnu.org/licenses/.

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mirosubs.Converter.Windows.Process;
using System.IO;


namespace Mirosubs.Converter.Windows.ConversionFormats
{
    /**
     * Ogg (Theora+Vorbis)
     */
    class DifiTheora : ConversionFormat
    {
        public readonly static DifiTheora Theora =
            new DifiTheora("Theora", "theora");
        private DifiTheora(string displayName, string filePart)
            : base(displayName, filePart, "ogv", VideoFormatGroup.Difi)
        {
        }
        public override string GetArguments(string inputFileName, string outputFileName)
        {
            VideoParameters parms =
                VideoParameterOracle.GetParameters(inputFileName);
            if (parms == null)
                return GetSimpleArguments(inputFileName, outputFileName);
            else
            {
                StringBuilder paramsBuilder = new StringBuilder();
                StringWriter paramsWriter = new StringWriter(paramsBuilder);
                if (parms.Height.HasValue && parms.Width.HasValue)
                    paramsWriter.Write("-x {0} -y {1} ",
                        parms.Width, parms.Height);
                if (parms.VideoBitrate.HasValue && parms.AudioBitrate.HasValue)
                    paramsWriter.Write("-V {0} -A {1} --two-pass ",
                        parms.VideoBitrate, parms.AudioBitrate);
                else
                    paramsWriter.Write("--videoquality 8 --audioquality 6 ");
                paramsWriter.Close();
                return string.Format(
                    "\"{0}\" -o \"{1}\" {2} --frontend",
                        inputFileName, outputFileName, paramsBuilder.ToString());
            }
        }
        public string GetSimpleArguments(string inputFileName, string outputFileName)
        {
            return string.Format(
                   "\"{0}\" -o \"{1}\" --videoquality 8 --audioquality 6 --frontend",
                   inputFileName, outputFileName);
        }
        public override IVideoConverter MakeConverter(string fileName)
        {
            return new F2TVideoConverter(fileName);
        }
        public override int Order
        {
            get
            {
                return 0;
            }
        }
    }

    /**
     * MP4 (h.264+ACC)
     */
    class DifiMP4 : ConversionFormat
    {
        public readonly static ConversionFormat MP4 = new DifiMP4();

        private DifiMP4()
            : base("MP4 Video", "mp4video", "mp4", VideoFormatGroup.Difi)
        {
        }
        public override string GetArguments(string inputFileName, string outputFileName)
        {
            return string.Format("-i \"{0}\" -f mp4 -y -vcodec mpeg4 -sameq -r 20 \"{1}\"",
                inputFileName, outputFileName);
        }
        public override IVideoConverter MakeConverter(string fileName)
        {
            return new FFMPEGVideoConverter(fileName, this);
        }
        public override int Order
        {
            get
            {
                return 1;
            }
        }
    }

    /**
     * MP3
     * Problemer:
     *  konvertering fra MP4(h.264+AAC) gir feilmeldiger, se mer her:
     *  http://bit.ly/dvQx9N 
     */
    class DifiMP3 : ConversionFormat
    {
        public readonly static ConversionFormat MP3 =
            new DifiMP3();

        private DifiMP3()
            : base("MP3 (Audio Only)", "audioonly", "mp3", VideoFormatGroup.Difi)
        {
        }
        public override string GetArguments(string inputFileName, string outputFileName)
        {
            return string.Format("-i \"{0}\" -f mp3 -y \"{1}\"",
                inputFileName, outputFileName);
        }
        public override IVideoConverter MakeConverter(string fileName)
        {
            return new FFMPEGVideoConverter(fileName, this);
        }
        public override int Order
        {
            get
            {
                return 2;
            }
        }
    }

    /**
     * Ogg (Vorbis)
     */
    class DifiVorbis : ConversionFormat
    {
        public readonly static DifiVorbis Vorbis =
            new DifiVorbis("Vorbis", "vorbis");
        private DifiVorbis(string displayName, string filePart)
            : base(displayName, filePart, "ogg", VideoFormatGroup.Difi)
        {
        }
        public override string GetArguments(string inputFileName, string outputFileName)
        {
            VideoParameters parms =
                VideoParameterOracle.GetParameters(inputFileName);
            if (parms == null)
                return GetSimpleArguments(inputFileName, outputFileName);
            else
            {
                StringBuilder paramsBuilder = new StringBuilder();
                StringWriter paramsWriter = new StringWriter(paramsBuilder);
                paramsWriter.Write("--audioquality 6");
                paramsWriter.Write("--novideo");

                paramsWriter.Close();
                return string.Format(
                    "\"{0}\" -o \"{1}\" {2} --frontend",
                        inputFileName, outputFileName, paramsBuilder.ToString());
            }
        }
        public string GetSimpleArguments(string inputFileName, string outputFileName)
        {
            return string.Format(
                   "\"{0}\" -o \"{1}\" --novideo --audioquality 6 --frontend",
                   inputFileName, outputFileName);
        }
        public override IVideoConverter MakeConverter(string fileName)
        {
            return new F2TVideoConverter(fileName);
        }
        public override int Order
        {
            get
            {
                return 3;
            }
        }
    }
}