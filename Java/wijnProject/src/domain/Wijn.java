package domain;

import java.time.LocalDate;
import java.util.Date;

public class Wijn {
    private String naam;
    private String omschrijving;
    private String druivenras;
    private String kleur;
    private String land;
    private String regio;
    private int jaargang;
    private double alcoholPercentage;
    private String serveerTip;

    public final static double MAX_ALCOHOLPERCENTAGE = 17.0;

    public Wijn(String naam, String kleur, String land) {
        this.naam = naam;
        setKleur(kleur);
        setLand(land);
        this.jaargang = LocalDate.now().getYear() - 1;
        this.alcoholPercentage = 12.5;
    }

    public Wijn(String naam, String kleur, String land, int jaargang, double alcoholpercentage) {
        this.naam = naam;
        setKleur(kleur);
        setLand(land);
        setJaargang(jaargang);
        setAlcoholPercentage(alcoholpercentage);
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getOmschrijving() {
        return omschrijving;
    }

    public void setOmschrijving(String omschrijving) {
        this.omschrijving = omschrijving;
    }

    public String getDruivenras() {
        return druivenras;
    }

    public void setDruivenras(String druivenras) {
        this.druivenras = druivenras;
    }

    public String getKleur() {
        return kleur;
    }

    public void setKleur(String kleur) {
        if(kleur.equals("Rood") || kleur.equals("Wit") || kleur.equals("Rosé")){
            this.kleur = kleur;
        } else {
            this.kleur = "Rood";
        }
    }

    public String getLand() {
        return land;
    }

    public void setLand(String land) {
        if(land.equals("Frankrijk") || land.equals("Chili") || land.equals("Italië") || land.equals("Spanje")){
            this.land = land;
        } else {
            this.land = "Onbekend";
        }
    }

    public String getRegio() {
        return regio;
    }

    public void setRegio(String regio) {
        this.regio = regio;
    }

    public int getJaargang() {
        return jaargang;
    }

    public void setJaargang(int jaargang) {
        if(jaargang < 1950){
            this.jaargang = 1950;
        } else if(jaargang > LocalDate.now().getYear()){
            this.jaargang = LocalDate.now().getYear();
        } else {
            this.jaargang = jaargang;
        }
    }

    public double getAlcoholPercentage() {
        return alcoholPercentage;
    }

    public void setAlcoholPercentage(double alcoholpercentage) {
        if(alcoholpercentage < 0){
            this.alcoholPercentage = 0;
        } else if(alcoholpercentage > 17) {
            this.alcoholPercentage = 17;
        } else {
            this.alcoholPercentage = alcoholpercentage;
        }
    }

    public String getServeerTip() {
        return serveerTip;
    }

    public void setServeerTip(String serveerTip) {
        this.serveerTip = serveerTip;
    }

    public double getAdviesPrijs(){
        double output;
        if(land.equals("Frankrijk")){
            output = 7.5;
        } else if(land.equals("Chili")){
            output = 8.25;
        } else if(land.equals("Italië")){
            output = 9.3;
        } else if(land.equals("Spanje")){
            output = 6.45;
        } else {
            output = 9.3;
        }
        int lastDigitCurrentYear = jaargang % 10;
        if(lastDigitCurrentYear == 7){
            return output;
        }

        output = output + 0.1 * (LocalDate.now().getYear() - jaargang);

        return output;
    }

    public String getLabel(){
        String output = naam + "\n" + druivenras + "\n" + regio + "\n" + jaargang;
        return output;
    }

    @Override
    public String toString() {
        return "Wijn{" +
                "naam='" + naam + '\'' +
                ", omschrijving='" + omschrijving + '\'' +
                ", druivenras='" + druivenras + '\'' +
                ", kleur='" + kleur + '\'' +
                ", land='" + land + '\'' +
                ", regio='" + regio + '\'' +
                ", jaargang=" + jaargang +
                ", alcoholpercentage=" + alcoholPercentage +
                ", serveerTip='" + serveerTip + '\'' +
                '}';
    }
}
