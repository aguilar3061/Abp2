package com.example.appandroid;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.AssistirService;
import com.example.appandroid.API.ApiServive.ComunitatService;
import com.example.appandroid.API.ApiServive.EsdevenimentsService;

import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class EventosFinalizados extends Fragment {


    ArrayList<Assistir> assistents = new ArrayList<>();
    ArrayList<Assistir> assistentsFiltrados= new ArrayList<>();
    Spinner comboBoxComunidades;
    ArrayList<Comunitat> listaComunidades= new ArrayList<>();
    RecyclerView recView;
    AdaptadorEventos adapter;
    ArrayList<Evento> eventos = new ArrayList<>();
    ArrayList<Evento> eventosFiltrados = new ArrayList<>();
    ArrayList<Evento> eventosFinalizados = new ArrayList<>();

    Socio socio = null;


    public EventosFinalizados(Socio socio){

        this.socio = socio;

    }



    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        return inflater.inflate(R.layout.activity_eventos_finalizados,container,false);


    }

    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);

        //ArrayList<Evento> listaEventos = new ArrayList<>();


        recView = (RecyclerView) getView().findViewById(R.id.RecViewEventosF);

        EsdevenimentsService esdevenimentsService = Api.getApi().create(EsdevenimentsService.class);
        Call<List<Evento>> listCal1Eventos = esdevenimentsService.getEventos();
        listCal1Eventos.enqueue(new Callback<List<Evento>>() {
            @Override
            public void onResponse(Call<List<Evento>> call, Response<List<Evento>> response) {

                switch (response.code()){
                    case 200:
                        eventos = (ArrayList<Evento>) response.body();
                        recagrgarAsistencias();
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







        adapter = new AdaptadorEventos(eventos);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext(), RecyclerView.VERTICAL, false));
        recView.setHasFixedSize(true);
        recView.setAdapter(adapter);


        recView.setHasFixedSize(true);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext()));


    }


    public void recagrgarAsistencias(){



        AssistirService assistirService = Api.getApi().create(AssistirService.class);
        Call<List<Assistir>> listCallAssistir = assistirService.getAssistents();


        listCallAssistir.enqueue(new Callback<List<Assistir>>() {
            @Override
            public void onResponse(Call<List<Assistir>> call, Response<List<Assistir>> response) {
                switch (response.code()){
                    case 200:
                        assistents = (ArrayList<Assistir>) response.body();

                        cuandoSeRecargaTodo2();
                        break;
                    default:
                        break;
                }
            }
            @Override
            public void onFailure(Call<List<Assistir>> call, Throwable t) {
                Toast.makeText(getContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
            }
        });



    }



    public void cuandoSeRecargaTodo2(){


        //SEPARAR A LOS QUE SE ASISTE Y A LOS QUE NO

        for ( Assistir as1 : assistents) {
            if( as1.getId_Soci() == socio.getId() ){

                assistentsFiltrados.add(as1);

            }
        }


        Evento aux = null;
        for ( Evento ev1 : eventos) {
            aux = null;

            for ( Assistir as2 : assistentsFiltrados) {

                if (ev1.getId() == as2.getId_Esdeveniment()){
                    aux = ev1;
                    ev1.setApuntado(true);
                }

            }

            if (aux == null) {
                ev1.setApuntado(false);
                eventosFiltrados.add(ev1);
            }else{
                eventosFiltrados.add(aux);
            }

        }






        for ( Evento ev : eventosFiltrados) {

            Date fecha2 = null ;

            String separarFechaH1= ev.getFechaFin() ;
            String str11[] = separarFechaH1.split("T");
            String fechafinal11 = str11[0];


            String separarMinutos2 = ev.getHoraFin() ;
            String str2[] = separarMinutos2.split(":");
            String h2 = str2[0];
            String m2 = str2[1];



            SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
            SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd", Locale.getDefault());
            Date date = new Date();


            try {

                fecha2 = (Date) formatter.parse(fechafinal11);

            } catch (ParseException ex) {
                ex.printStackTrace();
            }



            if ( date.after(fecha2) ) {

                eventosFinalizados.add(ev);

            }

        }





        //ORDENAR POR FECHAAAS
        Collections.sort(eventosFinalizados);


        adapter = new AdaptadorEventos(eventosFinalizados);
        recView.setLayoutManager(new LinearLayoutManager(getActivity().getApplicationContext(), RecyclerView.VERTICAL, false));
        recView.setHasFixedSize(true);
        recView.setAdapter(adapter);



        adapter.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Toast.makeText(getContext() ,"Pulsado el elemento: " + eventosFinalizados.get(recView.getChildPosition(v)).getNombreEvento() , Toast.LENGTH_SHORT).show();



                Intent inteeentt = new Intent(getContext(), VerEvento.class);
                Evento ev1 = eventosFinalizados.get( recView.getChildPosition(v) );
                inteeentt.putExtra("evento1" , (Serializable) ev1);
                // AQUI PETA CUANDO SE HACE EL PUTEXTA
                getActivity().startActivity(inteeentt);


            }
        });







    }


}
