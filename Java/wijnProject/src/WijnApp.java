
import domain.Wijn;

public class WijnApp {
    public static void main(String[] args) {
        Wijn[] wijnkelder = new Wijn[4];

        wijnkelder[0] = new Wijn("Parra", "Wit", "Spanje", 2001, 11.5);
        wijnkelder[0].setDruivenras("Sauvignon Blanc");
        wijnkelder[0].setOmschrijving("Licht, fris en strak");
        wijnkelder[0].setRegio("La Mancha");
        wijnkelder[0].setServeerTip("Visgerechten");

        wijnkelder[1] = new Wijn("Domaine de la Jardine", "Rood", "Frankrijk", 2016, 14);
        wijnkelder[1].setDruivenras("Merlot");
        wijnkelder[1].setOmschrijving("Licht, soepel en fruitig");
        wijnkelder[1].setRegio("Pays d'Oc");
        wijnkelder[1].setServeerTip("Gevogelte");

        wijnkelder[2] = new Wijn("Montebello Grande Bellezza", "Rood", "Italië", 2012, 13);
        wijnkelder[2].setDruivenras("Negroamaro");
        wijnkelder[2].setOmschrijving("Licht, soepel en fruitig");
        wijnkelder[2].setRegio("Puglia");
        wijnkelder[2].setServeerTip("Gegrild vlees");


        wijnkelder[3] = new Wijn("Château Palmer 3eme Grand Cru", "Rood", "Frankrijk", 2002, 13.5);
        wijnkelder[3].setDruivenras("Bordeaux");
        wijnkelder[3].setOmschrijving("Complex, krachtig en vol");
        wijnkelder[3].setRegio("Bordeaux");

        double duurstePrijs = 0;
        double goedkoopstePrijs = -1;
        int indexDuurstePrijs = -1;
        int indexGoedkoopstePrijs = -1;
        int totaalAantalRodeWijnen = 0;
        for (int i = 0; i<wijnkelder.length; i++) {
            if(wijnkelder[i].getAdviesPrijs() > duurstePrijs){
                duurstePrijs = wijnkelder[i].getAdviesPrijs();
                indexDuurstePrijs = i;
            }
            if(wijnkelder[i].getAdviesPrijs() < goedkoopstePrijs || goedkoopstePrijs == -1){
                goedkoopstePrijs = wijnkelder[i].getAdviesPrijs();
                indexGoedkoopstePrijs = i;
            }
            if(wijnkelder[i].getKleur().equals("Rood")){
                totaalAantalRodeWijnen++;
            }
        }

        System.out.println("** Duurste fles:");

        System.out.println(wijnkelder[indexDuurstePrijs].getLabel());

        System.out.println("** Goedkoopste fles:");

        System.out.println(wijnkelder[indexGoedkoopstePrijs].getLabel());

        System.out.println("** Aantal flessen rode wijn: " + totaalAantalRodeWijnen);

        System.out.println("** Suggestie(s) bij gevogelte:");

        for (Wijn wijn : wijnkelder) {
            if(wijn.getServeerTip() != null && wijn.getServeerTip().equals("Gevogelte")){
                System.out.println(wijn.getLabel());
            }
        }

    }
}
