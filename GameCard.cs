using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApi
{
    public partial class GameCard : UserControl
    {
        public GameCard(string title, string ImageUrl, string Savings, string NormalPrice, string SalePrice, string StoreID, string DealRating, string GameLink)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = ImageUrl;
            label1.Text = $"Title: {title}";
            label2.Text = $"Normal price: {NormalPrice} €";
            label3.Text = $"Sale price: {SalePrice} €";
            label4.Text = $"Savings: {Math.Round(Double.Parse(Savings, System.Globalization.CultureInfo.InvariantCulture))} %";
            label5.Text = $"Store: {IDToStore(StoreID)}";
            label6.Text = $"Deal rating: {DealRating}";
            GameUrl += GameLink;
        }
        string GameUrl = "https://www.cheapshark.com/redirect?dealID=";
        string IDToStore(string ID)
        {
            switch (ID)
            {
                case "1":
                    return "Steam";
                case "2":
                    return "GamersGate";
                case "3":
                    return "GreenManGaming";
                case "4":
                    return "Amazon";
                case "5":
                    return "GameStop";
                case "6":
                    return "Direct2Drive";
                case "7":
                    return "GOG";
                case "8":
                    return "Origin";
                case "9":
                    return "Get Games";
                case "10":
                    return "Shiny Loot";
                case "11":
                    return "Humble Store";
                case "12":
                    return "Desura";
                case "13":
                    return "Uplay";
                case "14":
                    return "IndieGameStand";
                case "15":
                    return "Fanatical";
                case "16":
                    return "Gamesrocket";
                case "17":
                    return "Games Republic";
                case "18":
                    return "SilaGames";
                case "19":
                    return "Playfield";
                case "20":
                    return "ImperialGames";
                case "21":
                    return "WinGameStore";
                case "22":
                    return "FunStockDigital";
                case "23":
                    return "GameBillet";
                case "24":
                    return "Voidu";
                case "25":
                    return "Epic Games Store";
                case "26":
                    return "Razer Game Store";
                case "27":
                    return "Gamesplanet";
                case "28":
                    return "Gamesload";
                case "29":
                    return "2Game";
                case "30":
                    return "IndieGala";
                case "31":
                    return "Blizzard Shop";
                case "32":
                    return "AllYouPlay";
                case "33":
                    return "DLGamer";
                default:
                    return "N/A";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GameUrl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GameUrl);
        }
    }
}
