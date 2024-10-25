using AppPaiements;
internal class Program
{
    private static void Main(string[] args)
    {
        //CARTE CREDIT
        //Création de trois instances de CarteCredit
        CarteCredit achat1 = new CarteCredit(12.5,"Achat Electroniques ",398);
        CarteCredit achat2 = new CarteCredit(89.50, "Achat Vetements", 677);
        CarteCredit achat3 = new CarteCredit(45.75, "Achat Alimentation", 782);

        //Affichage des détails des achats
        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();

        //PAYPAL
        //Création de deux instances de PayPal
        PayPal buy1 = new PayPal(12.5, "Achat Electroniques ", "chrisyos@yahoo.fr");
        PayPal buy2 = new PayPal(89.50, "Achat Vetements", "300141146@monboreal.ca");
        
        //Affichage des détails des achats
        buy1.AfficherDetails();
        buy2.AfficherDetails();


    }
}