using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3103
{

    class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title{ get; set; }
        public int Car_ID { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Title} {Car_ID}";
        }
    }

    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Lecturer_ID { get; set; }
        public override string ToString()
        {
            return $"{Id} {Brand} {Model} {Year} {Color} {Lecturer_ID}";
        }
    }



    class Program
    {
        static object GetFirstLecturerAndHisCar()
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = c:\\itay\\rel.db; Version=3;");

            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM lECTURER JOIN CARS ON lECTURER.CAR_ID = CARS.ID", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        Lecturer l = new Lecturer
                        {
                            Id = (int)reader["LECTURER_ID"],
                            Car_ID = (int)reader["CAR_ID"],
                            Name = (string)reader["NAME"],
                            Title = (string)reader["TITLE"]
                        };


                        var c = new Car
                        {
                            Id = (int)reader["CAR_ID"],
                            Lecturer_ID = (int)reader["LECTURER_ID"],
                            Model = (string)reader["MODEL"],
                            Brand = (string)reader["BRAND"],
                            Color = (string)reader["COLOR"],
                            Year = (int)reader["YEAR"]
                        };

                        var result = new { l, c };
                        connection.Close();
                        return result;
                    }

                }
            }

            connection.Close();

            return null;
        }
        static void Main(string[] args)
        {

            var result = GetFirstLecturerAndHisCar();

            Console.WriteLine();
        }
    }
}
