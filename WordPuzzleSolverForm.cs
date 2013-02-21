using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace WordPuzzle_Solver
{
    public partial class WordPuzzleSolverForm : Form
    {
        List<string> WordList;

        public WordPuzzleSolverForm()
        {
            InitializeComponent();
            WordList = new List<string>();
            string content = File.ReadAllText("wordlist.txt");
            WordList.AddRange(content.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            List<string> candidates = new List<string>();
            wordsListBox.Items.Clear();
            foreach (string word in WordList)
            {
                if (word.Length == numberOfLetters.Value)
                {
                    string avail = lettersAvailable.Text;
                    bool match = true;
                    foreach (char c in word)
                    {
                        if (avail.Contains(c))
                        {
                            Regex regex = new Regex(c.ToString());
                            avail = regex.Replace(avail, "", 1);
                        }
                        else
                        {
                            match = false;
                        }
                    }
                    if (match)
                        candidates.Add(word);
                }
            }
            if (candidates.Count > 0)
                wordsListBox.Items.AddRange(candidates.ToArray());
        }
    }
}
