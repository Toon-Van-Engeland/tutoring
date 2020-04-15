package pxl.test;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import pxl.students.ITStudent;
import pxl.students.MarketingStudent;
import pxl.students.Student;
import pxl.vakken.Soorten;
import pxl.vakken.Vak;

public class TestClass {
    Vak[] marketingVakken;
    Vak[] itVakken;
    Student[] students;

    @Before
    public void startUp(){
        marketingVakken = new Vak[14];
        itVakken = new Vak[8];
        students = new Student[2];

        marketingVakken[0] = new Vak(Soorten.HOORCOLLEGE, "Financieel management voor Marketeers", 4, 11);
        marketingVakken[1] = new Vak(Soorten.HOORCOLLEGE, "Marketing essentials", 7, 15);
        marketingVakken[2] = new Vak(Soorten.PRACTICUM, "Project: marketingmix in 4 talen", 6, 11);
        marketingVakken[3] = new Vak(Soorten.HOORCOLLEGE, "Economische actualiteit", 3, 12);
        marketingVakken[4] = new Vak(Soorten.HOORCOLLEGE, "Zakelijke communicatie 1", 3, 10);
        marketingVakken[5] = new Vak(Soorten.PRACTICUM, "Duits 1", 5, 15);
        marketingVakken[6] = new Vak(Soorten.HOORCOLLEGE, "Wetgeving voor marketeers", 4, 7);
        marketingVakken[7] = new Vak(Soorten.HOORCOLLEGE, "statistiek voor marketeers", 5, 13);
        marketingVakken[8] = new Vak(Soorten.HOORCOLLEGE, "ICT basis", 3, 17);
        marketingVakken[9] = new Vak(Soorten.HOORCOLLEGE, "ICT voor marketeers 1", 4, 16);
        marketingVakken[10] = new Vak(Soorten.PRACTICUM, "Frans 1", 5, 4);
        marketingVakken[11] = new Vak(Soorten.PRACTICUM, "Engels 1", 5, 14);
        marketingVakken[12] = new Vak(Soorten.HOORCOLLEGE, "Consumentengedrag", 3, 10);
        marketingVakken[13] = new Vak(Soorten.HOORCOLLEGE, "Internationale Handel", 3, 13);

        itVakken[0] = new Vak(Soorten.PRACTICUM, "Programming Expert", 3, 18);
        itVakken[1] = new Vak(Soorten.PRACTICUM, "Mobile development", 3, 15);
        itVakken[2] = new Vak(Soorten.PRACTICUM, "Web Expert", 3, 19);
        itVakken[3] = new Vak(Soorten.PRACTICUM, "Software engineering", 3, 13);
        itVakken[4] = new Vak(Soorten.PRACTICUM, "I-talent", 6, 14);
        itVakken[5] = new Vak(Soorten.PRACTICUM, "Web and Mobile", 9, 14);
        itVakken[6] = new Vak(Soorten.PRACTICUM, "IT project", 15, 15);
        itVakken[7] = new Vak(Soorten.STAGE, "Bachelor Project", 18, 14);

        students[0] = new MarketingStudent("Gioridano", "Gatti", 21, 11502156, "478005858", marketingVakken, 58);
        students[1] = new ITStudent("Toon", "Van Engeland", 21, 11702323, "489334428", itVakken, 153);
    }

    @Test
    public void correctAantalStudiepunten(){
        Assert.assertEquals(60, students[0].totaalAantalStudiepunten());
        Assert.assertEquals(60, students[1].totaalAantalStudiepunten());
    }

    @Test
    public void correctGemiddelde(){
        Assert.assertEquals(15, students[1].berekenGemiddelde());
    }

    @Test
    public void controleerVakken(){
        itVakken[0].setTotaal(122);
        itVakken[1].setTotaal(-15);
        itVakken[2].setStudiePunten(-5);

        Assert.assertEquals(20, itVakken[0].getTotaal());
        Assert.assertEquals(0, itVakken[1].getTotaal());
        Assert.assertEquals(0, itVakken[2].getStudiePunten());
    }
}
