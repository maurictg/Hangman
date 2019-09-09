using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Galgje
{
    public partial class Form1 : Form
    {
        static char[] Alfabeth = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static List<string> Words = new List<string>() {  };

        List<Stats> Stats = new List<Stats>();

        static char[] Word = { };
        static bool[] Known = { };
        int level = 0;
        int score = 0;

        int win = 0;
        int lose = 0;

        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            => Initialize();


        private void Initialize()
        {
            ticker.Start();
            this.MaximumSize = this.Size;
            CreateAlfabeth();
            LoadWords();
            Word = RandomWord();
            Known = new bool[Word.Length];
            score = 1000;
            MapWord();
            sw.Start();
        }

        public void LoadWords()
        {
            string[] words = { };
            using (StringReader reader = new StringReader(Properties.Resources.woorden))
                words = EnumerateLines(reader).ToArray();

            Words = words.ToList();
            lblStatus.Text = $"Status: {Words.Count()} random woorden ingeladen";
        }
       
        IEnumerable<string> EnumerateLines(TextReader reader)
        {
            string line;

            while ((line = reader.ReadLine()) != null)
                yield return line;
        }

        private void CreateAlfabeth()
        {
            int x = 18;
            int y = 1;

            for (int i = 0; i < 26; i++)
            {
                char ltr = Alfabeth[i];
                Button btn = new Button();
                btn.Name = $"btn_{ltr.ToString()}";
                btn.Click += delegate {
                    Guess(ltr, btn);
                };
                btn.BackColor = Color.FromArgb(33, 33, 33);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Text = ltr.ToString();
                btn.Height = 50;
                btn.Width = 36;
                btn.Font = new Font("Segoe UI", 20f);

                btn.Location = new Point() {
                    X = x,
                    Y = y
                };
                x += 37;


                pnlLetters.Controls.Add(btn);
            }
        }

        private void Guess(char letter, Button sender)
        {
            if (Word.Contains(letter))
            {
                sender.BackColor = Color.Green;
                for (int i = 0; i < Word.Length; i++)
                    if(Word[i]==letter)
                        Known[i] = true;
                score += 125;
            }
            else
            {
                sender.BackColor = Color.Red;
                level++;
                score -= 100;
            }

            MapWord();
            MapImage();
            MapNumber();
            sender.Enabled = false;
            CheckWin();
        }

        private char[] RandomWord()
        {
            int rnd = new Random().Next(Words.Count());
            char[] word = Words[rnd].ToUpper().ToCharArray();
            Words.RemoveAt(rnd);
            return word;
        }

        private void MapImage()
        {
            if(level > 0 && level < 11)
                pbGalgje.BackgroundImage = (Bitmap)Galgje.Properties.Resources.ResourceManager.GetObject($"_{level}");
        }

        private void MapWord()
        {
            string mappedword = "";
            for (int i = 0; i < Word.Length; i++)
                mappedword += (Known[i]) ? $"{Word[i]} ": "_ ";

            lblWord.Text = mappedword;
            lblScore.Text = score.ToString();

            if (Word.Length > 12)
                lblWord.Font = new Font("Segoe UI", 38f);
            else
                lblWord.Font = new Font("Segoe UI", 48f);
        }

        private void MapNumber()
        {
            if (level <= 10)
                lblCount.Text = (10 - level).ToString();
            else
                lblCount.Text = "-";
        }


        private void CheckWin()
        {
            bool won = true;

            if (Known.All(x => x))
            {
                //Win
                this.BackColor = Color.Green;
                MessageBox.Show("Gewonnen!");
                win++;
            }
            else if (level >= 10)
            {
                //Lose
                won = false;
                this.BackColor = Color.Red;
                lblWord.Text = new string(Word);
                lose++;
            }
            else
                return;

            lblWin.Text = win.ToString();
            lblLose.Text = lose.ToString();

            Stats.Add(new Stats { Time = sw.Elapsed, Tries = level, Won = won, Word = new string(Word).ToLower() });
            Replay();
            MapStats();
        }

        private void Replay()
        {
            if (MessageBox.Show("Wil je opnieuw spelen?", "Opnieuw spelen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reset();
            }
            else
                Application.Exit();
        }

        private void Reset()
        {
            this.BackColor = Color.FromArgb(33, 33, 33);
            pbGalgje.BackgroundImage = base.BackgroundImage;
            pnlLetters.Controls.Clear();
            btnHint.Enabled = true;
            CreateAlfabeth();
            level = 0;
            Word = RandomWord();
            Known = new bool[Word.Length];
            score += 1000;
            MapWord();
            MapNumber();
            sw.Restart();
        }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            if (score < 350)
            {
                btnHint.Enabled = false;
                return;
            }

            score -= 350;
            //Get hint
            int ltr = 0;

            for(int i = 0; i < Word.Length; i++)
                if(Known[i]==false)
                {
                    ltr = Word[i];
                    break;
                }

            for (int i = 0; i < Word.Length; i++)
                if (Word[i] == ltr)
                    Known[i] = true;

            MapWord();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            Reset();
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            lblTimespan.Text = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        }

        private void MapStats()
        {
            lbStats.Items.Clear();
            foreach(var stat in Stats)
            {
                string win = (stat.Won) ? "Win" : "Lose";
                lbStats.Items.Add($"{stat.Word} [{stat.Tries}/10] - {stat.Time.Minutes}:{stat.Time.Seconds}.{stat.Time.Milliseconds} ({win})");
            }
        }
    }

    public class Stats
    {
        public string Word { get; set; }
        public TimeSpan Time { get; set; }
        public bool Won { get; set; }
        public int Tries { get; set; }
    }

}
