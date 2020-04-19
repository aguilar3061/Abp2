package com.example.appandroid;

import android.content.Intent;
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
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Locale;

import static androidx.core.content.ContextCompat.startActivity;

public class AdaptadorEventos extends RecyclerView.Adapter<AdaptadorEventos.EventoViewHolder> implements View.OnClickListener {


    Date fecha2 = null;
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



     /* //TEST DAVID
        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (pos == 1){







                }
            }
        });*/

    }

    @Override
    public int getItemCount() {

        return datos.size();

    }


    public static class EventoViewHolder extends RecyclerView.ViewHolder {

        private TextView txtViewNombre;
        private TextView txtViewDescripcion;
        private ImageView img;
        private TextView txtViewFechaINICIO;
        private LinearLayout linear;
        private TextView txtViewFechaFIN;
        private Date fecha2;


        public EventoViewHolder(@NonNull View itemView) {
            super(itemView);


            txtViewNombre = (TextView) itemView.findViewById(R.id.idNombre);
            txtViewDescripcion = (TextView) itemView.findViewById(R.id.idDescripcion);
            img = (ImageView) itemView.findViewById(R.id.idImg);
            txtViewFechaINICIO = (TextView) itemView.findViewById(R.id.idFechaInicio);
            linear = (LinearLayout) itemView.findViewById(R.id.idLinerLayautITEM);
            txtViewFechaFIN = (TextView) itemView.findViewById(R.id.idFechafin);

        }


        public void bindPersona(Evento t) {


            txtViewNombre.setText(t.getNombreEvento());
            txtViewDescripcion.setText(t.getDescripcion());

            //PASAR LA IMAGEN DE EL SQL AL IMAGEVIEW
            String imgByte = t.getImagen();
            try {
                byte[] encodeByte = Base64.decode(imgByte, Base64.DEFAULT);
                Bitmap bitmap = BitmapFactory.decodeByteArray(encodeByte, 0, encodeByte.length);
                img.setImageBitmap(bitmap);
            } catch (Exception e) {

                e.getMessage();

            }


            String separarFechaH = t.getFechaInicio();
            String str[] = separarFechaH.split("T");
            String fechaInicio = str[0];


            String separarMinutos = t.getHoraInicio();
            String str1[] = separarMinutos.split(":");
            String h = str1[0];
            String m = str1[1];


            txtViewFechaINICIO.setText(fechaInicio + " h." + h + ":" + m);


            String separarFechaH1 = t.getFechaFin();
            String str11[] = separarFechaH1.split("T");
            String fechafinal11 = str11[0];


            String separarMinutos2 = t.getHoraFin();
            String str2[] = separarMinutos2.split(":");
            String h2 = str2[0];
            String m2 = str2[1];

            txtViewFechaFIN.setText(fechafinal11 + " h." + h2 + ":" + m2);


            SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
            SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd", Locale.getDefault());
            Date date = new Date();


            try {
                fecha2 = (Date) formatter.parse(fechafinal11);
            } catch (ParseException ex) {
                ex.printStackTrace();
            }


            if (date.after(fecha2)) {
                // EVENTOS FINALIADOS

                if (t.isApuntado()) {

                    //EVENTO APUNTADO
                    linear.setBackgroundColor(Color.parseColor("#65D49D"));

                } else {
                    //EVENTO NO APUNTADO
                    linear.setBackgroundColor(Color.parseColor("#EF5C5C"));

                }


            } else {
                // EVENTOS NO  FINALIADOS

                if (t.isApuntado()) {
                    //EVENTO APUNTADO
                    linear.setBackgroundColor(Color.parseColor("#6BE98A"));
                } else {
                    //EVENTO NO APUNTADO
                    linear.setBackgroundColor(Color.parseColor("#9B9C9E"));

                }

            }


        }
    }

    public void setOnClickListener(View.OnClickListener listener) {


        this.listener = listener;


    }




    @Override
    public void onClick(final View view) {
        if (listener != null) {

            listener.onClick(view);


        }

    }


}
















