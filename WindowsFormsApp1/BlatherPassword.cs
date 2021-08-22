using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum BlatherDifficulty
    {
        Easy,
        Medium,
        Hard
    }
    class BlatherPassword
    {
        private List<String> altSpellings = new List<String>();

        private string category = "";
        private BlatherDifficulty difficulty;
        private List<String> forbiddenWords = new List<String>();

        private string password = "";
        private string id;
        private string subcategory;

        public string Password
        {
            get { return password; }
            set { password = value;  }
  
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Subcategory
        {
            get { return subcategory; }
            set { subcategory = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public BlatherDifficulty Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public BlatherPassword()
        {

            Console.WriteLine(category);
            Console.WriteLine(difficulty);
            Console.WriteLine(password);
            Console.WriteLine(id);
            Console.WriteLine(subcategory);
        }

       
    }
}


