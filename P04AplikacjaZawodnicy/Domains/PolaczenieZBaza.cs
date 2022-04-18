using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaZawodnicy
{
    class PolaczenieZBaza
    {
        readonly private string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=A_Zawodnicy;Integrated Security=True"; // "Integrated Security=True"
                                                                                                                               // Logowanie przez windows security(lokalnie)
                                                                                                                               // Jak chcemy do innego servera:
                                                                                                                               // User ID={id};Password={hasło}.

/*        public PolaczenieZBaza(string connString)
        {
            this.connString = connString; // "this." to odwołanie aktualnej klasy || dzieki temu dwie zmeinne tak samo nazwane nie kłócą się ze sobą
        }*/

        public object[][] WykonajZapytanieSQL(string sql)
        {
            SqlConnection connection = new SqlConnection(connString); // do komunikacji z bazą danych

            SqlCommand command = new SqlCommand(sql, connection); // do przechowywania poleceń sql

            SqlDataReader dataReader; // do czytania odpowiedzi z bazy danych

            List<object[]> listaWierszy = new List<object[]>();

            try
            {
                connection.Open();
                dataReader = command.ExecuteReader(); // wysyłanie do bazy sql
                                                      // dataReader jesy uchwytem do wyniku 

                while (dataReader.Read())
                {
                    object[] wiersz = new object[dataReader.FieldCount]; // !!!!!!!! ".FieldCount" zwraca liczbe kolumn

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        wiersz[i] = dataReader.GetValue(i);
                    }
                    listaWierszy.Add(wiersz); // dodawanie wiersza(czyli tablicy obiektów) do listy
                }
            }
            catch (Exception)
            {
                throw;
                // Console.WriteLine("błąd bazy danych");
            }
            finally// klauzula "finally" wykonuje się zawsze albo po "try" lub po "catch"
            {
                connection.Close();
            }

            return listaWierszy.ToArray(); // przekształcanie na tablice
        }
    }
}
