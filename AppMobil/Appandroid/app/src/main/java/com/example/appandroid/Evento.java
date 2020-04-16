package com.example.appandroid;

public class Evento {

    private int id;
    private String fechaInicio;
    private String horaInicio;
    private String NombreEvento;
    private String Direccion;
    private int idComunitat;
    private String fechaFin;
    private String horaFin;
    private int quants;
    private String imgByte;
    private String descripcio;




    public Evento(String nombreEvento) {
        NombreEvento = nombreEvento;
    }


    public Evento(int id, String fechaInicio, String horaInicio, String nombreEvento, String direccion, int idComunitat, String fechaFin, String horaFin, int quants, String imgByte, String descripcio) {
        this.id = id;
        this.fechaInicio = fechaInicio;
        this.horaInicio = horaInicio;
        NombreEvento = nombreEvento;
        Direccion = direccion;
        this.idComunitat = idComunitat;
        this.fechaFin = fechaFin;
        this.horaFin = horaFin;
        this.quants = quants;
        this.imgByte = imgByte;
        this.descripcio = descripcio;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(String fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public String getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(String horaInicio) {
        this.horaInicio = horaInicio;
    }

    public String getNombreEvento() {
        return NombreEvento;
    }

    public void setNombreEvento(String nombreEvento) {
        NombreEvento = nombreEvento;
    }

    public String getDireccion() {
        return Direccion;
    }

    public void setDireccion(String direccion) {
        Direccion = direccion;
    }

    public int getIdComunitat() {
        return idComunitat;
    }

    public void setIdComunitat(int idComunitat) {
        this.idComunitat = idComunitat;
    }

    public String getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(String fechaFin) {
        this.fechaFin = fechaFin;
    }

    public String getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(String horaFin) {
        this.horaFin = horaFin;
    }

    public int getQuants() {
        return quants;
    }

    public void setQuants(int quants) {
        this.quants = quants;
    }

    public String getImgByte() {
        return imgByte;
    }

    public void setImgByte(String imgByte) {
        this.imgByte = imgByte;
    }

    public String getDescripcio() {
        return descripcio;
    }

    public void setDescripcio(String descripcio) {
        this.descripcio = descripcio;
    }
}
