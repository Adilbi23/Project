using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Project
{
    public partial class Form1 : Form
    {
        Settings settings;
        public Form1()
        {
            InitializeComponent();
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string cityname = textBox1.Text;
                string response = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={cityname}&units=metric&appid=5933b7ccc81eecf5c24f9dc61c1826b9");
                Settings settings = JsonConvert.DeserializeObject<Settings>(response);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Скорость ветра: ");
            Console.WriteLine(settings.Wind.Speed);
            Console.WriteLine("Град: ");
            Console.WriteLine(settings.Wind.Deg);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Видимость: ");
            Console.WriteLine(settings.Visibility);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Облачность: ");
            Console.WriteLine(settings.Clouds.All);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Чувствуется: ");
            Console.WriteLine(settings.Main.FeelsLike);
            Console.WriteLine("Влажность: ");
            Console.WriteLine(settings.Main.Humidity);
            Console.WriteLine("Давление: ");
            Console.WriteLine(settings.Main.Pressure);
            Console.WriteLine("Температура: ");
            Console.WriteLine(settings.Main.Temp);
            Console.WriteLine("Максимальная температура: ");
            Console.WriteLine(settings.Main.TempMax);
            Console.WriteLine("Минимальная температура: ");
            Console.WriteLine(settings.Main.TempMin);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Скорость ветра: ");
            Console.WriteLine(settings.Wind.Speed);
            Console.WriteLine("Град: ");
            Console.WriteLine(settings.Wind.Deg);
            Console.WriteLine("Видимость: ");
            Console.WriteLine(settings.Visibility);
            Console.WriteLine("Облачность: ");
            Console.WriteLine(settings.Clouds.All);
            Console.WriteLine("Чувствуется: ");
            Console.WriteLine(settings.Main.FeelsLike);
            Console.WriteLine("Влажность: ");
            Console.WriteLine(settings.Main.Humidity);
            Console.WriteLine("Давление: ");
            Console.WriteLine(settings.Main.Pressure);
            Console.WriteLine("Температура: ");
            Console.WriteLine(settings.Main.Temp);
            Console.WriteLine("Максимальная температура: ");
            Console.WriteLine(settings.Main.TempMax);
            Console.WriteLine("Минимальная температура: ");
            Console.WriteLine(settings.Main.TempMin);
        }
    }
}
