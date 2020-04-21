package com.example.appandroid;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.AssistirService;
import com.example.appandroid.API.ApiServive.EsdevenimentsService;

import retrofit2.Call;
import retrofit2.Callback;


public class FragmentApuntarse extends Fragment {


    Evento evento;
    Socio socio;

    public FragmentApuntarse(Evento evento, Socio socio) {


        this.evento = evento;
        this.socio = socio;

    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_fragment_apuntarse, container, false);
    }


    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);

        final Button btnParticipar = (Button) getView().findViewById(R.id.buttonApuntarse);
        final EditText editTextCuants = (EditText)  getView().findViewById(R.id.idCuants);


        btnParticipar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {


                evento.setCuants(Integer.parseInt(editTextCuants.getText().toString()) + evento.getCuants());
                Assistir asistencia = new Assistir(socio.getId(), evento.getId(), true, 0, "");




                AssistirService asistirService = Api.getApi().create(AssistirService.class);
                Call<Assistir> insertAsistencia = asistirService.insertAsistencia(asistencia);
                insertAsistencia.enqueue(new Callback<Assistir>() {

                    @Override
                    public void onResponse(Call<Assistir> call, retrofit2.Response<Assistir> response) {
                        Toast.makeText(getContext(), "Asistencia añadidaa", Toast.LENGTH_LONG).show();
                    }

                    @Override
                    public void onFailure(Call<Assistir> call, Throwable t) {
                        Toast.makeText(getContext(), t.getCause() + " - " + t.getMessage(), Toast.LENGTH_LONG).show();
                    }
                });





                EsdevenimentsService eventoService = Api.getApi().create(EsdevenimentsService.class);
                Call<Evento> UpdateEvento = eventoService.updateEsdeveniments(evento.getId(), evento);
                UpdateEvento.enqueue(new Callback<Evento>() {
                    @Override
                    public void onResponse(Call<Evento> call, retrofit2.Response<Evento> response) {

                    }

                    @Override
                    public void onFailure(Call<Evento> call, Throwable t) {
                        Toast.makeText(getContext(), t.getCause() + " - " + t.getMessage(), Toast.LENGTH_LONG).show();
                    }
                });




                getActivity().finish();




            }
        });




    }















}
