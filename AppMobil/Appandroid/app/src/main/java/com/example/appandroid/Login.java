package com.example.appandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class Login extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        Button acceder = (Button) findViewById(R.id.button_acceder);
        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent btnGoShopping = new Intent(Login.this, ConfirmarContrasenya.class);
                startActivity(btnGoShopping);
                Toast.makeText(getApplicationContext(), "Reestablece tu contraseña para continuar...",Toast.LENGTH_SHORT).show();
            }
        });




    }
}
