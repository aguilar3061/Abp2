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
import com.example.appandroid.API.ApiServive.SocioService;

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

        todoPreparado();
/*
        AssistirService assistirService = Api.getApi().create(AssistirService.class);
        Call<List<Assistir>> listCallAssistir = assistirService.getAssistents();

        listCallAssistir.enqueue(new Callback<List<Assistir>>() {
            @Override
            public void onResponse(Call<List<Assistir>> call, Response<List<Assistir>> response) {
                switch (response.code()) {
                    case 200:

                        assistents = (ArrayList<Assistir>) response.body();
                        for (Assistir q : assistents) {

                            if (q.getId_Esdeveniment() == evento.getId() && q.getId_Soci() == socio.getId()) {

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
*/





    }





    public void todoPreparado(){

        final Button btnValorar = (Button) getView().findViewById(R.id.idBtnValorar);
        final EditText editTextValorar = (EditText) getView().findViewById(R.id.idValorar);
        final EditText editTextComentar = (EditText) getView().findViewById(R.id.idComentario);
        final LinearLayout linearLayautValorar = (LinearLayout) getView().findViewById(R.id.idLinearLayautValorar);





        if (evento.isApuntado()) {



            btnValorar.setText("Valorar");
            btnValorar.setBackgroundResource(R.drawable.text_vew_circular_berde);
            linearLayautValorar.setVisibility(View.VISIBLE);

            btnValorar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {




                    try {


                        int valoracion = Integer.parseInt(editTextValorar.getText().toString() );
                        String comentario = (editTextComentar.getText().toString());

                        asistenciaDeElEventoYsocio = new Assistir(socio.getId(), evento.getId(), true, valoracion, comentario);


                        AssistirService socioService = Api.getApi().create(AssistirService.class);
                        Call<Assistir> Updateassitir = socioService.updateAsistir(socio.getId(), asistenciaDeElEventoYsocio);

                        Updateassitir.enqueue(new Callback<Assistir>() {
                            @Override
                            public void onResponse(Call<Assistir> call, Response<Assistir> response) {

                                Toast.makeText(getContext(),"Valoracion echa correctamente GRACIAS :)" , Toast.LENGTH_LONG).show();
                            }

                            @Override
                            public void onFailure(Call<Assistir> call, Throwable t) {

                                Toast.makeText(getContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
                            }
                        });

                        getActivity().finish();


                    }catch (Exception ex){


                        Toast.makeText(getContext(),"La valoracion tiene que ser un numero entre 1 y 5." , Toast.LENGTH_LONG).show();


                    }




                }
            });


        } else {


            btnValorar.setText("No se ha ido :(");
            btnValorar.setBackgroundResource(R.drawable.text_vew_circular);
            linearLayautValorar.setVisibility(View.INVISIBLE);

        }

    }



}
