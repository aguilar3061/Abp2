package com.example.appandroid;

public class Assistir {
    private int id_Soci;
    private int id_Esdeveniment;
    private int aiste;
    private int valoracio;
    private String comentari;

    public Assistir(int id_Soci, int id_Esdeveniment, int aiste, int valoracio, String comentari) {
        this.id_Soci = id_Soci;
        this.id_Esdeveniment = id_Esdeveniment;
        this.aiste = aiste;
        this.valoracio = valoracio;
        this.comentari = comentari;
    }

    public int getId_Soci() {
        return id_Soci;
    }

    public void setId_Soci(int id_Soci) {
        this.id_Soci = id_Soci;
    }

    public int getId_Esdeveniment() {
        return id_Esdeveniment;
    }

    public void setId_Esdeveniment(int id_Esdeveniment) {
        this.id_Esdeveniment = id_Esdeveniment;
    }

    public int getAiste() {
        return aiste;
    }

    public void setAiste(int aiste) {
        this.aiste = aiste;
    }

    public int getValoracio() {
        return valoracio;
    }

    public void setValoracio(int valoracio) {
        this.valoracio = valoracio;
    }

    public String getComentari() {
        return comentari;
    }

    public void setComentari(String comentari) {
        this.comentari = comentari;
    }
}
