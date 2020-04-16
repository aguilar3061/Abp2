package com.example.appandroid;

public class Socio {

    private int id;
    private String telefono;
    private String mail;
    private String nombre;
    private String apellido;
    private String contrasenya;
    private boolean actiu;
    private boolean administrador;
    private int idComunitat_admin;
    private String DNI;
    private int id_comunitat_soci;
    private boolean contrasenya_cambiada;

    public Socio(int id, String telefono, String mail, String nombre, String apellido, String contrasenya, boolean actiu, boolean administrador, int idComunitat_admin, String DNI, int id_comunitat_soci, boolean contrasenya_cambiada) {
        this.id = id;
        this.telefono = telefono;
        this.mail = mail;
        this.nombre = nombre;
        this.apellido = apellido;
        this.contrasenya = contrasenya;
        this.actiu = actiu;
        this.administrador = administrador;
        this.idComunitat_admin = idComunitat_admin;
        this.DNI = DNI;
        this.id_comunitat_soci = id_comunitat_soci;
        this.contrasenya_cambiada = contrasenya_cambiada;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getMail() {
        return mail;
    }

    public void setMail(String mail) {
        this.mail = mail;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
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

    public int getIdComunitat_admin() {
        return idComunitat_admin;
    }

    public void setIdComunitat_admin(int idComunitat_admin) {
        this.idComunitat_admin = idComunitat_admin;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public int getId_comunitat_soci() {
        return id_comunitat_soci;
    }

    public void setId_comunitat_soci(int id_comunitat_soci) {
        this.id_comunitat_soci = id_comunitat_soci;
    }

    public boolean isContrasenya_cambiada() {
        return contrasenya_cambiada;
    }

    public void setContrasenya_cambiada(boolean contrasenya_cambiada) {
        this.contrasenya_cambiada = contrasenya_cambiada;
    }
}
