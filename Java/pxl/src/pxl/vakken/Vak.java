package pxl.vakken;

public class Vak implements PxlVak, StudentVak {
    private Soorten soort;
    private String naam;
    private int studiePunten;
    private int totaal;

    public Vak() {
    }

    public Vak(Soorten soort, String naam, int studiePunten, int totaal) {
        this.soort = soort;
        this.naam = naam;
        setStudiePunten(studiePunten);
        setTotaal(totaal);
    }

    public Soorten getSoort() {
        return soort;
    }

    public void setSoort(Soorten soort) {
        this.soort = soort;
    }

    public String getNaam() {
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public int getStudiePunten() {
        return studiePunten;
    }

    public void setStudiePunten(int studiePunten) {
        if(studiePunten < 0){
            this.studiePunten = 0;
        } else {
            this.studiePunten = studiePunten;
        }
    }

    public int getTotaal() {
        return totaal;
    }

    public void setTotaal(int totaal) {
        if(totaal < 0){
            this.totaal = 0;
        } else if(totaal > 20){
            this.totaal = 20;
        } else {
            this.totaal = totaal;
        }
    }

    @Override
    public boolean isGeslaagd() {
        return totaal >= 10;
    }

    @Override
    public boolean isTolereerbaar() {
        return totaal >= 8;
    }

    @Override
    public String toString() {
        return "Vak{" +
                "soort=" + soort +
                ", naam='" + naam + '\'' +
                ", studiePunten=" + studiePunten +
                ", totaal=" + totaal +
                '}';
    }
}
