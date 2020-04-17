package com.example.appandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.SocioService;

import java.io.Serializable;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ConfirmarContrasenya extends AppCompatActivity implements Serializable {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_confirmar_contrasenya);

        Button acceder = (Button) findViewById(R.id.button_acceder);
        final EditText nuevacontrasenya = (EditText) findViewById(R.id.nuevacontrasenya);
        final EditText confirmarContrasenya = (EditText) findViewById(R.id.confirmarcontrasenya);

        final Socio soci = (Socio) getIntent().getSerializableExtra("socio");
        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if (nuevacontrasenya.getText().toString().equals("") || confirmarContrasenya.getText().toString().equals(""))
                {
                    Toast.makeText(getApplicationContext(), "Uno de los campos esta vacio.",Toast.LENGTH_LONG).show();
                }
                else if (!nuevacontrasenya.getText().toString().equals(confirmarContrasenya.getText().toString()))
                {
                    Toast.makeText(getApplicationContext(), "Las contraseñas no coinciden.",Toast.LENGTH_LONG).show();
                }
                else
                {
                    soci.setContrasena_cambiada(true);
                    soci.setContrasenya(nuevacontrasenya.getText().toString());
                    SocioService socioService = Api.getApi().create(SocioService.class);
                    Call<Socio> UpdateSocio = socioService.updateSocio(soci.getId(),soci);

                    UpdateSocio.enqueue(new Callback<Socio>() {
                        @Override
                        public void onResponse(Call<Socio> call, Response<Socio> response) {

                        }

                        @Override
                        public void onFailure(Call<Socio> call, Throwable t) {
                            Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
                        }
                    });




                    Intent acceder = new Intent(ConfirmarContrasenya.this, MainActivity.class);
                    acceder.putExtra("socio",soci);
                    startActivity(acceder);



                    /////////////
                }

            }
        });




    }
}
