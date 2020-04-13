package com.example.appandroid;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class EventosFinalizados extends Fragment {



    RecyclerView recView;
    AdaptadorEventos adapter;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.activity_eventos_finalizados,container,false);
    }



    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);

        ArrayList<Evento> listaEventos = new ArrayList<>();


        recView = (RecyclerView) getView().findViewById(R.id.RecViewEventosF);




        listaEventos.add(new Evento("HOLAA1"));
        listaEventos.add(new Evento("ADIIIOS1"));




        adapter = new AdaptadorEventos(listaEventos);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext(), RecyclerView.VERTICAL, false));
        recView.setHasFixedSize(true);
        recView.setAdapter(adapter);


        recView.setHasFixedSize(true);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext()));



    }




}
