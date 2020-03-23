package com.example.appandroid;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.google.android.material.bottomnavigation.BottomNavigationView;

public class PantallaPrincipal extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_principal);

        Button acceder = (Button) findViewById(R.id.button_acceder);
        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent btnGoShopping = new Intent(PantallaPrincipal.this, Login.class);
                startActivity(btnGoShopping);
                Toast.makeText(getApplicationContext(), "Inicia sesión con tus datos.", Toast.LENGTH_SHORT).show();
            }
        });


    }


}
