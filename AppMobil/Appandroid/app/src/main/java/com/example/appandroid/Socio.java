package com.example.appandroid;

import java.io.Serializable;

public class Socio implements Serializable {

    private int id;
    private String telefon;
    private String mail;
    private String nom;
    private String cognoms;
    private String contrasenya;
    private boolean actiu;
    private boolean administrador;
    private int id_comunitat_admin;
    private String DNI;
    private int id_comunidad_socio;
    private boolean contrasena_cambiada;

    public Socio() {
    }

    public Socio(int id, String telefon, String mail, String nom, String cognoms, String contrasenya, boolean actiu, boolean administrador, int id_comunitat_admin, String DNI, int id_comunidad_socio, boolean contrasena_cambiada) {
        this.id = id;
        this.telefon = telefon;
        this.mail = mail;
        this.nom = nom;
        this.cognoms = cognoms;
        this.contrasenya = contrasenya;
        this.actiu = actiu;
        this.administrador = administrador;
        this.id_comunitat_admin = id_comunitat_admin;
        this.DNI = DNI;
        this.id_comunidad_socio = id_comunidad_socio;
        this.contrasena_cambiada = contrasena_cambiada;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTelefon() {
        return telefon;
    }

    public void setTelefon(String telefon) {
        this.telefon = telefon;
    }

    public String getMail() {
        return mail;
    }

    public void setMail(String mail) {
        this.mail = mail;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getCognoms() {
        return cognoms;
    }

    public void setCognoms(String cognoms) {
        this.cognoms = cognoms;
    }

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
    }

    public boolean isActiu() {
        return actiu;
    }

    public void setActiu(boolean actiu) {
        this.actiu = actiu;
    }

    public boolean isAdministrador() {
        return administrador;
    }

    public void setAdministrador(boolean administrador) {
        this.administrador = administrador;
    }

    public int getId_comunitat_admin() {
        return id_comunitat_admin;
    }

    public void setId_comunitat_admin(int id_comunitat_admin) {
        this.id_comunitat_admin = id_comunitat_admin;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public int getId_comunidad_socio() {
        return id_comunidad_socio;
    }

    public void setId_comunidad_socio(int id_comunidad_socio) {
        this.id_comunidad_socio = id_comunidad_socio;
    }

    public boolean isContrasena_cambiada() {
        return contrasena_cambiada;
    }

    public void setContrasena_cambiada(boolean contrasena_cambiada) {
        this.contrasena_cambiada = contrasena_cambiada;
    }
}
