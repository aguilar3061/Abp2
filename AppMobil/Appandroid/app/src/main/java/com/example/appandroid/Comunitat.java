package com.example.appandroid;

public class Comunitat {
    private int id;
    private String nombre;

    public Comunitat(int id, String nom) {
        this.id = id;
        this.nombre = nom;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNom() {
        return nombre;
    }

    public void setNom(String nom) {
        this.nombre = nom;
    }
}
