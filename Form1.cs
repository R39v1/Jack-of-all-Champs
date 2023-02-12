using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Jack_of_All_Champs
{

    public partial class FormJoAC : Form
    {

        string champsFilePath = "champs.json";

        Champs champs;

        int champsDone = 0;

        public FormJoAC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string textJson = readJsonFromFile();
            champs = deserializeJson(textJson);

            setButtons();

            updateProgressBar();

        }

        private void updateProgressBar()
        {
            double width = Convert.ToDouble(buttonProgressBarRed.Size.Width) / Convert.ToDouble(champs.champ.Length) * Convert.ToDouble(champsDone);

            buttonProgressBarGreen.Size = new Size(Convert.ToInt16(width), buttonProgressBarGreen.Size.Height);

            buttonProgressBarGreen.Text = string.Format("{0}/{1} ({2}%)", champsDone.ToString(), champs.champ.Length, Math.Round(100.0 * Convert.ToDouble(champsDone) / Convert.ToDouble(champs.champ.Length), 0));
        }

        private void setButtons()
        {

            foreach (champ champ in champs.champ)
            {
                Button b = new Button();
                b.Size = new Size(80, 25);
                b.Name = champ.name;
                b.Text = champ.name;
                b.FlatStyle = FlatStyle.Flat;

                b.Click += new EventHandler(button_Click);

                if (champ.owned == false)
                {
                    b.BackColor = Color.FromArgb(224, 224, 224); //grey
                }
                else
                {
                    if (champ.done == false)
                    {
                        b.BackColor = Color.NavajoWhite;
                    }
                    else
                    {
                        b.BackColor = Color.FromArgb(192, 255, 192); // green
                        champsDone += 1;
                    }
                }
                flowLayoutPanelScrollList.Controls.Add(b);

            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            champ champ = champs.champ.SingleOrDefault(s => s.name == b.Name);

            int index = Array.FindIndex(champs.champ, v => v.Equals(champ));

            if (champ.owned == false)
            {
                champs.champ[index].owned = true;
                champs.champ[index].done = false;
                b.BackColor = Color.NavajoWhite; //orange
            }
            else
            {
                if (champ.done == false)
                {
                    champs.champ[index].done = true;
                    b.BackColor = Color.FromArgb(192, 255, 192); // green

                    champsDone += 1;
                }
                else
                {
                    champs.champ[index].owned = false;
                    champs.champ[index].done = false;
                    b.BackColor = Color.FromArgb(224, 224, 224); //grey

                    champsDone -= 1;
                }
            }

            updateProgressBar();

        }

        private string readJsonFromFile()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            using (StreamReader sr = new StreamReader(this.champsFilePath))
            {
                return sr.ReadToEnd();
            }

        }

        private Champs deserializeJson(string textJson)
        {

            return JsonSerializer.Deserialize<Champs>(textJson);

        }

        private void saveJsonToFile(string text)
        {

            using (StreamWriter sw = new StreamWriter(this.champsFilePath))
            {
                sw.Write(text);
            }

        }

        private string serializeJson(Champs json)
        {
            return JsonSerializer.Serialize(json, new JsonSerializerOptions { WriteIndented = true });
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string serializedText = serializeJson(this.champs);

            saveJsonToFile(serializedText);

        }

        private void buttonBackGroundColor_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.Gray)
            {
                this.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.Gray;
            }

        }
    }
}
