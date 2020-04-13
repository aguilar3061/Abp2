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
    private int idComunitat;
    private String DNI;

    public Socio(int id, String telefono, String mail, String nombre, String apellido, String contrasenya, boolean actiu, boolean administrador, int idComunitat, String DNI) {
        this.id = id;
        this.telefono = telefono;
        this.mail = mail;
        this.nombre = nombre;
        this.apellido = apellido;
        this.contrasenya = contrasenya;
        this.actiu = actiu;
        this.administrador = administrador;
        this.idComunitat = idComunitat;
        this.DNI = DNI;
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

    public int getIdComunitat() {
        return idComunitat;
    }

    public void setIdComunitat(int idComunitat) {
        this.idComunitat = idComunitat;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }
}
