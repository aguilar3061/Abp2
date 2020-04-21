package com.example.appandroid;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class VerEvento extends AppCompatActivity  {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_evento);

        final Evento evento = (Evento) getIntent().getExtras().getSerializable("evento1");
        final Socio socio = (Socio) getIntent().getExtras().getSerializable("socio1");

        //LinearLayout apuntarse = (LinearLayout) findViewById(R.id.idLinerLayautApuntarse);

        //LinearLayout puntuar = (LinearLayout) findViewById(R.id.idLinerLayautValorar);


        final TextView txtViewNombre = (TextView)findViewById(R.id.idNombreE);
        final ImageView img = (ImageView) findViewById(R.id.idImgEventoo);

        txtViewNombre.setText( evento.getNombreEvento().toString() );

        String imgByte = evento.getImagen();
        try{

            byte [] encodeByte= Base64.decode(imgByte,Base64.DEFAULT);
            Bitmap bitmap= BitmapFactory.decodeByteArray(encodeByte, 0, encodeByte.length);
            img.setImageBitmap(bitmap);

        }catch(Exception e){
            e.getMessage();
        }



        final Button btnInfo = (Button) findViewById(R.id.button_informacion);
        final Button btnUbi= (Button) findViewById(R.id.button_ubicacion);

        btnInfo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                FragmentInformacion fragment = new FragmentInformacion(evento);
                getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentEventooo, fragment).commit();

            }
        });

        btnUbi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                FragmentUbicacion fragment = new FragmentUbicacion(evento);
                getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentEventooo, fragment).commit();

                Intent intent = new Intent(getApplicationContext(), Fragment_ubicacion_mapa.class);
                startActivity(intent);


            }
        });






        Boolean sePuedeVotar = true;
        Date fecha2 = null ;

        String separarFechaH1= evento.getFechaFin() ;
        String str11[] = separarFechaH1.split("T");
        String fechafinal11 = str11[0];



        SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
        Date date = new Date();

        try {

            fecha2 = (Date) formatter.parse(fechafinal11);

        } catch (ParseException ex) {
            ex.printStackTrace();
        }


        if ( date.before(fecha2) ) {

            sePuedeVotar = false;

        }


        if (sePuedeVotar) {

            FragmentValorar fragment = new FragmentValorar(evento, socio);
            getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentValorarOapuntarse, fragment).commit();


        }else{

            FragmentApuntarse fragment = new FragmentApuntarse(evento, socio);
            getSupportFragmentManager().beginTransaction().replace(R.id.FrgmentValorarOapuntarse, fragment).commit();

        }








    }

}
