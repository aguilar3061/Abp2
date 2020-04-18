package com.example.appandroid;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;


import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.AssistirService;
import com.example.appandroid.API.ApiServive.ComunitatService;
import com.example.appandroid.API.ApiServive.EsdevenimentsService;
import com.example.appandroid.API.ApiServive.SocioService;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    Socio socio;
    private List<Evento> eventos;
    private List<Comunitat> comunitats;
    private List<Assistir> assistents;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


        socio = (Socio) getIntent().getExtras().getSerializable("socio");


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //ESDEVENIMENTS!!!!!!!!!!!!!!!!!
/*

        EsdevenimentsService esdevenimentsService = Api.getApi().create(EsdevenimentsService.class);
        Call<List<Evento>> listCal1Eventos = esdevenimentsService.getEventos();

        listCal1Eventos.enqueue(new Callback<List<Evento>>() {
            @Override
            public void onResponse(Call<List<Evento>> call, Response<List<Evento>> response) {

                switch (response.code()){
                    case 200:
                        eventos = response.body();
                        break;
                    default:
                        break;

                }
            }

            @Override
            public void onFailure(Call<List<Evento>> call, Throwable t) {
                Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
            }
        });
*/

        //ESDEVENIMENTS!!!!!!!!!!!!!!!!!
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //COMUNITATS!!!!!!!!!!!!!!!!!!!

     /*

      ComunitatService comunitatService = Api.getApi().create(ComunitatService.class);
        Call<List<Comunitat>> listCallComunitats = comunitatService.getComunidades();

        listCallComunitats.enqueue(new Callback<List<Comunitat>>() {
            @Override
            public void onResponse(Call<List<Comunitat>> call, Response<List<Comunitat>> response) {
                switch (response.code()) {
                    case 200:
                        comunitats = response.body();
                        break;
                    default:
                        break;

                }
            }

            @Override
            public void onFailure(Call<List<Comunitat>> call, Throwable t) {
                Toast.makeText(getApplicationContext(), t.getCause() + " - " + t.getMessage(), Toast.LENGTH_LONG).show();
            }
        });

        */
        //COMUNITATS!!!!!!!!!!!!!!!!!!!
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //ASSISTENTS!!!!!!!!!!!!!!!!!!

     /*
     AssistirService assistirService = Api.getApi().create(AssistirService.class);
        Call<List<Assistir>> listCallAssistir = assistirService.getAssistents();

        listCallAssistir.enqueue(new Callback<List<Assistir>>() {
            @Override
            public void onResponse(Call<List<Assistir>> call, Response<List<Assistir>> response) {
                switch (response.code()){
                    case 200:
                        assistents = response.body();
                        break;
                    default:
                        break;

                }
            }

            @Override
            public void onFailure(Call<List<Assistir>> call, Throwable t) {
                Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
            }
        });

        */
        //ASSISTENTS!!!!!!!!!!!!!!!!!!
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        setContentView(R.layout.activity_main);

        if (savedInstanceState == null){
            getSupportFragmentManager().beginTransaction().replace(R.id.frameLayout, new Eventos(socio)).commit();
        }


        BottomNavigationView bottomNavigationView = (BottomNavigationView) findViewById(R.id.navigationbar);
        bottomNavigationView.setOnNavigationItemSelectedListener(navigationItemSelectedListener);

    }

    private BottomNavigationView.OnNavigationItemSelectedListener navigationItemSelectedListener = new BottomNavigationView.OnNavigationItemSelectedListener() {
        @Override
        public boolean onNavigationItemSelected(@NonNull MenuItem item) {
            Fragment fragment = null;

            switch (item.getItemId()){

                case R.id.nav_help:
                    fragment = new Ayuda();
                    break;

                case R.id.nav_eventOn:
                    fragment = new Eventos(socio);
                    break;

                case R.id.nav_eventOff:
                    fragment = new EventosFinalizados(socio);
                    break;

                case R.id.nav_profile:
                    fragment = new Perfil();
                    break;

            }

            getSupportFragmentManager().beginTransaction().replace(R.id.frameLayout, fragment).commit();
            return true;

        }
    };

}