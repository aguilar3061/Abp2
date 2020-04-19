package com.example.appandroid;


import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;


@SuppressWarnings("serial")
public class Evento implements Comparable<Evento> ,Serializable {

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


    public Evento(int id, String fechaInicio, String horaInicio, String nombreEvento, String direccio, int id_Comunitat, String fechaFin, String horaFin, int cuants, String imagen, String descripcion, boolean apuntado) {
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
        this.apuntado = apuntado;
    }

    public Evento() {

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




    @Override
    public int compareTo(Evento e){

        SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
        Date fecha1 = null;
        Date fecha2 = null;


        try {
            String separarMinutos1 = e.getFechaInicio() ;
            String str1[] = separarMinutos1.split("T");
            String fecha11 = str1[0];
            fecha1 = (Date) formatter.parse(fecha11);
        } catch (ParseException ex) {
            ex.printStackTrace();
        }



        try {
            String separarMinutos2 = fechaInicio;
            String str2[] = separarMinutos2.split("T");
            String fecha22 = str2[0];
            fecha2 = (Date) formatter.parse(fecha22);
        } catch (ParseException ex) {
            ex.printStackTrace();
        }




        if(fecha1.after(fecha2)){


            return -1;


        }else if(fecha1.after(fecha2)){

            return 0;


        }else{

            return 1;

        }


    }






}
