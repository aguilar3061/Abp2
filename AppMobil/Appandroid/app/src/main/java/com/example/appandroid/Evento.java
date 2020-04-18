package com.example.appandroid;

public class Evento {

    private int id;
    private String fechaInicio;
    private String horaInicio;
    private String NombreEvento;
    private String Direccio;
    private int id_Comunitat;
    private String fechaFin;
    private String horaFin;
    private int cuants;
    private String imagen;
    private String descripcion;

    private boolean apuntado;



    public Evento(String nombreEvento) {
        NombreEvento = nombreEvento;
    }

    public Evento(int id, String fechaInicio, String horaInicio, String nombreEvento, String direccio, int id_Comunitat, String fechaFin, String horaFin, int cuants, String imagen, String descripcion) {
        this.id = id;
        this.fechaInicio = fechaInicio;
        this.horaInicio = horaInicio;
        NombreEvento = nombreEvento;
        Direccio = direccio;
        this.id_Comunitat = id_Comunitat;
        this.fechaFin = fechaFin;
        this.horaFin = horaFin;
        this.cuants = cuants;
        this.imagen = imagen;
        this.descripcion = descripcion;
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

    public String getDireccio() {
        return Direccio;
    }

    public void setDireccio(String direccio) {
        Direccio = direccio;
    }

    public int getId_Comunitat() {
        return id_Comunitat;
    }

    public void setId_Comunitat(int id_Comunitat) {
        this.id_Comunitat = id_Comunitat;
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

    public int getCuants() {
        return cuants;
    }

    public void setCuants(int cuants) {
        this.cuants = cuants;
    }

    public String getImagen() {
        return imagen;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }




    public void setApuntado(boolean apuntado) {
        this.apuntado = apuntado;
    }

    public boolean isApuntado() {
        return apuntado;
    }


}
