package com.example.appandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class ConfirmarContrasenya extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_confirmar_contrasenya);

        Button acceder = (Button) findViewById(R.id.button_acceder);



        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent acceder = new Intent(ConfirmarContrasenya.this, MainActivity.class);
                startActivity(acceder);
            }
        });




    }
}
