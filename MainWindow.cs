using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoketmonPowerUp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Image[] imgs;
        private int picNo = 0;
        private int[] dustLevelArray;

        private void Form1_Load(object sender, EventArgs e)
        {
            imgs = new Image[2];
            imgs[0] = Image.FromFile("..\\..\\images\\pikachu.jpg");
            imgs[1] = Image.FromFile("..\\..\\images\\raichu.jpg");
            PokemonPictureBox.Image = imgs[0];

            dustLevelArray = new int[] { 400, 600, 800, 1200, 1500, 2000, 2400, 3000, 3600, 4000 };
        }

        private void EvolveButton_Click(object sender, EventArgs e)
        {
            int needCandy = int.Parse(EvolveCandyLabel.Text);
            int myCandy = int.Parse(CandyLabel.Text);
            int CPnum = int.Parse(CPLabel.Text);
            float height = float.Parse(HeightLabel.Text);
            float weight = float.Parse(WeightLabel.Text);
            int MaxHP = int.Parse(TotalHPLabel.Text);
            int NowHP = int.Parse(CurrentHPLabel.Text);

            String pokemonName = "Raichu";

            if (myCandy >= needCandy)
            {
                picNo++;

                if (picNo >= imgs.Length)
                {
                    MessageBox.Show(string.Format("{0} 已經不能再進化了！", pokemonName));
                }
                else
                {
                    PokemonPictureBox.Image = imgs[picNo];
                    NameTextBox.Text = pokemonName;

                    try
                    {
                        myCandy -= needCandy;
                        CandyLabel.Text = myCandy.ToString();
                        CPnum += 500;
                        height += 0.32f;
                        weight += 5.82f;
                        MaxHP += 30;
                        NowHP = MaxHP;
                        if (height < 1.00f)
                        {
                            HeightLabel.Text = "0" + height.ToString("#.##");
                        }
                        else
                        {
                            HeightLabel.Text = height.ToString("#.##");
                        }
                        WeightLabel.Text = weight.ToString("#.##");
                        CPLabel.Text = CPnum.ToString();
                        TotalHPLabel.Text = MaxHP.ToString();
                        CurrentHPLabel.Text = NowHP.ToString();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            else
            {
                EvolveButton.Enabled = false;
            }
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            if (NameTextBox.ReadOnly)
            {
                NameTextBox.ReadOnly = false;
            }
            else
            {
                NameTextBox.ReadOnly = true;
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !NameTextBox.ReadOnly)
            {
                NameTextBox.ReadOnly = true;
            }
        }

        private void StarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StarCheckBox.Text == "☆")
            {
                StarCheckBox.Text = "★";
            }
            else
            {
                StarCheckBox.Text = "☆";
            }
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            int myCandy = int.Parse(CandyLabel.Text);
            int myDust = int.Parse(DustLabel.Text);
            int needDust = int.Parse(PowerUpDustLabel.Text);
            int CPnum = int.Parse(CPLabel.Text);
            int MaxHP = int.Parse(TotalHPLabel.Text);
            int NowHP = int.Parse(CurrentHPLabel.Text);

            if (myDust >= needDust)
            {
                myDust -= needDust;
                CPnum += 200;
                MaxHP += 4;
                NowHP = MaxHP;
                for (int i = 0; i < dustLevelArray.Length; i++)
                {
                    if (needDust == dustLevelArray[i])
                    {
                        needDust = dustLevelArray[i + 1];
                        break;
                    }
                }
                try
                {
                    PowerUpDustLabel.Text = needDust.ToString();
                    DustLabel.Text = myDust.ToString();
                    CPLabel.Text = CPnum.ToString();
                    TotalHPLabel.Text = MaxHP.ToString();
                    CurrentHPLabel.Text = NowHP.ToString();
                }
                catch
                {
                    return;
                }
            }
            else
            {
                PowerUpButton.Enabled = false;
            }
        }
    }
}