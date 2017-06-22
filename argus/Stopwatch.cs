using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Argus
{
    [JsonConverter(typeof(StopwatchConverter))]
    public class Stopwatch : System.Diagnostics.Stopwatch
    {
        public Stopwatch(TimeSpan offset = default(TimeSpan))
        {
            _offset = offset;
        }
        public TimeSpan _offset;
        public new TimeSpan Elapsed => base.Elapsed + _offset;
        public new long ElapsedMilliseconds => (long)Elapsed.TotalMilliseconds;
        public new long ElapsedTicks => Elapsed.Ticks;
        public List<DateTime> TimestampsStarted = new List<DateTime>();
        public List<DateTime> TimestampsStopped = new List<DateTime>();
        public new void Start()
        {
            base.Start();
            TimestampsStarted.Add(DateTime.Now);
        }
        public new void Stop()
        {
            base.Stop();
            TimestampsStopped.Add(DateTime.Now);
        }
    }

    public class StopwatchConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Stopwatch);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Stopwatch sw = (Stopwatch)value;
            JValue jval = new JValue(sw.ElapsedMilliseconds);
            jval.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long millisecondsElapsed = (long)JValue.Load(reader);
            TimeSpan offset = TimeSpan.FromMilliseconds(millisecondsElapsed);
            return new Stopwatch(offset);
        }
    }
}
