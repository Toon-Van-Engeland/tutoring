package pxl.students;

import pxl.vakken.Vak;

public abstract class Student {
    private String voorNaam;
    private String achterNaam;
    private int leeftijd;
    private int studentenNummer;
    private String telefoonNummer;
    private Vak[] vakken;

    public Student(String voorNaam, String achterNaam, int leeftijd, int studentenNummer, String telefoonNummer, Vak[] vakken) {
        this.voorNaam = voorNaam;
        this.achterNaam = achterNaam;
        this.leeftijd = leeftijd;
        this.studentenNummer = studentenNummer;
        this.telefoonNummer = telefoonNummer;
        this.vakken = vakken;
    }

    public String getVoorNaam() {
        return voorNaam;
    }

    public void setVoorNaam(String voorNaam) {
        this.voorNaam = voorNaam;
    }

    public String getAchterNaam() {
        return achterNaam;
    }

    public void setAchterNaam(String achterNaam) {
        this.achterNaam = achterNaam;
    }

    public int getLeeftijd() {
        return leeftijd;
    }

    public void setLeeftijd(int leeftijd) {
        this.leeftijd = leeftijd;
    }

    public int getStudentenNummer() {
        return studentenNummer;
    }

    public void setStudentenNummer(int studentenNummer) {
        this.studentenNummer = studentenNummer;
    }

    public String getTelefoonNummer() {
        return telefoonNummer;
    }

    public void setTelefoonNummer(String telefoonNummer) {
        this.telefoonNummer = telefoonNummer;
    }

    public Vak[] getVakken() {
        return vakken;
    }

    public void setVakken(Vak[] vakken) {
        this.vakken = vakken;
    }

    public abstract int berekenGemiddelde();

    public abstract void printAlleVakken();

    public abstract int totaalAantalStudiepunten();
}
