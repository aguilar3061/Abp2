package com.example.appandroid;

public class Assistir {
    private int idSoci;
    private int idEsdeveniment;
    private int numAssistents;
    private int valoracio;
    private String comentari;

    public Assistir(int idSoci, int idEsdeveniment, int valoracio, String comentari, int numAssistents) {
        this.idSoci = idSoci;
        this.idEsdeveniment = idEsdeveniment;
        this.valoracio = valoracio;
        this.comentari = comentari;
        this.numAssistents = numAssistents;
    }

    public int getIdSoci() {
        return idSoci;
    }

    public void setIdSoci(int idSoci) {
        this.idSoci = idSoci;
    }

    public int getIdEsdeveniment() {
        return idEsdeveniment;
    }

    public void setIdEsdeveniment(int idEsdeveniment) {
        this.idEsdeveniment = idEsdeveniment;
    }

    public int getNumAssistents() {
        return numAssistents;
    }

    public void setNumAssistents(int numAssistents) {
        this.numAssistents = numAssistents;
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
