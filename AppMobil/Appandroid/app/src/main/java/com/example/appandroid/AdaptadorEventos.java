package com.example.appandroid;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
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

        public EventoViewHolder(@NonNull View itemView) {
            super(itemView);


            txtViewNombre = (TextView)itemView.findViewById(R.id.idNombre);
            txtViewDescripcion = (TextView)itemView.findViewById(R.id.idDescripcion);
            img = (ImageView)itemView.findViewById(R.id.idImg);

        }



        public void bindPersona(Evento t) {


            txtViewNombre.setText(t.getNombreEvento());
            //txtViewDescripcion.setText(t.getDescripcion());
            //img.setImageURI();


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
