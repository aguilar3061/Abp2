package com.example.appandroid;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;


import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.SocioService;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    private List<Socio> socis;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //SOCIOS!!!!!!!!!!!!!!!!!!!!

        SocioService socioService = Api.getApi().create(SocioService.class);
        Call<List<Socio>> listCall = socioService.getSocis();

        listCall.enqueue(new Callback<List<Socio>>() {
            @Override
            public void onResponse(Call<List<Socio>> call, Response<List<Socio>> response) {
                switch (response.code()){
                    case 200:
                        socis = response.body();
                        break;
                    default:
                        break;

                }
            }

            @Override
            public void onFailure(Call<List<Socio>> call, Throwable t) {
                Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
            }
        });
        //SOCIOS!!!!!!!!!!!!!!!!!!!!
        setContentView(R.layout.activity_main);

        if (savedInstanceState == null){
            getSupportFragmentManager().beginTransaction().replace(R.id.frameLayout, new Eventos()).commit();
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
                    fragment = new Eventos();
                    break;

                case R.id.nav_eventOff:
                    fragment = new EventosFinalizados();
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