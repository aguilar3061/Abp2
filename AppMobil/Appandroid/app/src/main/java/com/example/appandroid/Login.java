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

public class Login extends AppCompatActivity implements Serializable {
    private List<Socio> socis;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        //SOCIOS!!!!!!!!!!!!!!!!!!!!

        final EditText textDNI = (EditText) findViewById(R.id.dni);
        final EditText textPassword = (EditText) findViewById(R.id.contrasenya);

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


        Button acceder = (Button) findViewById(R.id.button_acceder);
        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                boolean loginCorrecte = false;
                 Socio soci = new Socio();
                for(int i=0; i < socis.size(); i++)
                {
                    if (textDNI.getText().equals(socis.get(i).getDNI()) && textPassword.getText().equals(socis.get(i).getContrasenya()))
                    {
                        loginCorrecte = true;
                        soci = socis.get(i);

                    }
                }

                if (loginCorrecte == true)
                {
                    if (soci.isContrasena_cambiada() == false)
                    {
                    Intent btnGoShopping = new Intent(Login.this, ConfirmarContrasenya.class);
                    btnGoShopping.putExtra("socio", soci);
                    startActivity(btnGoShopping);
                    Toast.makeText(getApplicationContext(), "Reestablece tu contraseña para continuar...",Toast.LENGTH_SHORT).show();

                    }
                    else
                    {
                        Intent acceder = new Intent(Login.this, MainActivity.class);
                        acceder.putExtra("socio", soci);
                        startActivity(acceder);
                    }
                }
                else
                {
                    Toast.makeText(getApplicationContext(), "El dni y la contraseña no coinciden con ningun usuario",Toast.LENGTH_LONG).show();
                }


            }
        });




    }
}
