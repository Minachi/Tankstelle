using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat
{
    public class Kassenautomat
    {
        Muenze muenze10 = new Muenze(10);
        Muenze muenze20 = new Muenze(20);
        Muenze muenze50 = new Muenze(50);
        Muenze muenze100 = new Muenze(100);
        Muenze muenze200 = new Muenze(200);
        Muenze muenze500 = new Muenze(500);
        private int betrag;
        private int anzahl10;
        private int anzahl20;
        private int anzahl50;
        private int anzahl100;
        private int anzahl200;
        private int anzahl500;
        private int prozentMuenze;
        private int gesamterBetrag;
        private int[] anzahlMuenzen = new int[6];
        private int[] anzahlMuenzenWechsel = new int[6];
        public int GeldBestand { get; set; }
        public int ZuZahlenderBetrag { get; set; }

        public void InsertCoin(int muenze)
        {
            switch (muenze){
                case 10:
                    anzahl10++;
                    betrag += muenze10.Value;
                    break;
                case 20:
                    anzahl20++;
                    betrag += muenze20.Value;
                    break;
                case 50:
                    anzahl50++;
                    betrag += muenze50.Value;
                    break;
                case 100:
                    anzahl100++;
                    betrag += muenze100.Value;
                    break;
                case 200:
                    anzahl200++;
                    betrag += muenze200.Value;
                    break;
                case 500:
                    anzahl500++;
                    betrag += muenze500.Value;
                    break;
                default:
                    Console.WriteLine("Bitte geben Sie einen gültigen Wert ein.");
                    break;
            }
        }

        public int GetValueInput()
        {
            return betrag;
        }

        public void AcceptValueInput()
        {
            muenze10.Anzahl += anzahl10;
            muenze20.Anzahl += anzahl20;
            muenze50.Anzahl += anzahl50;
            muenze100.Anzahl += anzahl100;
            muenze200.Anzahl += anzahl200;
            muenze500.Anzahl += anzahl500;
            anzahl10 = 0;
            anzahl20 = 0;
            anzahl50 = 0;
            anzahl100 = 0;
            anzahl200 = 0;
            anzahl500 = 0;
            betrag = 0;
        }

        public void NotAcceptValueInput()
        {
            anzahl10 = 0;
            anzahl20 = 0;
            anzahl50 = 0;
            anzahl100 = 0;
            anzahl200 = 0;
            anzahl500 = 0;
            betrag = 0;
        }

        public int GetValueTotal()
        {
            gesamterBetrag += muenze10.Value * muenze10.Anzahl;
            gesamterBetrag += muenze20.Value * muenze20.Anzahl;
            gesamterBetrag += muenze50.Value * muenze50.Anzahl;
            gesamterBetrag += muenze100.Value * muenze100.Anzahl;
            gesamterBetrag += muenze200.Value * muenze200.Anzahl;
            gesamterBetrag += muenze500.Value * muenze500.Anzahl;
            return gesamterBetrag;
        }

        public int GetPercentCoin(int muenze)
        {
            switch (muenze)
            {
                case 10:
                    prozentMuenze = (100 / muenze10.MaximalWert) * muenze10.Anzahl;
                    break;
                case 20:
                    prozentMuenze = (100 / muenze20.MaximalWert) * muenze20.Anzahl;
                    break;
                case 50:
                    prozentMuenze = (100 / muenze50.MaximalWert) * muenze50.Anzahl;
                    break;
                case 100:
                    prozentMuenze = (100 / muenze100.MaximalWert) * muenze100.Anzahl;
                    break;
                case 200:
                    prozentMuenze = (100 / muenze200.MaximalWert) * muenze200.Anzahl;
                    break;
                case 500:
                    prozentMuenze = (100 / muenze500.MaximalWert) * muenze500.Anzahl;
                    break;
                default:
                    Console.WriteLine("Bitte geben Sie einen gültigen Wert ein.");
                    break;
            }
            return prozentMuenze;
        }

        public int[] GetQuantityCoins(){
            anzahlMuenzen[0] = muenze10.Anzahl;
            anzahlMuenzen[1] = muenze20.Anzahl;
            anzahlMuenzen[2] = muenze50.Anzahl;
            anzahlMuenzen[3] = muenze100.Anzahl;
            anzahlMuenzen[4] = muenze200.Anzahl;
            anzahlMuenzen[5] = muenze500.Anzahl;
            return anzahlMuenzen;
        }

        public int[] GetChange(int rueckgeld)
        {
            while (rueckgeld >= 500)
            {
                if (muenze500.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[5]++;
                    muenze500.Anzahl--;
                }
            }
            while (rueckgeld >= 200)
            {
                if (muenze200.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[4]++;
                    muenze200.Anzahl--;
                }
            }
            while (rueckgeld >= 100)
            {
                if (muenze100.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[3]++;
                    muenze100.Anzahl--;
                }
            }
            while (rueckgeld >= 50)
            {
                if (muenze50.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[2]++;
                    muenze50.Anzahl--;
                }
            }
            while (rueckgeld >= 20)
            {
                if (muenze20.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[1]++;
                    muenze20.Anzahl--;
                }
            }
            while (rueckgeld >= 10)
            {
                if (muenze10.Anzahl >= 1)
                {
                    anzahlMuenzenWechsel[0]++;
                    muenze10.Anzahl--;
                }
            }
            return anzahlMuenzenWechsel;
        }

        public void AlertCoinMinimum(int muenze)
        {

        }

        public void AlertCoinMaximum(int muenze)
        {

        }

        public void AlertValueTotalMaximum(int wertTotal)
        {

        }
    }
}
