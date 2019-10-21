using System.Collections.Generic;

namespace WeatherApp
{
    public static class Dictionaries
    {
        public static Dictionary<string, string> Conditions = new Dictionary<string, string>
        {
            {"clear", "ясно"},
            {"partly-cloudy", "малооблачно"},
            {"cloudy", "облачно с прояснениями"},
            {"partly-cloudy", "пасмурно"},
            {"partly-cloudy-and-light-rain", "небольшой дождь"},
            {"partly-cloudy-and-rain", "дождь"},
            {"overcast-and-rain", "сильный дождь"},
            {"overcast-thunderstorms-with-rain", "сильный дождь, гроза"},
            {"cloudy-and-light-rain", "небольшой дождь"},
            {"overcast-and-light-rain", "небольшой дождь"},
            {"cloudy-and-rain", "дождь"},
            {"overcast-and-wet-snow", "дождь со снегом"},
            {"partly-cloudy-and-light-snow", "небольшой снег"},
            {"partly-cloudy-and-snow", "снег"},
            {"overcast-and-snow", "снегопад"},
            {"cloudy-and-light-snow", "небольшой снег"},
            {"overcast-and-light-snow", "небольшой снег"},
            {"cloudy-and-snow", "снег"}
        };
        public static Dictionary<string, string> WindDirection = new Dictionary<string, string>
        {
            {"nw", "северо-западное"},
            {"n", "северное"},
            {"ne", "северо-восточное"},
            {"e", "восточное"},
            {"se", "юго-восточное"},
            {"s", "южное"},
            {"sw", "юго-западное"},
            {"w", "западное"},
            {"c", "штиль"}
        };
        public static Dictionary<int, string> PrecipitationType = new Dictionary<int, string>
        {
            {0, "без осадков"},
            {1, "дождь"},
            {2, "дождь со снегом"},
            {3, "снег"}
        };
    }
}