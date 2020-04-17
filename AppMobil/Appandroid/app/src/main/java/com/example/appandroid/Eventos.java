package com.example.appandroid;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.EsdevenimentsService;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Eventos extends Fragment {



    RecyclerView recView;
    AdaptadorEventos adapter;
    ArrayList<Evento> eventos = new ArrayList<>();



    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.activity_eventos,container,false);
    }

    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);

        //ArrayList<Evento> listaEventos = new ArrayList<>();
        Spinner comboBoxComunidades = (Spinner) getView().findViewById(R.id.idSpinerComunidad);


        recView = (RecyclerView) getView().findViewById(R.id.RecViewEventos);



        EsdevenimentsService esdevenimentsService = Api.getApi().create(EsdevenimentsService.class);
        Call<List<Evento>> listCal1Eventos = esdevenimentsService.getEventos();
        listCal1Eventos.enqueue(new Callback<List<Evento>>() {
            @Override
            public void onResponse(Call<List<Evento>> call, Response<List<Evento>> response) {

                switch (response.code()){
                    case 200:
                        eventos = (ArrayList<Evento>) response.body();
                        adapter = new AdaptadorEventos(eventos);
                        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext(), RecyclerView.VERTICAL, false));
                        recView.setHasFixedSize(true);
                        recView.setAdapter(adapter);

                        break;
                    default:
                        break;

                }
            }

            @Override
            public void onFailure(Call<List<Evento>> call, Throwable t) {
                Toast.makeText(getContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
            }
        });






/*

        listaEventos.add(new Evento("HOLAA1"));
        listaEventos.add(new Evento("ADIIIOS1"));
        listaEventos.add(new Evento("QUE TAL1"));
        listaEventos.add(new Evento("HOLAA2"));
        listaEventos.add(new Evento("ADIIIOS2"));
        listaEventos.add(new Evento("QUE TAL2"));
        listaEventos.add(new Evento("HOLAA3"));
        listaEventos.add(new Evento("ADIIIOS3"));
        listaEventos.add(new Evento("QUE TAL3"));
*/

        adapter = new AdaptadorEventos(eventos);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext(), RecyclerView.VERTICAL, false));
        recView.setHasFixedSize(true);
        recView.setAdapter(adapter);



        recView.setHasFixedSize(true);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext()));



    }





}
