package pxl.students;

import pxl.vakken.Vak;

public class ITStudent extends Student {

    private int ITalent;

    public ITStudent(String voorNaam, String achterNaam, int leeftijd, int studentenNummer, String telefoonNummer, Vak[] vakken, int ITalent) {
        super(voorNaam, achterNaam, leeftijd, studentenNummer, telefoonNummer, vakken);
        this.ITalent = ITalent;
    }

    @Override
    public int berekenGemiddelde() {
        int totaal = 0;
        for (Vak vak : getVakken()) {
            totaal += vak.getTotaal();
        }
        return totaal / getVakken().length;
    }

    @Override
    public void printAlleVakken() {
        for (Vak vak : getVakken()) {
            System.out.println(vak);
        }
    }

    @Override
    public int totaalAantalStudiepunten() {
        int totaal = 0;
        for (Vak vak : getVakken()) {
            totaal += vak.getStudiePunten();
        }
        return totaal;
    }
}
