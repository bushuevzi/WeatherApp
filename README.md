# WeatherApp
Используя Яндекс.API погода(https://yandex.ru/dev/weather/) сделать контроллер на net core3, который по GET-запросу из браузера с параметром city возвращал бы JSON-объект, содержащий фактические параметры погоды :
- Температура (°C)
- Ощущаемая температура (°C).
- Температура воды (°C).Если в городе нет водоема, вернуть null
- Код расшифровки погодного описания(в кириллице)
- Скорость ветра (в м/с).
- Скорость порывов ветра (в м/с).
- Направление ветра(в кириллице)
- Давление (в мм рт. ст.).
- Тип осадков.(в кириллице)

Набор городов органичен следующими значениями:
- Krasnodar
- Moscow
- Orengurg
- St.Peretburg
- Kaliningrad.

Историю запросов хранить в базе данных.


&#x1F4D7;
### Использование:
1. Get запрос отправлять на **http://<hostname:hostport>/api/weather?city=Krasnodar**

query параметр - _city_ может принимать значения _[Krasnodar, Moscow, Orengurg, St.Peretburg, Kaliningrad]_
Пример запроса - https://localhost:5001/api/weather?city=Krasnodar

2. Для удобства реализован Web-интерфейс открывающийся по умолчанию
