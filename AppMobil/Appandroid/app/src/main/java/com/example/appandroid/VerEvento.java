package com.example.appandroid;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.appandroid.API.Api;
import com.example.appandroid.API.ApiServive.AssistirService;
import com.example.appandroid.API.ApiServive.EsdevenimentsService;
import com.example.appandroid.API.ApiServive.SocioService;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class VerEvento extends AppCompatActivity  {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_evento);

        final Evento evento = (Evento) getIntent().getExtras().getSerializable("evento1");
        final Socio socio = (Socio) getIntent().getExtras().getSerializable("socio1");

        LinearLayout apuntarse = (LinearLayout) findViewById(R.id.idLinerLayautApuntarse);

        LinearLayout puntuar = (LinearLayout) findViewById(R.id.idLinerLayautValorar);


        final TextView txtViewNombre = (TextView)findViewById(R.id.idNombreE);
        final ImageView img = (ImageView) findViewById(R.id.idImgEventoo);

        final Button btnParticipar = (Button) findViewById(R.id.buttonApuntarse);
        final EditText editTextCuants = (EditText) findViewById(R.id.idCuants);

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


            if ( apuntarse.getVisibility()== View.VISIBLE ) {

                apuntarse.setVisibility(View.INVISIBLE);

            }


        }else{


            if ( apuntarse.getVisibility()== View.INVISIBLE ) {

                apuntarse.setVisibility(View.VISIBLE);

            }

            btnParticipar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {


                    evento.setCuants(Integer.parseInt( editTextCuants.getText().toString() ) + evento.getCuants() );

                    Assistir asistencia = new Assistir(socio.getId(), evento.getId() , true, 0 , "");

                    AssistirService asistirService = Api.getApi().create(AssistirService.class);
                    Call<Assistir> insertAsistencia = asistirService.insertAsistencia(asistencia);

                    insertAsistencia.enqueue(new Callback<Assistir>() {
                        @Override
                        public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                            Toast.makeText(getApplicationContext(),"Asistencia añadidaa" , Toast.LENGTH_LONG).show();
                        }

                        @Override
                        public void onFailure(Call<Assistir> call, Throwable t) {
                            Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
                        }
                    });




                    EsdevenimentsService eventoService = Api.getApi().create(EsdevenimentsService.class);
                    Call<Evento> UpdateEvento = eventoService.updateEsdeveniments(evento.getId(),evento);

                    UpdateEvento.enqueue(new Callback<Evento>() {
                        @Override
                        public void onResponse(Call<Evento> call, Response<Evento> response) {


                        }

                        @Override
                        public void onFailure(Call<Evento> call, Throwable t) {
                            Toast.makeText(getApplicationContext(),t.getCause()+ " - " + t.getMessage() , Toast.LENGTH_LONG).show();
                        }
                    });

                    finish();

                }
            });
        }








    }

}
