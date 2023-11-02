using System.Threading.Tasks;
using WTelegram;

namespace LoginTG
{
        /// <summary>
        /// Создаём тип возвращаемых данных
        /// </summary>
        public class ClientResult
        {
            /// <summary>
            /// Результат операции
            /// </summary>
            public bool IsDone { get; set; }
            /// <summary>
            /// Сообщение к результату
            /// </summary>
            public string? Message { get; set; }

            /// <summary>
            /// Конструктор для возврата
            /// </summary>
            /// <param name="isDone">Успешная ли операция</param>
            /// <param name="message">Сообщение об операции</param>
            public ClientResult(bool isDone, string message = "")
            {
                IsDone = isDone;
                Message = message;
            }
    
            /// <summary>
            /// Пустой конструктор
            /// </summary>
            public ClientResult()
            {

            }
        }
        
    /// <summary>
    /// Класс для работы с телеграмм клиентом
    /// </summary>
    public class Telega
    {

        /// <summary>
        /// Собственно, клиент, который будет инициализирован
        /// </summary>
        private Client ? Client { get; set; }


        //Если приложение не требует ввода AppId и ApiHash - их целесообразно указать приватными константами
        //Сюда ввести свои значения!!!!!!
        private const int AppId = 26229091;
        private const string ApiHash = "bfafb2abc6fa62e5b480bddaab6fdcc9";


        /// <summary>
        /// Номер телефона клиента для аутентификации
        /// </summary>
        public string ? ClientNumber { get; set; }


        /// <summary>
        /// Код из сообщения
        /// </summary>
        public string? Hash { get; set; }
        

        /// <summary>
        /// Параметр, в который мы будем вводить результат операции логина
        /// </summary>
        private string? What { get; set; }

        
        /// <summary>
        /// Метод авторизаци, доступный из интерфейса
        /// </summary>
        /// <param name="clientNumber">Номер телефона клиента</param>
        /// <returns>Результат авторизации</returns>

        public async Task <ClientResult> Auth ()
        {
           Client = new Client (AppId, ApiHash);
            return await DoLogin (ClientNumber);    
        }

        /// <summary>
        /// Основной метод авторизации
        /// </summary>
        /// <param name="loginInfo">Информация для авторизации (номер, 2фа код и так далее)</param>
        /// <returns></returns>
        private async Task <ClientResult> DoLogin(string ? loginInfo)
        {
            //Client.Login возвращает строку с информацией о том, чего нам ещё не хватает для входа, или Null, если вход успешный
            What = await Client.Login(loginInfo); //Тут мы получили значение, отличаемое от Null, а значит, вход не прошёл. Причина этому скрывается в What
            if (What != null)
                return new ClientResult(false, $"A {What} is required..."); //Добавим это сообщение к возврату, вдруг пригодится в интерфейсе
            
            //А на этом месте переменная What будет null
            return new ClientResult(true, $"We are now connected as {Client.User}");
        }

        /// <summary>
        /// Публичный метод для получения и отправки хеша из контроллов
        /// </summary>
        public async Task<ClientResult> Verify()
        {
            return await DoLogin(Hash);
        }
    }
        
        
        
}