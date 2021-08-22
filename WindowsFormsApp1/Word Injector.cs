using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int newID;
        public Form1()
        {
            InitializeComponent();
                
            LoadClueListFromFile();
            LoadData();
        }

        public void LoadClueListFromFile()
        {
            //string filepath = System.IO.Directory.GetCurrentDirectory();
            string filepath = @"C:\Users\Lotus\Desktop\Jackbox Shit\List of Decriptors.txt";
            List<string> file = new List<string>();

            List<string> clueList = new List<string>();

            try
            {
                file = System.IO.File.ReadAllLines(filepath).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }

            //Check if read properly
            if (file.Count > 0)
            {
                foreach(string line in file)
                {
                    string newline = line.Replace(" ",string.Empty);
                    newline = newline.Replace("\"", string.Empty);
                    newline = newline.Replace(",", string.Empty);

                    string[] listWords = newline.Split(':');
                    if(listWords.Length >= 2)
                        clueList.Add(listWords[1]);
                }

                //clueList is sorted populated
                clueList.Sort();

                foreach (string clue in clueList)
                {
                    clueListView.Items.Add(clue);
                }

                clueListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                
                //
            }
        }

        public void LoadData()
        {
            //string filepath = System.IO.Directory.GetCurrentDirectory();
            string filepath = @"C:\Users\Lotus\Desktop\Jackbox Shit\BlankyBlankPasswords.jet";
            List<string> file = new List<string>();

            string tempID;
            string IDstringToMatch = "\"id\"";


            try
            {
                file = System.IO.File.ReadAllLines(filepath).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }

            //For now, just load last ID
            for(int i = file.Count-1; i>0; i--)
            {
                if (file[i].Contains(IDstringToMatch))
                {
                    //Parse last ID and increment
                    tempID = Regex.Match(file[i], @"\d+").Value;
                    newID = Int32.Parse(tempID);
                    newID++;
                    break;
                }
            }

            IDtextBox.Text = newID.ToString();

        }

        public void WriteData(List<string> data)
        {
            //string filepath = System.IO.Directory.GetCurrentDirectory();
            string filepath = @"C:\Users\Lotus\Desktop\Jackbox Shit\TextPrompt_" + (newID-1) + ".txt";

            try
            {
                System.IO.File.WriteAllLines(filepath, data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

            }
            
            MessageBox.Show("Success!", "Notice", MessageBoxButtons.OK);
            ResetForm();
        }

        //Loads all passwords into their own class into memory
        public void PopulateBlatherList(List<String> file)
        {

        }

        public void ResetForm()
        {
            passwordTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            subcategoryComboBox.SelectedIndex = -1;
            altSpellingTextBox.Text = "";
            bannedTextBox.Text = "";
            IDtextBox.Text = newID.ToString();
            yourClueListView.Items.Clear();
            easyRadioButton.Checked = false;
            mediumRadioButton.Checked = false;
            hardRadioButton.Checked = false;
            TrueRadioButton.Checked = false;
            FalseRadioButton.Checked = false;
        }
        /*  Starts with 
        *   Alt Spellings   []
        *   Category
        *   Difficulty
        *   Forbidden Words []
        *   ID
        *   Password
        *   Subcategory
        *   Tailored Words  []
        */
        private void StructureGamePassword()
        {
            List<string> structuredPassword = new List<string>();
            List<string> altSpellings = new List<string>();
            List<string> forbiddenWords = new List<string>();
            List<string> clues = new List<string>();



            string category = "";
            string difficulty = "";
            string password = "";
            string ID = "";
            string subcategory = "";
            string US = "";

            //First line
            structuredPassword.Add(@"  {");

            //Alt Spellings
            altSpellings = compileAltSpellings();
            structuredPassword.AddRange(altSpellings);

            //Category
            category = compileCategory();
            structuredPassword.Add(category);

            //Difficulty
            difficulty = compileDifficulty();
            structuredPassword.Add(difficulty);

            //Forbidden Words
            forbiddenWords = compileForbiddenWords();
            structuredPassword.AddRange(forbiddenWords);

            //Password
            password = compilePassword();
            structuredPassword.Add(password);

            //ID
            ID = compileID();
            structuredPassword.Add(ID);

            //Subcategory
            subcategory = compileSubcategory();
            structuredPassword.Add(subcategory);

            //Clues
            clues = compileClues();
            structuredPassword.AddRange(clues);

            //US T or F
            US = compileUS();
            structuredPassword.Add(US);

            //Last line
            structuredPassword.Add(@"  }");
            WriteData(structuredPassword);
        }



        private List<String> compileAltSpellings()
        {
            List<string> structuredAltSpelling = new List<string>();
            string firstLine = "   \"alternateSpellings\": [";
            string lastLine = "   ],";
            string altSpellings = "";
            char[] charsToTrim = { ' ' };

            //Add first line
            structuredAltSpelling.Add(firstLine);

            //Add alternate spellings

            //Split with ',' delim
            altSpellings = altSpellingTextBox.Text;
            string[] altSpellingArray = altSpellings.Split(',');

            //Remove whitespace
            //Add quotes and commas
            for (int i = 0; i<altSpellingArray.Length; i++)
            {
                altSpellingArray[i] = altSpellingArray[i].Trim(charsToTrim);
                //altSpellingArray[i] = altSpellingArray[i].Replace(" ", string.Empty);
                altSpellingArray[i] = AddDoubleQuotes(altSpellingArray[i]);
                
                //If not last element
                if(!(i >= altSpellingArray.Length - 1))
                {
                    altSpellingArray[i] = altSpellingArray[i].Insert(altSpellingArray[i].Length,",");
                }

                //4 spaces
                structuredAltSpelling.Add("    " + altSpellingArray[i]);
            }

            //Add last line
            structuredAltSpelling.Add(lastLine);

            return structuredAltSpelling;
        }

        /* Returns string.Empty if field is blank
         * Otherwise returns a formatted string
         */
        private string compileCategory()
        {
            if(categoryComboBox.SelectedItem == null)
            {
                return "   \"category\": \"\",";
            }


            string category = categoryComboBox.SelectedItem.ToString();

            return "   \"category\": \"" + category + "\",";
        }

        private string compileDifficulty()
        {
            string difficultyString = "   \"difficulty\": ";

            if(easyRadioButton.Checked)
            {
                difficultyString  += "\"easy\",";
               
            }
            else if (mediumRadioButton.Checked)
            {
                difficultyString += "\"medium\",";
            }
            else if (hardRadioButton.Checked)
            {
                difficultyString += "\"hard\",";
            }
            else
            {
                difficultyString += "\"easy\",";
            }

            return difficultyString;
        }

        private List<string> compileForbiddenWords()
        {
            List<string> structuredForbiddenWords = new List<string>();
            string firstLine = "   \"forbiddenWords\": [";
            string lastLine = "   ],";

            string forbiddenWords = bannedTextBox.Text;

            //Add first line
            structuredForbiddenWords.Add(firstLine);

            //Split with ',' delim
            forbiddenWords = altSpellingTextBox.Text;
            string[] forbiddenWordsArray = forbiddenWords.Split(',');

            //Remove whitespace
            //Add quotes and commas
            for (int i = 0; i < forbiddenWordsArray.Length; i++)
            {
                forbiddenWordsArray[i] = forbiddenWordsArray[i].Replace(" ", string.Empty);
                forbiddenWordsArray[i] = AddDoubleQuotes(forbiddenWordsArray[i]);

                //If not last element
                if (!(i >= forbiddenWordsArray.Length - 1))
                {
                    forbiddenWordsArray[i] = forbiddenWordsArray[i].Insert(forbiddenWordsArray[i].Length, ",");
                }

                //4 spaces
                structuredForbiddenWords.Add("    " + forbiddenWordsArray[i]);
            }

            structuredForbiddenWords.Add(lastLine);

            return structuredForbiddenWords;
        }

        private string compileID()
        {
            string tempID = IDtextBox.Text.ToString();
            //string tempID = newID.ToString();

            //Parse last ID and increment
            int id = Int32.Parse(tempID);
            if(id > newID)
            {
                newID = id;
            }
            newID++;
            return "   \"id\": \"" + tempID + "\",";
        }

        private string compilePassword()
        {
            return "   \"password\": \"" + passwordTextBox.Text + "\",";
        }
        private string compileSubcategory()
        {
            if (subcategoryComboBox.SelectedItem == null)
            {
                return "   \"subcategory\": \"\",";
            }

            string subcategory = subcategoryComboBox.SelectedItem.ToString();

            return "   \"subcategory\": \"" + subcategory + "\",";
        }

        private List<String> compileClues()
        {
            List<String> structuredClues = new List<string>();
            string firstLine = "   \"tailoredWords\": [";
            string lastLine = "   ],";

            structuredClues.Add(firstLine);

            for(int i = 0; i < yourClueListView.Items.Count; i++)
            {
                if(yourClueListView.Items[i].SubItems.Count == 2)
                {
                    string list = "     \"list\": ";
                    string word = "     \"word\": ";

                    list += AddDoubleQuotes(AddDoublePointedBrackets(yourClueListView.Items[i].SubItems[0].Text));
                    word += AddDoubleQuotes(yourClueListView.Items[i].SubItems[1].Text);

                    list += ",";

                    structuredClues.Add("    {");
                    structuredClues.Add(list);
                    structuredClues.Add(word);

                    if(i < yourClueListView.Items.Count - 1)
                    {
                        structuredClues.Add("    },");
                    }
                    else
                    {
                        structuredClues.Add("    }");
                    }
                }
            }

            structuredClues.Add(lastLine);
            return structuredClues;
        }

        private string compileUS()
        {
            if(TrueRadioButton.Checked)
            {
                return "   \"us\": true";
            }
            else
            {
                return "   \"us\": false";
            }
        }
        #region EventHandlers
        private void submitButton_Click(object sender, EventArgs e)
        {
            StructureGamePassword();
        }

        private void sendToYourClues_Click(object sender, EventArgs e)
        {
            //Non-empty hint
            if (!hintTextBox.Text.Equals(String.Empty) && !selectedClueTextBox.Text.Equals(String.Empty))
            {
                string[] items = { selectedClueTextBox.Text, hintTextBox.Text };
                ListViewItem row = new ListViewItem(items);
                yourClueListView.Items.Add(row);

                //Clear HintBoxes 
                hintTextBox.Text = "";
                selectedClueTextBox.Text = "";

                clueListView.SelectedIndices.Clear();
            }
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (yourClueListView.SelectedItems != null)
            {
                foreach(ListViewItem item in yourClueListView.SelectedItems)
                {
                    yourClueListView.Items.Remove(item);
                }          
            }
        }

        private void clueListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(clueListView.SelectedItems.Count > 0)
            {
                string clueListViewItem = clueListView.SelectedItems[0].Text;
                selectedClueTextBox.Text = clueListViewItem;
            }
           
        }
        #endregion


        #region Helpers
        public static string AddDoubleQuotes(string s)
        {
            return "\"" + s + "\"";
        }

        public static string AddDoublePointedBrackets(string s)
        {
            return "<" + s + ">";
        }
        #endregion


    }
}
