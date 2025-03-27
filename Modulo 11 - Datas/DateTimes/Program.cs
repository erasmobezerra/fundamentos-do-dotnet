using System.Globalization;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var dataAtualDefault = new DateTime();
            Console.WriteLine($"Valor default de DateTime: {dataAtualDefault}");

            var dataAtual = DateTime.Now;
            Console.WriteLine($"Data atual: {dataAtual}");

            var dataInformada = new DateTime(2024, 12, 31, 12, 30, 00);
            Console.WriteLine($"Data informada: {dataInformada}");



            // * Obtendo valores da Data
            Console.WriteLine($"Ano da data informada: {dataInformada.Year}");
            Console.WriteLine($"Mes da data informada: {dataInformada.Month}");
            Console.WriteLine($"Dia da data informada: {dataInformada.Day}");
            Console.WriteLine($"Hora da data informada: {dataInformada.Hour}");
            Console.WriteLine($"Minuto da data informada: {dataInformada.Minute}");
            Console.WriteLine($"Segundo da data informada: {dataInformada.Second}");
            Console.WriteLine($"Dia da semana: {dataInformada.DayOfWeek}");
            Console.WriteLine($"Dia da semana: {(int)dataInformada.DayOfWeek}");
            Console.WriteLine($"Dia do ano: {dataInformada.DayOfYear}");
            Console.WriteLine();
            Console.WriteLine("==============================================");



            // * Formatando datas
            // https://learn.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings
            Console.WriteLine($"Data informada formatada: {dataInformada.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Data informada formatada: {dataInformada.ToString("dd/MM/yyyy HH:mm:ss")}");

            var data = DateTime.Now;
            var dataFormatada = String.Format("{0:dd/MM/yyyy}", data);
            Console.WriteLine($"Data formatada: {dataFormatada}");

            var dataFormatada2 = String.Format("{0:dd/MM/yyyy HH:mm:ss ff z}", data);
            Console.WriteLine($"Data formatada: {dataFormatada2}");
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * Padrões de Formatação
            // https://learn.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings
            // Ao trabalhar com formatações padrões, o próprio C# se adapta conforme a linguagem padrão do sistema           
            // {0:t} -> hora no formato HH:mm
            var dataFormatada3 = String.Format("{0:t}", data);
            Console.WriteLine($"1.Padrões de Formatação: {dataFormatada3}");

            // {0:T} -> hora no formato HH:mm:ss
            dataFormatada3 = String.Format("{0:T}", data);
            Console.WriteLine($"2.Padrões de Formatação: {dataFormatada3}");

            // {0:d} -> data no formato dd/MM/yyyy
            dataFormatada3 = String.Format("{0:d}", data);
            Console.WriteLine($"3.Padrões de Formatação: {dataFormatada3}");

            // {0:D} -> data no formato quarta-feira, 26 de março de 2025
            dataFormatada3 = String.Format("{0:D}", data);
            Console.WriteLine($"4.Padrões de Formatação: {dataFormatada3}");

            // {0:f} -> data e hora no formato quarta-feira, 26 de março de 2025 e HH:mm
            dataFormatada3 = String.Format("{0:f}", data);
            Console.WriteLine($"5.Padrões de Formatação: {dataFormatada3}");

            // {0:F} -> data e hora no formato dia da semana, dia do Mês e ano por extenso, e HH:mm:ss
            dataFormatada3 = String.Format("{0:F}", data);
            Console.WriteLine($"6.Padrões de Formatação: {dataFormatada3}");

            // {0:y} -> data e hora  nome do mês e ano por extenso
            dataFormatada3 = String.Format("{0:y}", data);
            Console.WriteLine($"7.Padrões de Formatação: {dataFormatada3}");

            // {0:g} -> data e hora no formato dd/MM/yyyy HH:mm
            dataFormatada3 = String.Format("{0:g}", data);
            Console.WriteLine($"8.Padrões de Formatação: {dataFormatada3}");

            // {0:G} -> data e hora no formato dd/MM/yyyy HH:mm:ss
            dataFormatada3 = String.Format("{0:G}", data);
            Console.WriteLine($"9.Padrões de Formatação: {dataFormatada3}");

            // {0:r} -> data e hora no formato <Wed, 26 Mar 2025 11:53:22 GMT>
            dataFormatada3 = String.Format("{0:r}", data);
            Console.WriteLine($"10.Padrões de Formatação: {dataFormatada3}");

            // {0:s} -> data e hora no formato <2025-03-26T11:53:22>
            dataFormatada3 = String.Format("{0:s}", data);
            Console.WriteLine($"11.Padrões de Formatação: {dataFormatada3}");

            // {0:u} -> data e hora no formato <2025-03-26T11:53:22Z>   
            dataFormatada3 = String.Format("{0:u}", data);
            Console.WriteLine($"12.Padrões de Formatação: {dataFormatada3}");
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * Adicionando valores na data e hora
            data = DateTime.Now;
            Console.WriteLine("Data atual: " + data);
            Console.WriteLine("Data atual + 1 dia: " + data.AddDays(1));
            Console.WriteLine("Data atual + 2 meses: " + data.AddMonths(2));
            Console.WriteLine("Data atual + 1 ano: " + data.AddYears(1));
            Console.WriteLine("Data Atual + 1 hora: " + data.AddHours(1));
            Console.WriteLine("Data atual + 1 dia + 2 meses + 1 ano + 30min: "
                                + data.AddYears(1).AddMonths(2).AddDays(1).AddMinutes(30));
            Console.WriteLine();

            // * Subtraindo valores na data
            data = DateTime.Now;
            Console.WriteLine("Data atual: " + data);
            Console.WriteLine("Data atual - 1 dia: " + data.AddDays(-1));
            Console.WriteLine("Data atual - 2 meses: " + data.AddMonths(-2));
            Console.WriteLine("Data atal - 1 ano: " + data.AddYears(-1));
            Console.WriteLine("Data Atual - 2 horas: " + data.AddHours(-2));
            Console.WriteLine("Data atual - 1 dia - 2 meses - 1 ano - 2 horas: "
                                + data.AddYears(-1).AddMonths(-2).AddDays(-1).AddHours(-2));
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * Comparando datas
            //     -> DateTime é um ValueType, por isso ele compara diretamente as datas armazenadas nas variaveis, não suas referências.
            //     -> Não pode receber valor nulo, características dos value types.    
            //     -> Dois DateTimes nunca serão exatamente iguais por conta dos nanosegundos.          
            var data1 = DateTime.Now;
            Console.WriteLine("Data 1: " + data1 + ":" + data1.Nanosecond);
            var data2 = DateTime.Now;
            Console.WriteLine("Data 2: " + data2 + ":" + data2.Nanosecond);

            if (data1 == data2)
                Console.WriteLine("Os DateTimes são iguais.");
            else
                Console.WriteLine("Dois DateTimes são diferentes por conta dos nanosegundos.");

            if (data1.Date == data2.Date)
                Console.WriteLine("As datas sem hora são iguais");
            else
                Console.WriteLine("As datas sem hora não são iguais");
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * CultureInfo
            // -> Informações sobre a cultura local, como o separador de milhares, o separador de decimais, etc.
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var maquina = CultureInfo.CurrentCulture;

            var dateTimeNow = DateTime.Now;
            Console.WriteLine("Culture Info: ");
            Console.WriteLine("Portugual: " + dateTimeNow.ToString("D", pt));
            Console.WriteLine("Brasil: " + dateTimeNow.ToString("D", br));
            Console.WriteLine("EUA: " + dateTimeNow.ToString("D", en));
            Console.WriteLine("Dinamarca: " + dateTimeNow.ToString("D", de));
            Console.WriteLine("Máquina: " + dateTimeNow.ToString("D", maquina));
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * Timezone (Fuso Horário)
            // -> UTC(Universal Time Coordinated) Data e Hora Universal
            // -> Recomendado para sistemas que trabalham com clientes internacionais

            var utcDate = DateTime.UtcNow;
            Console.WriteLine("Data e Hora do Sistema com DateTime.Now: " + DateTime.Now);
            Console.WriteLine("Data e Hora UTC (Universal Time Coordinated):" + utcDate);
            Console.WriteLine("Data e Hora do Sistema com DateTime.UtcNow: " + utcDate.ToLocalTime());

            // TimeZoneInfo.FindSystemTimeZoneById -> Pega o fuso horário pelo ID
            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine("TimeZone da Austrália: " + timeZoneAustralia);
            // TimeZoneInfo.ConvertTime -> Converte a data e hora UTC para outro fuso horário
            var australiaDate = TimeZoneInfo.ConvertTime(utcDate, timeZoneAustralia);
            Console.WriteLine("Data e Hora da Austrália: " + australiaDate);
            Console.WriteLine();
            Console.WriteLine("==============================================");

            // Listando todos os timezones
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone.DisplayName);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("===============================");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");




            // * TimeSpan
            // -> Representa um intervalo de tempo, com dias, horas, minutos, segundos, milissegundos e nanosegundos
            var timeSpan = new TimeSpan();
            Console.WriteLine("TimeSpan padrão: " + timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine("TimeSpan com nanosegundos: " + timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine("TimeSpan com horas, minutos e segundos: " + timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(1, 5, 12, 8);
            Console.WriteLine("TimeSpan com dias, horas, minutos e segundos: " + timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 30, 10, 100);
            Console.WriteLine("TimeSpan com dias, horas, minutos, segundos e milissegundos: " + timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
            Console.WriteLine();
            Console.WriteLine("==============================================");

        }
    }
}