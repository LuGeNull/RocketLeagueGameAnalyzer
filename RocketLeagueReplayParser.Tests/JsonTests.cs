﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLeagueReplayParser.Tests
{
    [TestFixture]
    public class JsonTests
    {
        [TestCaseSource(typeof(ReplayFileSource), nameof(ReplayFileSource.ReplayFiles))]
        public void CreatePrettyJson(string filePath)
        {
            var replay = Replay.Deserialize(filePath);
            var jsonSerializer = new Serializers.JsonSerializer();
            jsonSerializer.Serialize(replay);
        }

        [TestCaseSource(typeof(ReplayFileSource), nameof(ReplayFileSource.ReplayFiles))]
        public void CreateRawJson(string filePath)
        {
            var replay = Replay.Deserialize(filePath);
            var jsonSerializer = new Serializers.JsonSerializer();
            jsonSerializer.SerializeRaw(replay);
        }
    }
}
