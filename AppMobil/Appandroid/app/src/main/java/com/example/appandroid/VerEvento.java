package com.example.appandroid;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class VerEvento extends AppCompatActivity  {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_evento);

        final Evento obj = (Evento) getIntent().getExtras().getSerializable("evento1");

        final TextView txtViewNombre = (TextView)findViewById(R.id.idNombreE);
        final ImageView img = (ImageView) findViewById(R.id.idImgEventoo);


        txtViewNombre.setText( obj.getNombreEvento().toString() );

        String imgByte = obj.getImagen();
        try{

            byte [] encodeByte= Base64.decode(imgByte,Base64.DEFAULT);
            Bitmap bitmap= BitmapFactory.decodeByteArray(encodeByte, 0, encodeByte.length);
            img.setImageBitmap(bitmap);

        }catch(Exception e){
            e.getMessage();
        }



        final Button btnInfo = (Button) findViewById(R.id.button_informacion);
        final Button btnUbi= (Button) findViewById(R.id.button_ubicacion);
        final Button btnParticipar = (Button) findViewById(R.id.buttonApuntarse);
        final EditText editTextCuants = (EditText) findViewById(R.id.idCuants);

        btnInfo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                FragmentInformacion fragment = new FragmentInformacion(obj);
                getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentEventooo, fragment).commit();

            }
        });

        btnUbi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                FragmentUbicacion fragment = new FragmentUbicacion(obj);
                getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentEventooo, fragment).commit();


            }
        });



        btnParticipar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Toast.makeText(getApplicationContext() , "Apuntado al evento: " + obj.getNombreEvento() , Toast.LENGTH_SHORT).show();



                obj.setCuants(Integer.parseInt( editTextCuants.getText().toString() ) );
                finish();

            }
        });




    }

}
