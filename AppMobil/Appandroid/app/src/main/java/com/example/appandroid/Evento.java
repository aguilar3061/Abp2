package com.example.appandroid;

public class Evento {

    private int id;
    private String fechaInicio;
    private String fechaFin;
    private String horaInicio;
    private String horaFin;
    private String NombreEvento;
    private String Direccion;
    private int idComunitat;


    public Evento(String nombreEvento) {
        NombreEvento = nombreEvento;
    }

    public Evento(int id, String fechaInicio, String fechaFin, String horaInicio, String horaFin, String nombreEvento, String direccion, int idComunitat) {
        this.id = id;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        NombreEvento = nombreEvento;
        Direccion = direccion;
        this.idComunitat = idComunitat;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setFechaInicio(String fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public void setFechaFin(String fechaFin) {
        this.fechaFin = fechaFin;
    }

    public void setHoraInicio(String horaInicio) {
        this.horaInicio = horaInicio;
    }

    public void setHoraFin(String horaFin) {
        this.horaFin = horaFin;
    }

    public void setNombreEvento(String nombreEvento) {
        NombreEvento = nombreEvento;
    }

    public void setDireccion(String direccion) {
        Direccion = direccion;
    }

    public void setIdComunitat(int idComunitat) {
        this.idComunitat = idComunitat;
    }

    public int getId() {
        return id;
    }

    public String getFechaInicio() {
        return fechaInicio;
    }

    public String getFechaFin() {
        return fechaFin;
    }

    public String getHoraInicio() {
        return horaInicio;
    }

    public String getHoraFin() {
        return horaFin;
    }

    public String getNombreEvento() {
        return NombreEvento;
    }

    public String getDireccion() {
        return Direccion;
    }

    public int getIdComunitat() {
        return idComunitat;
    }
}
