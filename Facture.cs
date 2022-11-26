using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_POO_6
{
    public class Facture
    {
        List<string> item;
        List<double> prix;
        double taxe;

        public Facture(double taxe)
        {
            this.taxe = taxe;
            this.item = new List<string>();
            this.prix = new List<double>();
        }

        public void AjouterItem(string nom, double prix)
        {
            this.item.Add(nom);
            this.prix.Add(prix);
        }
        
        public double SousTotalHTC()
        {
            double totalHTC = 0.0;

            for (int i = 0; i < this.prix.Count; i++)
            {
                totalHTC = totalHTC + this.prix[i];
            }
            return totalHTC;
        }
        public double CalculerTaxes()
        {
            double totalTaxe;

            totalTaxe = SousTotalHTC() * this.taxe;

            return totalTaxe;
        }
        public double TotalFacture()
        {
            double totalFacture = 0.0;

            totalFacture = SousTotalHTC() + CalculerTaxes();
            
            return totalFacture;
        }
        public void afficheFacture()
        {
            for (int i = 0; i < this.prix.Count; i++);
            {
                Console.WriteLine("{0} : {1}", this.item[i], this.prix{i});
            }
            
            Console.WriteLine("Sous Total est : {0}", SousTotalHTC());

            Console.WriteLine("Taxe : {0}", CalculerTaxes());

            Console.WriteLine("Total : {0]", TotalFacture());
            

        }   


    }

}
