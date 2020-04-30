using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeatrLibrary.Structs;

namespace TeatrUI
{
    class Utils
    {
        public static void CopyImageToPhotoLibrary(string source, string fileName, string directionDirectory="\\")
        {

            string directionPath =
                Path.Combine(
                    Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName,
                    "PhotoLibrary\\" + directionDirectory  + "\\" + fileName
                );
            try
            {
                File.Copy(source, directionPath, false);
            } catch (IOException e) { };
        }

        public static Image LoadImage(string directory, string fileName)
        {
            Image image = null;
            string defaultImage = "default";
            switch(directory)
            {
                case "staff":
                    defaultImage = "default_member";
                    break;
                case "production":
                    defaultImage = "default_poster";
                    break;
                case "user":
                    defaultImage = "default_user";
                    break;
                default:
                    defaultImage = "default";
                    break;
            }
            if (fileName != null)
            {
                try
                {
                    image = Image.FromFile(Path.Combine(
                                   Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName,
                                   "PhotoLibrary\\" + directory + "\\" + fileName));
                }
                catch (FileNotFoundException e)
                {
                    //TODO - log exception for the file
                    // load not found image
                    image = (Image)Properties.Resources.ResourceManager.GetObject(defaultImage);
                }
            } else
            {
                // load default image
                image = (Image)Properties.Resources.ResourceManager.GetObject(defaultImage);
            }
            
            return image;
        }

        public static bool SeatIsTaken(List<Seat> taken, Seat currentSeat)
        {
            return taken.Any(s => s.Row == currentSeat.Row && s.Column == currentSeat.Column);
            //return true;
        }

        public static string ConvertToCyrillic(string word)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("ж", "zh");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "j");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "ts");
            words.Add("ч", "ch");
            words.Add("ш", "sh");
            words.Add("щ", "scht");
            words.Add("ъ", "a");
            words.Add("ю", "yu");
            words.Add("я", "ya");
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Е", "E");
            words.Add("Ж", "Zh");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Й", "J");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "C");
            words.Add("Ч", "Ch");
            words.Add("Ш", "Sh");
            words.Add("Щ", "Sch");
            words.Add("Ъ", "A");
            words.Add("Ь", "J");
            words.Add("Ю", "Yu");
            words.Add("Я", "Ya");

            foreach (KeyValuePair<string, string> pair in words)
            {
                word = word.Replace(pair.Key, pair.Value);
            }
            return word;
        }
    }
}
