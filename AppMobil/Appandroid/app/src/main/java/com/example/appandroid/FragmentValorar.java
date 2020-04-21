package com.example.appandroid;

import android.content.Context;
import android.net.Uri;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.AssistirService;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.http.Body;
import retrofit2.http.PUT;
import retrofit2.http.Path;


public class FragmentValorar extends Fragment {

    ArrayList<Assistir> assistents = new ArrayList<>();

    Assistir asistenciaDeElEventoYsocio;
    Boolean seHaIdo = false;
    Evento evento;
    Socio socio;

    public FragmentValorar(Evento evento, Socio socio) {

            this.socio = socio;
            this.evento = evento;

    }



    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_fragment_valorar, container, false);
    }



    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);


        AssistirService assistirService = Api.getApi().create(AssistirService.class);
        Call<List<Assistir>> listCallAssistir = assistirService.getAssistentsDeUnSocio(socio.getId());

        listCallAssistir.enqueue(new Callback<List<Assistir>>() {
            @Override
            public void onResponse(Call<List<Assistir>> call, Response<List<Assistir>> response) {
                switch (response.code()) {
                    case 200:

                        assistents = (ArrayList<Assistir>) response.body();
                        for (Assistir q : assistents) {

                            if (q.getId_Esdeveniment() == evento.getId()) {

                                asistenciaDeElEventoYsocio = q;
                                seHaIdo = true;
                            }
                        }

                        todoPreparado();
                        break;
                    default:
                        break;
                }
            }

            @Override
            public void onFailure(Call<List<Assistir>> call, Throwable t) {
                Toast.makeText(getContext(), t.getCause() + " - " + t.getMessage(), Toast.LENGTH_LONG).show();
            }
        });





    }





    public void todoPreparado(){

        final Button btnValorar = (Button) getView().findViewById(R.id.idBtnValorar);
        final EditText editTextValorar = (EditText) getView().findViewById(R.id.idValorar);
        final EditText editTextComentar = (EditText) getView().findViewById(R.id.idComentario);
        final LinearLayout linearLayautValorar = (LinearLayout) getView().findViewById(R.id.idLinearLayautValorar);


        if (seHaIdo) {


            btnValorar.setText("Valorar");
            btnValorar.setBackgroundResource(R.drawable.text_vew_circular_berde);
            linearLayautValorar.setVisibility(View.VISIBLE);

            btnValorar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {


                    asistenciaDeElEventoYsocio.setComentari(editTextComentar.getText().toString());
                    asistenciaDeElEventoYsocio.setValoracio(Integer.parseInt(editTextValorar.getText().toString()) );



                }
            });


        } else {


            btnValorar.setText("No se ha ido :(");
            btnValorar.setBackgroundResource(R.drawable.text_vew_circular);
            linearLayautValorar.setVisibility(View.INVISIBLE);
        }

    }



}
