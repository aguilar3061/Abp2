package com.example.appandroid;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.net.Uri;
import android.util.Base64;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class AdaptadorEventos extends RecyclerView.Adapter<AdaptadorEventos.EventoViewHolder> implements View.OnClickListener {



    private ArrayList<Evento> datos;
    private View.OnClickListener listener;

    public AdaptadorEventos(ArrayList<Evento> datos) {

        this.datos = datos;

    }



    @NonNull
    @Override
    public EventoViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {

        View itemView = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_list_eventos, parent, false);

        itemView.setOnClickListener(this);
        EventoViewHolder tvh = new EventoViewHolder(itemView);

        return tvh;


    }

    @Override
    public void onBindViewHolder(@NonNull EventoViewHolder holder, int position) {

        Evento item = datos.get(position);

        holder.bindPersona(item);


    }

    @Override
    public int getItemCount() {

        return datos.size();

    }




    public static class EventoViewHolder extends RecyclerView.ViewHolder {

        private TextView txtViewNombre;
        private TextView txtViewDescripcion;
        private ImageView img;
        private TextView txtViewFecha;
        private LinearLayout linear;


        public EventoViewHolder(@NonNull View itemView) {
            super(itemView);


            txtViewNombre = (TextView)itemView.findViewById(R.id.idNombre);
            txtViewDescripcion = (TextView)itemView.findViewById(R.id.idDescripcion);
            img = (ImageView)itemView.findViewById(R.id.idImg);
            txtViewFecha = (TextView) itemView.findViewById(R.id.idFecha);
            linear = (LinearLayout) itemView.findViewById(R.id.idLinerLayautITEM);
        }



        public void bindPersona(Evento t) {


            txtViewNombre.setText(t.getNombreEvento());
            txtViewDescripcion.setText(t.getDescripcion());

            //PASAR LA IMAGEN DE EL SQL AL IMAGEVIEW
            String imgByte = t.getImagen();
            try{
                byte [] encodeByte= Base64.decode(imgByte,Base64.DEFAULT);
                Bitmap bitmap= BitmapFactory.decodeByteArray(encodeByte, 0, encodeByte.length);
                img.setImageBitmap(bitmap);
            }catch(Exception e){

                e.getMessage();

            }


            String separarFechaH = t.getFechaInicio() ;
            String str[] = separarFechaH.split("T");
            String fechaInicio = str[0];


            String separarMinutos = t.getHoraInicio() ;
            String str1[] = separarMinutos.split(":");
            String h = str1[0];
            String m = str1[1];


            txtViewFecha.setText(fechaInicio + " h." + h + ":" + m);


            if ( t.isApuntado() ){

                linear.setBackgroundColor(Color.parseColor("#6BE98A"));
            }
            else{

                linear.setBackgroundColor(Color.parseColor("#9B9C9E"));

            }



        }
    }

    public void setOnClickListener(View.OnClickListener listener) {
        this.listener = listener;
    }

    @Override
    public void onClick(View view) {
        if(listener != null) {
            listener.onClick(view);
        }

    }

















}
