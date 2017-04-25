using System;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Self_ServiceTerminal
{
    public class terminalFunctions
    {
        public terminalFunctions()
        {

        }

        public void serializeOwners(CardOwner[] arrayOfOwners)
        {
            //Удаляем прошлый в избежание плохой перезаписи
            File.Delete("Serialization.xml");
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(CardOwner[]));
            
            using (FileStream fs = new FileStream("Serialization.xml", FileMode.Create))
                formatter.Serialize(fs, arrayOfOwners);
        }

        public void printCheckMobileCommunication(int totalMoneyForOperation, string payerFIO, string mobileNumber, string mobileOperator)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ОПЛАТА МОБИЛЬНОЙ СВЯЗИ");
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("МОБИЛЬНЫЙ ОПЕРАТОР: " + mobileOperator);
            check.WriteLine("НОМЕР ТЕЛЕФОНА: " + mobileNumber);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("ПЛАТЕЛЬЩИК: " + payerFIO);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000,999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckMoneyTransfer(int totalMoneyForOperation, string UPNPayer, string UPNReciever, string nameReciever)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ДЕНЕЖНЫЕ ПЕРЕВОДЫ");
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("НОМЕР UPN ОТПРАВИТЕЛЯ: ");
            check.WriteLine(UPNPayer);
            check.WriteLine("ПОЛУЧАТЕЛЬ: ");
            check.WriteLine(nameReciever);
            check.WriteLine("НОМЕР UPN ПОЛУЧАТЕЛЯ: ");
            check.WriteLine(UPNReciever);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckMassMediaSubscribe(int totalMoneyForOperation)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ПОДПИСКА НА СМИ");
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckWebmoney(int totalMoneyForOperation, string purseNumber)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ПОПОЛНЕНИЕ СЧЕТА WEBMONEY");
            check.WriteLine("НОМЕР КОШЕЛЬКА WEBMONEY: ");
            check.WriteLine(purseNumber);
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckOnlineGames(int totalMoneyForOperation, string gameName, string accountName)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ОНЛАЙН ИГРЫ");
            check.WriteLine("ИГРА: ");
            check.WriteLine(gameName);
            check.WriteLine("ИМЯ АККАУНТА: ");
            check.WriteLine(accountName);
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckCreditOperation(int totalMoneyForOperation, string contractNumber, string bank)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ОПЛАТА КРЕДИТА");
            check.WriteLine("БАНК ВЫДАВШИЙ КРЕДИТ: ");
            check.WriteLine(bank);
            check.WriteLine("НОМЕР КРЕДИТНОГО ДОГОВОРА: ");
            check.WriteLine(contractNumber);
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckCardOperation(int totalMoneyForOperation, string cardNumber)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("ПОПОЛНЕНИЕ БАЛАНСА КАРТЫ");
            check.WriteLine("НОМЕР КАРТЫ: ");

            check.WriteLine(cardNumber.Substring(0,12) + "****");
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.Close();
            Process.Start("currentCheck.txt");
        }

        public void printCheckCharity(int totalMoneyForOperation)
        {
            Random rand = new Random();
            StreamWriter check = new StreamWriter("currentCheck.txt");
            check.WriteLine("*****************************");
            check.WriteLine(@"ОАО ""АСБ WIESEBANK""");
            check.WriteLine("ТЕРМИНАЛ: INF01387");
            check.WriteLine("ТЕЛ: 375257388258");
            check.WriteLine("КАРТ-ЧЕК N: " + rand.Next(1000, 9999));
            check.WriteLine("НАИМЕНОВАНИЕ ОПЕРАЦИИ: ");
            check.WriteLine("БЛАГОТВОРИТЕЛЬНОСТЬ");
            check.WriteLine("ДАТА: " + DateTime.Now);
            check.WriteLine("ИТОГО ОПЛАЧЕНО: " + totalMoneyForOperation);
            check.WriteLine("КОД АВТОРИЗАЦИИ: " + rand.Next(100000, 999999));
            check.WriteLine("");
            check.WriteLine("<<<<<<<<<<<<<<<<<<БЛАГОДАРИМ ТЕБЯ, ДОБРЫЙ ЧЕЛОВЕК!>>>>>>>>>>>>>>>>>>>>>>");
            check.WriteLine("<<<<<<<<<<<<<<<<<<<<<<ПОМОЖЕМ ЭТОМУ МИРУ ВМЕСТЕ!>>>>>>>>>>>>>>>>>>>>>>>>");
            check.Close();
            Process.Start("currentCheck.txt");
        }
    }
}
