using System.Collections.Generic;

namespace WeatherApp
{
    public static class Dictionaries
    {
        public static Dictionary<string, string> Conditions = new Dictionary<string, string>(new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("clear", "ясно"),
            new KeyValuePair<string, string>("partly-cloudy", "малооблачно"),
            new KeyValuePair<string, string>("cloudy", "облачно с прояснениями"),
            new KeyValuePair<string, string>("overcast ", "пасмурно"),
            new KeyValuePair<string, string>("partly-cloudy-and-light-rain", "небольшой дождь"),
            new KeyValuePair<string, string>("partly-cloudy-and-rain", "дождь"),
            new KeyValuePair<string, string>("overcast-and-rain", "сильный дождь"),
            new KeyValuePair<string, string>("overcast-thunderstorms-with-rain", "сильный дождь, гроза"),
            new KeyValuePair<string, string>("cloudy-and-light-rain", "небольшой дождь"),
            new KeyValuePair<string, string>("overcast-and-light-rain", "небольшой дождь"),
            new KeyValuePair<string, string>("cloudy-and-rain", "дождь"),
            new KeyValuePair<string, string>("overcast-and-wet-snow", "дождь со снегом"),
            new KeyValuePair<string, string>("partly-cloudy-and-light-snow", "небольшой снег"),
            new KeyValuePair<string, string>("partly-cloudy-and-snow", "снег"),
            new KeyValuePair<string, string>("overcast-and-snow", "снегопад"),
            new KeyValuePair<string, string>("cloudy-and-light-snow", "небольшой снег"),
            new KeyValuePair<string, string>("overcast-and-light-snow", "небольшой снег"),
            new KeyValuePair<string, string>("cloudy-and-snow", "снег")
        });

        public static Dictionary<string, string> WindDirection = new Dictionary<string, string>(
            new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("nw", "северо-западное"),
                new KeyValuePair<string, string>("n", "северное"),
                new KeyValuePair<string, string>("ne", "северо-восточное"),
                new KeyValuePair<string, string>("e", "восточное"),
                new KeyValuePair<string, string>("se", "юго-восточное"),
                new KeyValuePair<string, string>("s", "южное"),
                new KeyValuePair<string, string>("sw", "юго-западное"),
                new KeyValuePair<string, string>("w", "западное"),
                new KeyValuePair<string, string>("c", "штиль")
            });

        public static Dictionary<int, string> PrecipitationType = new Dictionary<int, string>(
            new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "без осадков"),
                new KeyValuePair<int, string>(1, "дождь"),
                new KeyValuePair<int, string>(2, "дождь со снегом"),
                new KeyValuePair<int, string>(3, "снег")
            });
    }
}